using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using NVIDIA.Win32.ShadowPlay;
using System.Windows.Forms;

namespace ShadowPlayTest
{
    public class ShadowPlayDevice
    {
        public struct RecordingSettings
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public float TargetFPS { get; set; }
            public int ShadowTime { get; set; }

            public String AudioMode { get; set; }
            public String VideoQuality { get; set; }
            public String IndicatorPosition { get; set; }
            public String OutputLocation { get; set; }
        }

        private ShadowPlayServer _server;
        private IntPtr _serverPointer;

        private RecordingSettings _recordingSettings;

        public ShadowPlayDevice(int version = 0)
        {
            if (version == 0)
            {
                int min = 0, max = 0;

               NativeMethods.QueryShadowPlayInterfaceVersionRange(ref min, ref max);

                if (max == 0)
                    throw new InvalidOperationException("This machine does not support Nvidia ShadowPlay!");

                if (max < 3)
                    version = max;
                else if (min <= 3)
                    version = 3;
                else
                    version = min;

                if (version != 3)
                    MessageBox.Show("Warning! Attempting to run on version " + version + " instead of 3, this configuration is UNTESTED and may fail! USE AT YOUR OWN RISK."); 
            }


            if (NativeMethods.QueryShadowPlayInterface(version, out _serverPointer) != 0)
            {
                throw new InvalidOperationException("This machine does not support ShadowPlay version " + version);
            }

            // otherwise, go about buisiness as usual
            _server = (ShadowPlayServer) Marshal.PtrToStructure(_serverPointer, _server.GetType());

            if (!isServerValid(ref _server))
                throw new InvalidOperationException("Nvidia APIs gave us back an invalid object!");
        }

        public RecordingSettings RecordSettings {
            get
            {
                _pullDeviceSettings();
                return _recordingSettings;
            }
            set
            {
                _recordingSettings = value;
                _pushDeviceSettings();
            }
        }

        private void _pushDeviceSettings()
        {
            _setProperty<int>("VideoWidth",                    _recordingSettings.Width);
            _setProperty<int>("VideoHeight",                   _recordingSettings.Height);
            _setProperty<float>("RecordingFPS",                _recordingSettings.TargetFPS);
            _setProperty<int>("DVRBufferLen",                  _recordingSettings.ShadowTime);
            _setProperty<string>("AudioMode",                  _recordingSettings.AudioMode);
            _setProperty<string>("EncoderProfile",             _recordingSettings.VideoQuality);
            _setProperty<string>("RecordingIndicatorPosition", _recordingSettings.IndicatorPosition);
            _setProperty<string>("DefaultPath",                _recordingSettings.OutputLocation);
        }

        private void _pullDeviceSettings()
        {
            _recordingSettings.Width             = _getProperty<int>("VideoWidth");
            _recordingSettings.Height            = _getProperty<int>("VideoHeight");
            _recordingSettings.TargetFPS         = _getProperty<float>("RecordingFPS");
            _recordingSettings.ShadowTime        = _getProperty<int>("DVRBufferLen");
            _recordingSettings.AudioMode         = _getProperty<string>("AudioMode");
            _recordingSettings.VideoQuality      = _getProperty<string>("EncoderProfile");
            _recordingSettings.IndicatorPosition = _getProperty<string>("RecordingIndicatorPosition");
            _recordingSettings.OutputLocation    = _getProperty<string>("DefaultPath");
        }

        private void _setProperty<T>(string propertyName, T t)
        {
            object val = (object)t;
            _server.SetProperty(propertyName, ref val);
        }

        private T _getProperty<T>(string propertyName)
        {
            object val = null;
            _server.GetProperty(propertyName, ref val);

            return (T) val;
        }

        private static bool isServerValid(ref ShadowPlayServer server)
        {
            if (server.Run == null || server.Shutdown == null || server.GetState == null || server.GetProperty == null || server.SetProperty == null)
                return false;

            return true;
        }
    }
}
