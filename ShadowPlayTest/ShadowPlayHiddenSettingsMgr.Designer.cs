namespace ShadowPlayTest
{
    partial class ShadowPlayHiddenSettingsMgr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            this.tbRecWidth = new System.Windows.Forms.TextBox();
            this.tbRecHeight = new System.Windows.Forms.TextBox();
            this.tbRecFPS = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbShadowTime = new System.Windows.Forms.TextBox();
            this.cbAudioMode = new System.Windows.Forms.ComboBox();
            this.cbVideoQuality = new System.Windows.Forms.ComboBox();
            this.cbIndicatorPos = new System.Windows.Forms.ComboBox();
            this.tbOutputLoc = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(461, 26);
            label1.TabIndex = 0;
            label1.Text = "Any settings changed here will change globally for ShadowPlay.\r\nI am NOT  respons" +
    "ible for any harm caused to your machine or games if this functions improperly.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 57);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 13);
            label2.TabIndex = 1;
            label2.Text = "Recording Width:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 84);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 13);
            label3.TabIndex = 2;
            label3.Text = "Recording Height:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRecWidth
            // 
            this.tbRecWidth.Location = new System.Drawing.Point(111, 54);
            this.tbRecWidth.Name = "tbRecWidth";
            this.tbRecWidth.Size = new System.Drawing.Size(100, 20);
            this.tbRecWidth.TabIndex = 3;
            // 
            // tbRecHeight
            // 
            this.tbRecHeight.Location = new System.Drawing.Point(111, 81);
            this.tbRecHeight.Name = "tbRecHeight";
            this.tbRecHeight.Size = new System.Drawing.Size(100, 20);
            this.tbRecHeight.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(23, 138);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 13);
            label4.TabIndex = 5;
            label4.Text = "Recording FPS:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRecFPS
            // 
            this.tbRecFPS.Location = new System.Drawing.Point(111, 135);
            this.tbRecFPS.Name = "tbRecFPS";
            this.tbRecFPS.Size = new System.Drawing.Size(100, 20);
            this.tbRecFPS.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(357, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(30, 111);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 13);
            label5.TabIndex = 8;
            label5.Text = "Shadow Time:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbShadowTime
            // 
            this.tbShadowTime.Location = new System.Drawing.Point(111, 108);
            this.tbShadowTime.Name = "tbShadowTime";
            this.tbShadowTime.Size = new System.Drawing.Size(100, 20);
            this.tbShadowTime.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(272, 57);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(67, 13);
            label6.TabIndex = 10;
            label6.Text = "Audio Mode:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(297, 84);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(42, 13);
            label7.TabIndex = 11;
            label7.Text = "Quality:";
            // 
            // cbAudioMode
            // 
            this.cbAudioMode.FormattingEnabled = true;
            this.cbAudioMode.Items.AddRange(new object[] {
            "AudioNone",
            "AudioGame"});
            this.cbAudioMode.Location = new System.Drawing.Point(345, 54);
            this.cbAudioMode.Name = "cbAudioMode";
            this.cbAudioMode.Size = new System.Drawing.Size(127, 21);
            this.cbAudioMode.TabIndex = 12;
            // 
            // cbVideoQuality
            // 
            this.cbVideoQuality.FormattingEnabled = true;
            this.cbVideoQuality.Items.AddRange(new object[] {
            "Average",
            "Good",
            "VeryGood"});
            this.cbVideoQuality.Location = new System.Drawing.Point(345, 81);
            this.cbVideoQuality.Name = "cbVideoQuality";
            this.cbVideoQuality.Size = new System.Drawing.Size(127, 21);
            this.cbVideoQuality.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(248, 111);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(91, 13);
            label8.TabIndex = 14;
            label8.Text = "Indicator Position:";
            // 
            // cbIndicatorPos
            // 
            this.cbIndicatorPos.FormattingEnabled = true;
            this.cbIndicatorPos.Items.AddRange(new object[] {
            "LeftTop",
            "RightTop",
            "LeftBottom",
            "RightBottom"});
            this.cbIndicatorPos.Location = new System.Drawing.Point(345, 108);
            this.cbIndicatorPos.Name = "cbIndicatorPos";
            this.cbIndicatorPos.Size = new System.Drawing.Size(127, 21);
            this.cbIndicatorPos.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(19, 165);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(86, 13);
            label9.TabIndex = 16;
            label9.Text = "Output Location:";
            // 
            // tbOutputLoc
            // 
            this.tbOutputLoc.Location = new System.Drawing.Point(111, 162);
            this.tbOutputLoc.Name = "tbOutputLoc";
            this.tbOutputLoc.Size = new System.Drawing.Size(100, 20);
            this.tbOutputLoc.TabIndex = 17;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(236, 167);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset To Defaults";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ShadowPlayHiddenSettingsMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 202);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbOutputLoc);
            this.Controls.Add(label9);
            this.Controls.Add(this.cbIndicatorPos);
            this.Controls.Add(label8);
            this.Controls.Add(this.cbVideoQuality);
            this.Controls.Add(this.cbAudioMode);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(this.tbShadowTime);
            this.Controls.Add(label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbRecFPS);
            this.Controls.Add(label4);
            this.Controls.Add(this.tbRecHeight);
            this.Controls.Add(this.tbRecWidth);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ShadowPlayHiddenSettingsMgr";
            this.ShowIcon = false;
            this.Text = "ShadowPlay Hidden Settings Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRecWidth;
        private System.Windows.Forms.TextBox tbRecHeight;
        private System.Windows.Forms.TextBox tbRecFPS;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbShadowTime;
        private System.Windows.Forms.ComboBox cbAudioMode;
        private System.Windows.Forms.ComboBox cbVideoQuality;
        private System.Windows.Forms.ComboBox cbIndicatorPos;
        private System.Windows.Forms.TextBox tbOutputLoc;
        private System.Windows.Forms.Button btnReset;

    }
}

