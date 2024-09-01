
namespace MotionStager
{
    partial class MotionForm
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
            this.SerialDevices = new System.Windows.Forms.ComboBox();
            this.SerialConnect = new System.Windows.Forms.Button();
            this.Messages = new System.Windows.Forms.ListBox();
            this.Yup = new System.Windows.Forms.Button();
            this.Ydown = new System.Windows.Forms.Button();
            this.Xdown = new System.Windows.Forms.Button();
            this.Xup = new System.Windows.Forms.Button();
            this.StopMotion = new System.Windows.Forms.Button();
            this.Zup = new System.Windows.Forms.Button();
            this.Zdown = new System.Windows.Forms.Button();
            this.Set0 = new System.Windows.Forms.Button();
            this.HOME = new System.Windows.Forms.Button();
            this.AddFrame = new System.Windows.Forms.Button();
            this.AdvanceFrame = new System.Windows.Forms.Button();
            this.PrevFrame = new System.Windows.Forms.Button();
            this.adFrame = new System.Windows.Forms.Button();
            this.DeleteCurrentFrame = new System.Windows.Forms.Button();
            this.FeedSeconds = new System.Windows.Forms.TextBox();
            this.Play = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.XCurent = new System.Windows.Forms.TextBox();
            this.YCurrent = new System.Windows.Forms.TextBox();
            this.ZCurent = new System.Windows.Forms.TextBox();
            this.MoveRate = new System.Windows.Forms.ComboBox();
            this.FrameName = new System.Windows.Forms.TextBox();
            this.DeleteSelectedFeame = new System.Windows.Forms.Button();
            this.FrameList = new System.Windows.Forms.ListBox();
            this.MoveToSelectedFrame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SerialDevices
            // 
            this.SerialDevices.FormattingEnabled = true;
            this.SerialDevices.Location = new System.Drawing.Point(27, 45);
            this.SerialDevices.Name = "SerialDevices";
            this.SerialDevices.Size = new System.Drawing.Size(180, 21);
            this.SerialDevices.TabIndex = 0;
            // 
            // SerialConnect
            // 
            this.SerialConnect.Location = new System.Drawing.Point(213, 45);
            this.SerialConnect.Name = "SerialConnect";
            this.SerialConnect.Size = new System.Drawing.Size(116, 23);
            this.SerialConnect.TabIndex = 1;
            this.SerialConnect.Text = "Connect";
            this.SerialConnect.UseVisualStyleBackColor = true;
            this.SerialConnect.Click += new System.EventHandler(this.SerialConnect_Click);
            // 
            // Messages
            // 
            this.Messages.FormattingEnabled = true;
            this.Messages.Location = new System.Drawing.Point(27, 380);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(905, 95);
            this.Messages.TabIndex = 2;
            // 
            // Yup
            // 
            this.Yup.Location = new System.Drawing.Point(760, 45);
            this.Yup.Name = "Yup";
            this.Yup.Size = new System.Drawing.Size(45, 50);
            this.Yup.TabIndex = 3;
            this.Yup.Text = "Y+";
            this.Yup.UseVisualStyleBackColor = true;
            this.Yup.Click += new System.EventHandler(this.Yup_Click);
            // 
            // Ydown
            // 
            this.Ydown.Location = new System.Drawing.Point(760, 157);
            this.Ydown.Name = "Ydown";
            this.Ydown.Size = new System.Drawing.Size(45, 50);
            this.Ydown.TabIndex = 4;
            this.Ydown.Text = "Y-";
            this.Ydown.UseVisualStyleBackColor = true;
            this.Ydown.Click += new System.EventHandler(this.Ydown_Click);
            // 
            // Xdown
            // 
            this.Xdown.Location = new System.Drawing.Point(709, 101);
            this.Xdown.Name = "Xdown";
            this.Xdown.Size = new System.Drawing.Size(45, 50);
            this.Xdown.TabIndex = 5;
            this.Xdown.Text = "<=";
            this.Xdown.UseVisualStyleBackColor = true;
            this.Xdown.Click += new System.EventHandler(this.Xdown_Click);
            // 
            // Xup
            // 
            this.Xup.Location = new System.Drawing.Point(811, 101);
            this.Xup.Name = "Xup";
            this.Xup.Size = new System.Drawing.Size(45, 50);
            this.Xup.TabIndex = 6;
            this.Xup.Text = "=>";
            this.Xup.UseVisualStyleBackColor = true;
            this.Xup.Click += new System.EventHandler(this.Xup_Click);
            // 
            // StopMotion
            // 
            this.StopMotion.Location = new System.Drawing.Point(760, 101);
            this.StopMotion.Name = "StopMotion";
            this.StopMotion.Size = new System.Drawing.Size(45, 50);
            this.StopMotion.TabIndex = 7;
            this.StopMotion.Text = "Stop";
            this.StopMotion.UseVisualStyleBackColor = true;
            this.StopMotion.Click += new System.EventHandler(this.StopMotion_Click);
            // 
            // Zup
            // 
            this.Zup.Location = new System.Drawing.Point(887, 45);
            this.Zup.Name = "Zup";
            this.Zup.Size = new System.Drawing.Size(45, 50);
            this.Zup.TabIndex = 8;
            this.Zup.Text = "Z+";
            this.Zup.UseVisualStyleBackColor = true;
            this.Zup.Click += new System.EventHandler(this.Zup_Click);
            // 
            // Zdown
            // 
            this.Zdown.Location = new System.Drawing.Point(887, 157);
            this.Zdown.Name = "Zdown";
            this.Zdown.Size = new System.Drawing.Size(45, 50);
            this.Zdown.TabIndex = 9;
            this.Zdown.Text = "Z-";
            this.Zdown.UseVisualStyleBackColor = true;
            this.Zdown.Click += new System.EventHandler(this.Zdown_Click);
            // 
            // Set0
            // 
            this.Set0.Location = new System.Drawing.Point(362, 31);
            this.Set0.Name = "Set0";
            this.Set0.Size = new System.Drawing.Size(252, 50);
            this.Set0.TabIndex = 10;
            this.Set0.Text = "Set 0";
            this.Set0.UseVisualStyleBackColor = true;
            this.Set0.Click += new System.EventHandler(this.Set0_Click);
            // 
            // HOME
            // 
            this.HOME.Location = new System.Drawing.Point(362, 101);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(252, 50);
            this.HOME.TabIndex = 11;
            this.HOME.Text = "Go Home";
            this.HOME.UseVisualStyleBackColor = true;
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // AddFrame
            // 
            this.AddFrame.Location = new System.Drawing.Point(362, 170);
            this.AddFrame.Name = "AddFrame";
            this.AddFrame.Size = new System.Drawing.Size(252, 50);
            this.AddFrame.TabIndex = 12;
            this.AddFrame.Text = "Add to Time Frame";
            this.AddFrame.UseVisualStyleBackColor = true;
            // 
            // AdvanceFrame
            // 
            this.AdvanceFrame.Location = new System.Drawing.Point(517, 239);
            this.AdvanceFrame.Name = "AdvanceFrame";
            this.AdvanceFrame.Size = new System.Drawing.Size(97, 50);
            this.AdvanceFrame.TabIndex = 13;
            this.AdvanceFrame.Text = "Next Frame";
            this.AdvanceFrame.UseVisualStyleBackColor = true;
            this.AdvanceFrame.Click += new System.EventHandler(this.AdvanceFrame_Click);
            // 
            // PrevFrame
            // 
            this.PrevFrame.Location = new System.Drawing.Point(362, 239);
            this.PrevFrame.Name = "PrevFrame";
            this.PrevFrame.Size = new System.Drawing.Size(97, 50);
            this.PrevFrame.TabIndex = 14;
            this.PrevFrame.Text = "Previous Frame";
            this.PrevFrame.UseVisualStyleBackColor = true;
            this.PrevFrame.Click += new System.EventHandler(this.PrevFrame_Click);
            // 
            // adFrame
            // 
            this.adFrame.Location = new System.Drawing.Point(213, 86);
            this.adFrame.Name = "adFrame";
            this.adFrame.Size = new System.Drawing.Size(116, 46);
            this.adFrame.TabIndex = 15;
            this.adFrame.Text = "Add Frame";
            this.adFrame.UseVisualStyleBackColor = true;
            this.adFrame.Click += new System.EventHandler(this.adFrame_Click);
            // 
            // DeleteCurrentFrame
            // 
            this.DeleteCurrentFrame.Location = new System.Drawing.Point(213, 250);
            this.DeleteCurrentFrame.Name = "DeleteCurrentFrame";
            this.DeleteCurrentFrame.Size = new System.Drawing.Size(116, 37);
            this.DeleteCurrentFrame.TabIndex = 16;
            this.DeleteCurrentFrame.Text = "Delete Current Frame";
            this.DeleteCurrentFrame.UseVisualStyleBackColor = true;
            this.DeleteCurrentFrame.Visible = false;
            this.DeleteCurrentFrame.Click += new System.EventHandler(this.DeleteCurrentFrame_Click);
            // 
            // FeedSeconds
            // 
            this.FeedSeconds.Location = new System.Drawing.Point(27, 112);
            this.FeedSeconds.Name = "FeedSeconds";
            this.FeedSeconds.Size = new System.Drawing.Size(180, 20);
            this.FeedSeconds.TabIndex = 17;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(362, 295);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(97, 50);
            this.Play.TabIndex = 18;
            this.Play.Text = "Play Sequence";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(517, 295);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(97, 50);
            this.Stop.TabIndex = 19;
            this.Stop.Text = "Stop Sequence";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // XCurent
            // 
            this.XCurent.Location = new System.Drawing.Point(656, 324);
            this.XCurent.Name = "XCurent";
            this.XCurent.Size = new System.Drawing.Size(45, 20);
            this.XCurent.TabIndex = 20;
            // 
            // YCurrent
            // 
            this.YCurrent.Location = new System.Drawing.Point(709, 324);
            this.YCurrent.Name = "YCurrent";
            this.YCurrent.Size = new System.Drawing.Size(45, 20);
            this.YCurrent.TabIndex = 21;
            // 
            // ZCurent
            // 
            this.ZCurent.Location = new System.Drawing.Point(760, 324);
            this.ZCurent.Name = "ZCurent";
            this.ZCurent.Size = new System.Drawing.Size(45, 20);
            this.ZCurent.TabIndex = 22;
            // 
            // MoveRate
            // 
            this.MoveRate.FormattingEnabled = true;
            this.MoveRate.Items.AddRange(new object[] {
            "1",
            ".01",
            ".001",
            "5",
            "10",
            "100"});
            this.MoveRate.Location = new System.Drawing.Point(811, 323);
            this.MoveRate.Name = "MoveRate";
            this.MoveRate.Size = new System.Drawing.Size(121, 21);
            this.MoveRate.TabIndex = 23;
            // 
            // FrameName
            // 
            this.FrameName.Location = new System.Drawing.Point(27, 86);
            this.FrameName.Name = "FrameName";
            this.FrameName.Size = new System.Drawing.Size(180, 20);
            this.FrameName.TabIndex = 24;
            // 
            // DeleteSelectedFeame
            // 
            this.DeleteSelectedFeame.Location = new System.Drawing.Point(213, 164);
            this.DeleteSelectedFeame.Name = "DeleteSelectedFeame";
            this.DeleteSelectedFeame.Size = new System.Drawing.Size(116, 37);
            this.DeleteSelectedFeame.TabIndex = 25;
            this.DeleteSelectedFeame.Text = "Delete Selected Frame";
            this.DeleteSelectedFeame.UseVisualStyleBackColor = true;
            this.DeleteSelectedFeame.Click += new System.EventHandler(this.DeleteSelectedFeame_Click);
            // 
            // FrameList
            // 
            this.FrameList.FormattingEnabled = true;
            this.FrameList.Location = new System.Drawing.Point(27, 164);
            this.FrameList.Name = "FrameList";
            this.FrameList.Size = new System.Drawing.Size(180, 199);
            this.FrameList.TabIndex = 26;
            // 
            // MoveToSelectedFrame
            // 
            this.MoveToSelectedFrame.Location = new System.Drawing.Point(213, 207);
            this.MoveToSelectedFrame.Name = "MoveToSelectedFrame";
            this.MoveToSelectedFrame.Size = new System.Drawing.Size(116, 37);
            this.MoveToSelectedFrame.TabIndex = 27;
            this.MoveToSelectedFrame.Text = "Move to Selected Frame";
            this.MoveToSelectedFrame.UseVisualStyleBackColor = true;
            this.MoveToSelectedFrame.Click += new System.EventHandler(this.MoveToSelectedFrame_Click);
            // 
            // MotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 487);
            this.Controls.Add(this.MoveToSelectedFrame);
            this.Controls.Add(this.FrameList);
            this.Controls.Add(this.DeleteSelectedFeame);
            this.Controls.Add(this.FrameName);
            this.Controls.Add(this.MoveRate);
            this.Controls.Add(this.ZCurent);
            this.Controls.Add(this.YCurrent);
            this.Controls.Add(this.XCurent);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.FeedSeconds);
            this.Controls.Add(this.DeleteCurrentFrame);
            this.Controls.Add(this.adFrame);
            this.Controls.Add(this.PrevFrame);
            this.Controls.Add(this.AdvanceFrame);
            this.Controls.Add(this.AddFrame);
            this.Controls.Add(this.HOME);
            this.Controls.Add(this.Set0);
            this.Controls.Add(this.Zdown);
            this.Controls.Add(this.Zup);
            this.Controls.Add(this.StopMotion);
            this.Controls.Add(this.Xup);
            this.Controls.Add(this.Xdown);
            this.Controls.Add(this.Ydown);
            this.Controls.Add(this.Yup);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.SerialConnect);
            this.Controls.Add(this.SerialDevices);
            this.Name = "MotionForm";
            this.Text = "MotionMaker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MotionForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SerialDevices;
        private System.Windows.Forms.Button SerialConnect;
        private System.Windows.Forms.ListBox Messages;
        private System.Windows.Forms.Button Yup;
        private System.Windows.Forms.Button Ydown;
        private System.Windows.Forms.Button Xdown;
        private System.Windows.Forms.Button Xup;
        private System.Windows.Forms.Button StopMotion;
        private System.Windows.Forms.Button Zup;
        private System.Windows.Forms.Button Zdown;
        private System.Windows.Forms.Button Set0;
        private System.Windows.Forms.Button HOME;
        private System.Windows.Forms.Button AddFrame;
        private System.Windows.Forms.Button AdvanceFrame;
        private System.Windows.Forms.Button PrevFrame;
        private System.Windows.Forms.Button adFrame;
        private System.Windows.Forms.Button DeleteCurrentFrame;
        private System.Windows.Forms.TextBox FeedSeconds;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox XCurent;
        private System.Windows.Forms.TextBox YCurrent;
        private System.Windows.Forms.TextBox ZCurent;
        private System.Windows.Forms.ComboBox MoveRate;
        private System.Windows.Forms.TextBox FrameName;
        private System.Windows.Forms.Button DeleteSelectedFeame;
        private System.Windows.Forms.ListBox FrameList;
        private System.Windows.Forms.Button MoveToSelectedFrame;
    }
}

