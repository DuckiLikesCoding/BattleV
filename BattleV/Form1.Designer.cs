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
            this.buttonBG.SuspendLayout();
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
            this.buttonBG.Location = new System.Drawing.Point(12, 529);
            this.buttonBG.Name = "buttonBG";
            this.buttonBG.Size = new System.Drawing.Size(1176, 137);
            this.buttonBG.TabIndex = 0;
            // 
            // playerAttack1
            // 
            this.playerAttack1.Location = new System.Drawing.Point(3, 3);
            this.playerAttack1.Name = "playerAttack1";
            this.playerAttack1.Size = new System.Drawing.Size(208, 62);
            this.playerAttack1.TabIndex = 0;
            this.playerAttack1.UseVisualStyleBackColor = true;
            this.playerAttack1.Click += new System.EventHandler(this.playerAttack1_Click);
            // 
            // playerAttack3
            // 
            this.playerAttack3.Location = new System.Drawing.Point(3, 71);
            this.playerAttack3.Name = "playerAttack3";
            this.playerAttack3.Size = new System.Drawing.Size(208, 62);
            this.playerAttack3.TabIndex = 1;
            this.playerAttack3.UseVisualStyleBackColor = true;
            this.playerAttack3.Click += new System.EventHandler(this.playerAttack3_Click);
            // 
            // playerAttack2
            // 
            this.playerAttack2.Location = new System.Drawing.Point(217, 3);
            this.playerAttack2.Name = "playerAttack2";
            this.playerAttack2.Size = new System.Drawing.Size(208, 62);
            this.playerAttack2.TabIndex = 2;
            this.playerAttack2.UseVisualStyleBackColor = true;
            this.playerAttack2.Click += new System.EventHandler(this.playerAttack2_Click);
            // 
            // playerAttack4
            // 
            this.playerAttack4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerAttack4.Location = new System.Drawing.Point(217, 71);
            this.playerAttack4.Name = "playerAttack4";
            this.playerAttack4.Size = new System.Drawing.Size(208, 62);
            this.playerAttack4.TabIndex = 3;
            this.playerAttack4.UseVisualStyleBackColor = true;
            this.playerAttack4.Click += new System.EventHandler(this.playerAttack4_Click);
            // 
            // BattleV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1200, 674);
            this.Controls.Add(this.buttonBG);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BattleV";
            this.Text = "BattleV";
            this.Load += new System.EventHandler(this.BattleV_Load);
            this.buttonBG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel buttonBG;
        private System.Windows.Forms.Button playerAttack1;
        private System.Windows.Forms.Button playerAttack3;
        private System.Windows.Forms.Button playerAttack2;
        private System.Windows.Forms.Button playerAttack4;
    }
}

