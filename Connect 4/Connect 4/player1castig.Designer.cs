namespace Connect_4
{
    partial class player1castig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(player1castig));
            this.close1 = new System.Windows.Forms.Button();
            this.titlu1 = new System.Windows.Forms.Label();
            this.replay1 = new System.Windows.Forms.Button();
            this.menu1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close1
            // 
            this.close1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close1.BackgroundImage")));
            this.close1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close1.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close1.ForeColor = System.Drawing.SystemColors.Control;
            this.close1.Location = new System.Drawing.Point(157, 152);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(86, 40);
            this.close1.TabIndex = 2;
            this.close1.Text = "Close";
            this.close1.UseVisualStyleBackColor = true;
            this.close1.Click += new System.EventHandler(this.close1_Click);
            // 
            // titlu1
            // 
            this.titlu1.AutoSize = true;
            this.titlu1.BackColor = System.Drawing.Color.Transparent;
            this.titlu1.Font = new System.Drawing.Font("Pristina", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu1.ForeColor = System.Drawing.SystemColors.Control;
            this.titlu1.Location = new System.Drawing.Point(58, 81);
            this.titlu1.Name = "titlu1";
            this.titlu1.Size = new System.Drawing.Size(169, 42);
            this.titlu1.TabIndex = 3;
            this.titlu1.Text = "Player 1 won!";
            // 
            // replay1
            // 
            this.replay1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.replay1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("replay1.BackgroundImage")));
            this.replay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.replay1.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay1.ForeColor = System.Drawing.SystemColors.Control;
            this.replay1.Location = new System.Drawing.Point(36, 152);
            this.replay1.Name = "replay1";
            this.replay1.Size = new System.Drawing.Size(91, 40);
            this.replay1.TabIndex = 4;
            this.replay1.Text = "Replay";
            this.replay1.UseVisualStyleBackColor = false;
            this.replay1.Click += new System.EventHandler(this.replay1_Click);
            // 
            // menu1
            // 
            this.menu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu1.BackgroundImage")));
            this.menu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu1.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu1.ForeColor = System.Drawing.SystemColors.Control;
            this.menu1.Location = new System.Drawing.Point(83, 232);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(115, 42);
            this.menu1.TabIndex = 5;
            this.menu1.Text = "Main Menu";
            this.menu1.UseVisualStyleBackColor = true;
            this.menu1.Click += new System.EventHandler(this.menu1_Click);
            // 
            // player1castig2P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.replay1);
            this.Controls.Add(this.titlu1);
            this.Controls.Add(this.close1);
            this.Name = "player1castig2P";
            this.Text = "player1castig";
            this.Load += new System.EventHandler(this.player1castig2P_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close1;
        private System.Windows.Forms.Label titlu1;
        private System.Windows.Forms.Button replay1;
        private System.Windows.Forms.Button menu1;

    }
}