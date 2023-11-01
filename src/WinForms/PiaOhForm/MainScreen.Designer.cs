namespace PiaOhForm
{
    partial class PiaOhNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PiaOhNo));
            this.whiteKeys = new System.Windows.Forms.TableLayoutPanel();
            this.bButton = new System.Windows.Forms.Button();
            this.aButton = new System.Windows.Forms.Button();
            this.gButton = new System.Windows.Forms.Button();
            this.fButton = new System.Windows.Forms.Button();
            this.eButton = new System.Windows.Forms.Button();
            this.dButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.songTextBox = new System.Windows.Forms.TextBox();
            this.songTable = new System.Windows.Forms.TableLayoutPanel();
            this.playPauseBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.stopSongBtn = new System.Windows.Forms.Button();
            this.fileBtn = new System.Windows.Forms.Button();
            this.whiteKeys.SuspendLayout();
            this.songTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // whiteKeys
            // 
            resources.ApplyResources(this.whiteKeys, "whiteKeys");
            this.whiteKeys.BackColor = System.Drawing.Color.Transparent;
            this.whiteKeys.Controls.Add(this.bButton, 6, 0);
            this.whiteKeys.Controls.Add(this.aButton, 5, 0);
            this.whiteKeys.Controls.Add(this.gButton, 4, 0);
            this.whiteKeys.Controls.Add(this.fButton, 3, 0);
            this.whiteKeys.Controls.Add(this.eButton, 2, 0);
            this.whiteKeys.Controls.Add(this.dButton, 1, 0);
            this.whiteKeys.Controls.Add(this.cButton, 0, 0);
            this.whiteKeys.Name = "whiteKeys";
            this.whiteKeys.Paint += new System.Windows.Forms.PaintEventHandler(this.whiteKeysTable);
            // 
            // bButton
            // 
            resources.ApplyResources(this.bButton, "bButton");
            this.bButton.BackColor = System.Drawing.Color.White;
            this.bButton.Name = "bButton";
            this.bButton.UseVisualStyleBackColor = false;
            // 
            // aButton
            // 
            resources.ApplyResources(this.aButton, "aButton");
            this.aButton.BackColor = System.Drawing.Color.White;
            this.aButton.Name = "aButton";
            this.aButton.UseVisualStyleBackColor = false;
            // 
            // gButton
            // 
            resources.ApplyResources(this.gButton, "gButton");
            this.gButton.BackColor = System.Drawing.Color.White;
            this.gButton.Name = "gButton";
            this.gButton.UseVisualStyleBackColor = false;
            // 
            // fButton
            // 
            resources.ApplyResources(this.fButton, "fButton");
            this.fButton.BackColor = System.Drawing.Color.White;
            this.fButton.Name = "fButton";
            this.fButton.UseVisualStyleBackColor = false;
            // 
            // eButton
            // 
            resources.ApplyResources(this.eButton, "eButton");
            this.eButton.BackColor = System.Drawing.Color.White;
            this.eButton.Name = "eButton";
            this.eButton.UseVisualStyleBackColor = false;
            // 
            // dButton
            // 
            resources.ApplyResources(this.dButton, "dButton");
            this.dButton.BackColor = System.Drawing.Color.White;
            this.dButton.Name = "dButton";
            this.dButton.UseVisualStyleBackColor = false;
            // 
            // cButton
            // 
            resources.ApplyResources(this.cButton, "cButton");
            this.cButton.BackColor = System.Drawing.Color.White;
            this.cButton.Name = "cButton";
            this.cButton.UseVisualStyleBackColor = false;
            // 
            // songTextBox
            // 
            this.songTextBox.AcceptsReturn = true;
            resources.ApplyResources(this.songTextBox, "songTextBox");
            this.songTextBox.Name = "songTextBox";
            this.songTable.SetRowSpan(this.songTextBox, 4);
            // 
            // songTable
            // 
            resources.ApplyResources(this.songTable, "songTable");
            this.songTable.Controls.Add(this.playPauseBtn, 1, 0);
            this.songTable.Controls.Add(this.settingsBtn, 1, 3);
            this.songTable.Controls.Add(this.stopSongBtn, 1, 1);
            this.songTable.Controls.Add(this.fileBtn, 1, 2);
            this.songTable.Controls.Add(this.songTextBox, 0, 0);
            this.songTable.Name = "songTable";
            this.songTable.Paint += new System.Windows.Forms.PaintEventHandler(this.songTable_Paint);
            // 
            // playPauseBtn
            // 
            resources.ApplyResources(this.playPauseBtn, "playPauseBtn");
            this.playPauseBtn.BackgroundImage = global::PiaOhForm.Properties.Resources.playPauseIcon;
            this.playPauseBtn.Name = "playPauseBtn";
            this.playPauseBtn.UseVisualStyleBackColor = true;
            // 
            // settingsBtn
            // 
            resources.ApplyResources(this.settingsBtn, "settingsBtn");
            this.settingsBtn.BackgroundImage = global::PiaOhForm.Properties.Resources.cogwheelIcon;
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.UseVisualStyleBackColor = true;
            // 
            // stopSongBtn
            // 
            resources.ApplyResources(this.stopSongBtn, "stopSongBtn");
            this.stopSongBtn.BackgroundImage = global::PiaOhForm.Properties.Resources.stopSongIcon;
            this.stopSongBtn.Name = "stopSongBtn";
            this.stopSongBtn.UseVisualStyleBackColor = true;
            // 
            // fileBtn
            // 
            resources.ApplyResources(this.fileBtn, "fileBtn");
            this.fileBtn.BackgroundImage = global::PiaOhForm.Properties.Resources.saveIcon;
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.FileBtn_Click);
            // 
            // PiaOhNo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.songTable);
            this.Controls.Add(this.whiteKeys);
            this.Name = "PiaOhNo";
            this.Resize += new System.EventHandler(this.PiaOhNo_Resize);
            this.whiteKeys.ResumeLayout(false);
            this.whiteKeys.PerformLayout();
            this.songTable.ResumeLayout(false);
            this.songTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel whiteKeys;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button gButton;
        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.TextBox songTextBox;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.TableLayoutPanel songTable;
        private System.Windows.Forms.Button playPauseBtn;
        private System.Windows.Forms.Button stopSongBtn;
        private System.Windows.Forms.Button fileBtn;
    }
}

