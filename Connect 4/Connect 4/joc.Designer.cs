namespace Connect_4
{
    partial class joc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(joc));
            this.placa = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // placa
            // 
            this.placa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.placa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("placa.BackgroundImage")));
            this.placa.Location = new System.Drawing.Point(1, 0);
            this.placa.Margin = new System.Windows.Forms.Padding(2);
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(985, 614);
            this.placa.TabIndex = 0;
            this.placa.Paint += new System.Windows.Forms.PaintEventHandler(this.placa_Paint);
            this.placa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.placa_MouseClick);
            this.placa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.placa_MouseMove);
            // 
            // joc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.placa);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "joc";
            this.Text = "joc";
            this.Load += new System.EventHandler(this.joc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel placa;
    }
}

