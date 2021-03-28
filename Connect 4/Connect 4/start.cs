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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new joc().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new computer().ShowDialog();
            this.Close();
        }

        private void help_Click(object sender, EventArgs e)
        {
            new Help().ShowDialog();
        }
    }
}
