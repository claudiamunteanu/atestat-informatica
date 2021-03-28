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
    public partial class player2castig : Form
    {
        public player2castig()
        {
            InitializeComponent();
        }

        private void close2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void replay2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
