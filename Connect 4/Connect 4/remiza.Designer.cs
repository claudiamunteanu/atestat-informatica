namespace Connect_4
{
    partial class remiza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(remiza));
            this.titlu3 = new System.Windows.Forms.Label();
            this.replay3 = new System.Windows.Forms.Button();
            this.close3 = new System.Windows.Forms.Button();
            this.menu3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlu3
            // 
            this.titlu3.AutoSize = true;
            this.titlu3.BackColor = System.Drawing.Color.Transparent;
            this.titlu3.Font = new System.Drawing.Font("Pristina", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu3.ForeColor = System.Drawing.SystemColors.Control;
            this.titlu3.Location = new System.Drawing.Point(83, 80);
            this.titlu3.Name = "titlu3";
            this.titlu3.Size = new System.Drawing.Size(119, 42);
            this.titlu3.TabIndex = 0;
            this.titlu3.Text = "It\'s a tie!";
            // 
            // replay3
            // 
            this.replay3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("replay3.BackgroundImage")));
            this.replay3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.replay3.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay3.ForeColor = System.Drawing.SystemColors.Control;
            this.replay3.Location = new System.Drawing.Point(43, 152);
            this.replay3.Name = "replay3";
            this.replay3.Size = new System.Drawing.Size(86, 41);
            this.replay3.TabIndex = 1;
            this.replay3.Text = "Replay";
            this.replay3.UseVisualStyleBackColor = true;
            this.replay3.Click += new System.EventHandler(this.replay3_Click);
            // 
            // close3
            // 
            this.close3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close3.BackgroundImage")));
            this.close3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close3.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close3.ForeColor = System.Drawing.SystemColors.Control;
            this.close3.Location = new System.Drawing.Point(157, 152);
            this.close3.Name = "close3";
            this.close3.Size = new System.Drawing.Size(86, 41);
            this.close3.TabIndex = 2;
            this.close3.Text = "Close";
            this.close3.UseVisualStyleBackColor = true;
            this.close3.Click += new System.EventHandler(this.close3_Click);
            // 
            // menu3
            // 
            this.menu3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu3.BackgroundImage")));
            this.menu3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu3.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu3.ForeColor = System.Drawing.SystemColors.Control;
            this.menu3.Location = new System.Drawing.Point(90, 227);
            this.menu3.Name = "menu3";
            this.menu3.Size = new System.Drawing.Size(112, 34);
            this.menu3.TabIndex = 3;
            this.menu3.Text = "Main Menu";
            this.menu3.UseVisualStyleBackColor = true;
            this.menu3.Click += new System.EventHandler(this.menu3_Click);
            // 
            // remiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.menu3);
            this.Controls.Add(this.close3);
            this.Controls.Add(this.replay3);
            this.Controls.Add(this.titlu3);
            this.Name = "remiza";
            this.Text = "remiza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlu3;
        private System.Windows.Forms.Button replay3;
        private System.Windows.Forms.Button close3;
        private System.Windows.Forms.Button menu3;
    }
}