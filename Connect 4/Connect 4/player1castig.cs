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
    public partial class player1castig : Form
    {
        public player1castig()
        {
            InitializeComponent();
        }

        private void close1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void replay1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
        }

        private void player1castig2P_Load(object sender, EventArgs e)
        {

        }

        private void menu1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
