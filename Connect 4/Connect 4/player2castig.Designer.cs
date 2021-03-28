namespace Connect_4
{
    partial class player2castig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(player2castig));
            this.titlu2 = new System.Windows.Forms.Label();
            this.replay2 = new System.Windows.Forms.Button();
            this.close2 = new System.Windows.Forms.Button();
            this.menu2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlu2
            // 
            this.titlu2.AutoSize = true;
            this.titlu2.BackColor = System.Drawing.Color.Transparent;
            this.titlu2.Font = new System.Drawing.Font("Pristina", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu2.ForeColor = System.Drawing.SystemColors.Control;
            this.titlu2.Location = new System.Drawing.Point(53, 78);
            this.titlu2.Name = "titlu2";
            this.titlu2.Size = new System.Drawing.Size(175, 42);
            this.titlu2.TabIndex = 0;
            this.titlu2.Text = "Player 2 won!";
            // 
            // replay2
            // 
            this.replay2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("replay2.BackgroundImage")));
            this.replay2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.replay2.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay2.ForeColor = System.Drawing.SystemColors.Control;
            this.replay2.Location = new System.Drawing.Point(43, 152);
            this.replay2.Name = "replay2";
            this.replay2.Size = new System.Drawing.Size(86, 41);
            this.replay2.TabIndex = 1;
            this.replay2.Text = "Replay";
            this.replay2.UseVisualStyleBackColor = true;
            this.replay2.Click += new System.EventHandler(this.replay2_Click);
            // 
            // close2
            // 
            this.close2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close2.BackgroundImage")));
            this.close2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close2.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close2.ForeColor = System.Drawing.SystemColors.Control;
            this.close2.Location = new System.Drawing.Point(157, 152);
            this.close2.Name = "close2";
            this.close2.Size = new System.Drawing.Size(86, 41);
            this.close2.TabIndex = 2;
            this.close2.Text = "Close";
            this.close2.UseVisualStyleBackColor = true;
            this.close2.Click += new System.EventHandler(this.close2_Click);
            // 
            // menu2
            // 
            this.menu2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu2.BackgroundImage")));
            this.menu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu2.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu2.ForeColor = System.Drawing.SystemColors.Control;
            this.menu2.Location = new System.Drawing.Point(88, 226);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(117, 41);
            this.menu2.TabIndex = 3;
            this.menu2.Text = "Main Menu";
            this.menu2.UseVisualStyleBackColor = true;
            this.menu2.Click += new System.EventHandler(this.menu2_Click);
            // 
            // player2castig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.menu2);
            this.Controls.Add(this.close2);
            this.Controls.Add(this.replay2);
            this.Controls.Add(this.titlu2);
            this.Name = "player2castig";
            this.Text = "player2castig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlu2;
        private System.Windows.Forms.Button replay2;
        private System.Windows.Forms.Button close2;
        private System.Windows.Forms.Button menu2;
    }
}