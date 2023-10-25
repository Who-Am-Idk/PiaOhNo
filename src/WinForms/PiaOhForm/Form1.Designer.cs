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
            this.whiteKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // whiteKeys
            // 
            resources.ApplyResources(this.whiteKeys, "whiteKeys");
            this.whiteKeys.BackColor = System.Drawing.Color.DimGray;
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
            this.bButton.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.bButton, "bButton");
            this.bButton.Name = "bButton";
            this.bButton.UseVisualStyleBackColor = false;
            // 
            // aButton
            // 
            this.aButton.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.aButton, "aButton");
            this.aButton.Name = "aButton";
            this.aButton.UseVisualStyleBackColor = false;
            // 
            // gButton
            // 
            this.gButton.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.gButton, "gButton");
            this.gButton.Name = "gButton";
            this.gButton.UseVisualStyleBackColor = false;
            // 
            // fButton
            // 
            this.fButton.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.fButton, "fButton");
            this.fButton.Name = "fButton";
            this.fButton.UseVisualStyleBackColor = false;
            // 
            // eButton
            // 
            this.eButton.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.eButton, "eButton");
            this.eButton.Name = "eButton";
            this.eButton.UseVisualStyleBackColor = false;
            // 
            // dButton
            // 
            this.dButton.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.dButton, "dButton");
            this.dButton.Name = "dButton";
            this.dButton.UseVisualStyleBackColor = false;
            // 
            // cButton
            // 
            this.cButton.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.cButton, "cButton");
            this.cButton.Name = "cButton";
            this.cButton.UseVisualStyleBackColor = false;
            // 
            // PiaOhNo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.whiteKeys);
            this.Name = "PiaOhNo";
            this.whiteKeys.ResumeLayout(false);
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
    }
}

