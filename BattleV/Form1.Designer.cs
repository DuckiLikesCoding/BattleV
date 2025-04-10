namespace BattleV
{
    partial class BattleV
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
            this.buttonBG = new System.Windows.Forms.FlowLayoutPanel();
            this.playerAttack1 = new System.Windows.Forms.Button();
            this.playerAttack3 = new System.Windows.Forms.Button();
            this.playerAttack2 = new System.Windows.Forms.Button();
            this.playerAttack4 = new System.Windows.Forms.Button();
            this.playerHealth = new System.Windows.Forms.ProgressBar();
            this.aiHealth = new System.Windows.Forms.ProgressBar();
            this.aiLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerPercentage = new System.Windows.Forms.Label();
            this.aiPercentage = new System.Windows.Forms.Label();
            this.playerImage = new System.Windows.Forms.PictureBox();
            this.aiImage = new System.Windows.Forms.PictureBox();
            this.buttonBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBG
            // 
            this.buttonBG.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBG.Controls.Add(this.playerAttack1);
            this.buttonBG.Controls.Add(this.playerAttack3);
            this.buttonBG.Controls.Add(this.playerAttack2);
            this.buttonBG.Controls.Add(this.playerAttack4);
            this.buttonBG.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.buttonBG.Location = new System.Drawing.Point(8, 344);
            this.buttonBG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBG.Name = "buttonBG";
            this.buttonBG.Size = new System.Drawing.Size(784, 89);
            this.buttonBG.TabIndex = 0;
            // 
            // playerAttack1
            // 
            this.playerAttack1.Location = new System.Drawing.Point(2, 2);
            this.playerAttack1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerAttack1.Name = "playerAttack1";
            this.playerAttack1.Size = new System.Drawing.Size(139, 40);
            this.playerAttack1.TabIndex = 0;
            this.playerAttack1.UseVisualStyleBackColor = true;
            this.playerAttack1.Click += new System.EventHandler(this.playerAttack1_Click);
            // 
            // playerAttack3
            // 
            this.playerAttack3.Location = new System.Drawing.Point(2, 46);
            this.playerAttack3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerAttack3.Name = "playerAttack3";
            this.playerAttack3.Size = new System.Drawing.Size(139, 40);
            this.playerAttack3.TabIndex = 1;
            this.playerAttack3.UseVisualStyleBackColor = true;
            this.playerAttack3.Click += new System.EventHandler(this.playerAttack3_Click);
            // 
            // playerAttack2
            // 
            this.playerAttack2.Location = new System.Drawing.Point(145, 2);
            this.playerAttack2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerAttack2.Name = "playerAttack2";
            this.playerAttack2.Size = new System.Drawing.Size(139, 40);
            this.playerAttack2.TabIndex = 2;
            this.playerAttack2.UseVisualStyleBackColor = true;
            this.playerAttack2.Click += new System.EventHandler(this.playerAttack2_Click);
            // 
            // playerAttack4
            // 
            this.playerAttack4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerAttack4.Location = new System.Drawing.Point(145, 46);
            this.playerAttack4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerAttack4.Name = "playerAttack4";
            this.playerAttack4.Size = new System.Drawing.Size(139, 40);
            this.playerAttack4.TabIndex = 3;
            this.playerAttack4.UseVisualStyleBackColor = true;
            this.playerAttack4.Click += new System.EventHandler(this.playerAttack4_Click);
            // 
            // playerHealth
            // 
            this.playerHealth.BackColor = System.Drawing.Color.Firebrick;
            this.playerHealth.ForeColor = System.Drawing.Color.Lime;
            this.playerHealth.Location = new System.Drawing.Point(12, 314);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.Size = new System.Drawing.Size(280, 25);
            this.playerHealth.TabIndex = 1;
            this.playerHealth.Value = 30;
            // 
            // aiHealth
            // 
            this.aiHealth.BackColor = System.Drawing.Color.Firebrick;
            this.aiHealth.ForeColor = System.Drawing.Color.Lime;
            this.aiHealth.Location = new System.Drawing.Point(512, 42);
            this.aiHealth.Name = "aiHealth";
            this.aiHealth.Size = new System.Drawing.Size(280, 25);
            this.aiHealth.TabIndex = 2;
            this.aiHealth.Value = 30;
            // 
            // aiLabel
            // 
            this.aiLabel.AutoSize = true;
            this.aiLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiLabel.Location = new System.Drawing.Point(512, 14);
            this.aiLabel.Name = "aiLabel";
            this.aiLabel.Size = new System.Drawing.Size(99, 31);
            this.aiLabel.TabIndex = 3;
            this.aiLabel.Text = "Dragon";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(12, 286);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(99, 31);
            this.playerLabel.TabIndex = 4;
            this.playerLabel.Text = "Dragon";
            // 
            // playerPercentage
            // 
            this.playerPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerPercentage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playerPercentage.Location = new System.Drawing.Point(228, 286);
            this.playerPercentage.Name = "playerPercentage";
            this.playerPercentage.Size = new System.Drawing.Size(64, 25);
            this.playerPercentage.TabIndex = 5;
            this.playerPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // aiPercentage
            // 
            this.aiPercentage.BackColor = System.Drawing.Color.Transparent;
            this.aiPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiPercentage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aiPercentage.Location = new System.Drawing.Point(728, 14);
            this.aiPercentage.Name = "aiPercentage";
            this.aiPercentage.Size = new System.Drawing.Size(64, 25);
            this.aiPercentage.TabIndex = 6;
            this.aiPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // playerImage
            // 
            this.playerImage.Location = new System.Drawing.Point(92, 83);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(200, 200);
            this.playerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImage.TabIndex = 7;
            this.playerImage.TabStop = false;
            // 
            // aiImage
            // 
            this.aiImage.Location = new System.Drawing.Point(512, 83);
            this.aiImage.Name = "aiImage";
            this.aiImage.Size = new System.Drawing.Size(200, 200);
            this.aiImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aiImage.TabIndex = 8;
            this.aiImage.TabStop = false;
            // 
            // BattleV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.aiImage);
            this.Controls.Add(this.playerImage);
            this.Controls.Add(this.aiPercentage);
            this.Controls.Add(this.playerPercentage);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.aiLabel);
            this.Controls.Add(this.aiHealth);
            this.Controls.Add(this.playerHealth);
            this.Controls.Add(this.buttonBG);
            this.Name = "BattleV";
            this.Text = "BattleV";
            this.Load += new System.EventHandler(this.BattleV_Load);
            this.buttonBG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel buttonBG;
        private System.Windows.Forms.Button playerAttack1;
        private System.Windows.Forms.Button playerAttack3;
        private System.Windows.Forms.Button playerAttack2;
        private System.Windows.Forms.Button playerAttack4;
        private System.Windows.Forms.ProgressBar playerHealth;
        private System.Windows.Forms.ProgressBar aiHealth;
        private System.Windows.Forms.Label aiLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label playerPercentage;
        private System.Windows.Forms.Label aiPercentage;
        private System.Windows.Forms.PictureBox playerImage;
        private System.Windows.Forms.PictureBox aiImage;
    }
}

