using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowPlayTest
{
    public partial class ShadowPlayHiddenSettingsMgr : Form
    {
        ShadowPlayDevice _device = new ShadowPlayDevice();

        public ShadowPlayHiddenSettingsMgr()
        {
            InitializeComponent();

            LoadDeviceSettings();
        }

        private void LoadDeviceSettings()
        {
            ShadowPlayDevice.RecordingSettings settings = _device.RecordSettings;

            tbRecWidth.Text     = settings.Width.ToString();
            tbRecHeight.Text    = settings.Height.ToString();
            tbShadowTime.Text   = settings.ShadowTime.ToString();
            tbRecFPS.Text       = settings.TargetFPS.ToString();
            tbOutputLoc.Text    = settings.OutputLocation;

            cbAudioMode.Text    = settings.AudioMode;
            cbVideoQuality.Text = settings.VideoQuality;
            cbIndicatorPos.Text = settings.IndicatorPosition;
        }

        private void SaveDeviceSettings()
        {
            try
            {
                ShadowPlayDevice.RecordingSettings settings = _device.RecordSettings;

                settings.Width = Int32.Parse(tbRecWidth.Text);
                settings.Height = Int32.Parse(tbRecHeight.Text);
                settings.TargetFPS = Single.Parse(tbRecFPS.Text);
                settings.OutputLocation = tbOutputLoc.Text;

                settings.AudioMode = cbAudioMode.Text;
                settings.VideoQuality = cbVideoQuality.Text;
                settings.IndicatorPosition = cbIndicatorPos.Text;

                _device.RecordSettings = settings;

                LoadDeviceSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving ShadowPlay settings: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Resetting to defaults CAN CAUSE ISSUES if not running on the correct version of ShadowPlay. If you got a previous warning about being on the wrong version, STOP NOW. This feature is NOT guaranteed to work by ANY means, use with caution!", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tbRecWidth.Text = "1920";
                tbRecHeight.Text = "1080";
                tbShadowTime.Text = "600";
                tbRecFPS.Text = "60";

                // Don't touch the output location, that should never break anything.
                cbAudioMode.Text = "AudioNone";
                cbVideoQuality.Text = "Average";
                cbIndicatorPos.Text = "RightBottom";

                SaveDeviceSettings();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Saving settings CAN CAUSE ISSUES if not running on the correct version of ShadowPlay. If you got a previous warning about being on the wrong version, STOP NOW. This feature is NOT guaranteed to work by ANY means, use with caution!", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                SaveDeviceSettings();
            }
        }
    }
}
