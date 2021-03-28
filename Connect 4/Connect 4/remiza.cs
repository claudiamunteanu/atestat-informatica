using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Connect_4
{
    public partial class remiza : Form
    {
        public remiza()
        {
            InitializeComponent();
        }

        private void close3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void replay3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void menu3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
