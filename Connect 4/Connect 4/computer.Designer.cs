namespace Connect_4
{
    partial class computer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(computer));
            this.placa2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // placa2
            // 
            this.placa2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("placa2.BackgroundImage")));
            this.placa2.Location = new System.Drawing.Point(4, 0);
            this.placa2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.placa2.Name = "placa2";
            this.placa2.Size = new System.Drawing.Size(1478, 945);
            this.placa2.TabIndex = 0;
            this.placa2.Paint += new System.Windows.Forms.PaintEventHandler(this.placa2_Paint);
            this.placa2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.placa2_MouseClick);
            // 
            // computer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.placa2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "computer";
            this.Text = "computer";
            this.Load += new System.EventHandler(this.computer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel placa2;
    }
}