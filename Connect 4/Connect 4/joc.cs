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
    public partial class joc : Form
    {
        int[,] m = new int[6, 7];
        public joc()
        {
            InitializeComponent();
            for (int i = 0; i <= 5; i++)
                for (int j = 0; j <= 6; j++)
                    m[i,j] = 0;
            this.Size = new Size(750, 650);
            
        }

        private void joc_Load(object sender, EventArgs e)
        {

        }

        Graphics g;
        int v = 1;

        private void placa_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, 10, 10, 700, 600);
            g = placa.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            for(int i=0; i<6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    e.Graphics.FillEllipse(Brushes.White, 20 + j* 100, 20 + i* 100, 80, 80);
                    g.DrawEllipse(p, 19 + j * 100, 19 + i * 100, 82, 82);
                }
            }
        }

        private void placa_MouseClick(object sender, MouseEventArgs e)
        {
            g = placa.CreateGraphics();
            int a = e.X/100;
            int k=1;
            while ((m[6 - k, a] == 1 || m[6-k,a]==2 )&& k < 6)
                k++;
            if (v % 2 == 1)
            {
                g.FillEllipse(Brushes.Red, 20 + a * 100, 20 + (6 - k) * 100, 80, 80);
                m[6 - k, a] = 1;
            }
            else
            {
                g.FillEllipse(Brushes.Yellow, 20 + a * 100, 20 + (6 - k) * 100, 80, 80);
                m[6 - k, a] = 2;
            }
            if (v >= 7 && v <= 42)
            {
                //orizontala
                for (int i = 5; i >= 0; i--)
                    for (int j = 0; j < 4; j++)
                        if (m[i, j] == m[i, j + 1] && m[i, j] == m[i, j + 2] && m[i, j] == m[i, j + 3])
                            if (m[i, j] == 1)
                            {
                                player1castig f1 = new player1castig();
                                if (f1.ShowDialog() == DialogResult.OK)
                                {
                                    this.Hide();
                                    new joc().ShowDialog();
                                    this.Close();
                                }
                            }
                            else
                                if (m[i, j] == 2)
                                {
                                    player2castig f2 = new player2castig();
                                    if (f2.ShowDialog() == DialogResult.OK)
                                    {
                                        this.Hide();
                                        new joc().ShowDialog();
                                        this.Close();
                                    }
                                }
                //verticala
                for (int j = 0; j < 7; j++)
                    for (int i = 0; i < 3; i++)
                        if (m[i, j] == m[i + 1, j] && m[i, j] == m[i + 2, j] && m[i, j] == m[i + 3, j])
                            if (m[i, j] == 1)
                            {
                                player1castig f1 = new player1castig();
                                if (f1.ShowDialog() == DialogResult.OK)
                                {
                                    this.Hide();
                                    new joc().ShowDialog();
                                    this.Close();
                                }
                            }
                            else
                                if (m[i, j] == 2)
                                {
                                    player2castig f2 = new player2castig();
                                    if (f2.ShowDialog() == DialogResult.OK)
                                    {
                                        this.Hide();
                                        new joc().ShowDialog();
                                        this.Close();
                                    }
                                }
                //oblic crescator
                for (int i = 3; i < 6; i++)
                    for (int j = 0; j < 4; j++)
                        if (m[i, j] == m[i - 1, j + 1] && m[i, j] == m[i - 2, j + 2] && m[i, j] == m[i - 3, j + 3])
                            if (m[i, j] == 1)
                            {
                                player1castig f1 = new player1castig();
                                if (f1.ShowDialog() == DialogResult.OK)
                                {
                                    this.Hide();
                                    new joc().ShowDialog();
                                    this.Close();
                                }
                            }
                            else
                                if (m[i, j] == 2)
                                {
                                    player2castig f2 = new player2castig();
                                    if (f2.ShowDialog() == DialogResult.OK)
                                    {
                                        this.Hide();
                                        new joc().ShowDialog();
                                        this.Close();
                                    }
                                }

                //oblic descrescator
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 4; j++)
                        if (m[i, j] == m[i + 1, j + 1] && m[i, j] == m[i + 2, j + 2] && m[i, j] == m[i + 3, j + 3])
                            if (m[i, j] == 1)
                            {
                                player1castig f1 = new player1castig();
                                if (f1.ShowDialog() == DialogResult.OK)
                                {
                                    this.Hide();
                                    new joc().ShowDialog();
                                    this.Close();
                                }
                            }
                            else
                                if (m[i, j] == 2)
                                {
                                    player2castig f2 = new player2castig();
                                    if (f2.ShowDialog() == DialogResult.OK)
                                    {
                                        this.Hide();
                                        new joc().ShowDialog();
                                        this.Close();
                                    }
                                }
            }
            v++;
            if (k == 6 && v == 43)
            {
                remiza r = new remiza();
                if (r.ShowDialog() == DialogResult.OK)
                {
                    this.Hide();
                    new joc().ShowDialog();
                    this.Close();
                }
            }
        }


        private void placa_MouseMove(object sender, MouseEventArgs e)
        {

        }
        

    }
}
