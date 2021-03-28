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
    public partial class computer : Form
    {
        int[,] m = new int[6, 7];
        public computer()
        {
            InitializeComponent();
            for (int i = 0; i <= 5; i++)
                for (int j = 0; j <= 6; j++)
                    m[i, j] = 0;
            this.Size = new Size(750, 670);
        }
        Graphics g;
        int v = 1;

        private void placa2_Paint(object sender, PaintEventArgs e)
        {
            //design-ul mesei de joc
            e.Graphics.FillRectangle(Brushes.Blue, 10, 10, 700, 600);
            g = placa2.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    e.Graphics.FillEllipse(Brushes.White, 20 + j * 100, 20 + i * 100, 80, 80);
                    g.DrawEllipse(p, 19 + j * 100, 19 + i * 100, 82, 82);
                }
            }
        }

        //conditii de castig

        private void verifcastig(int v, int[,] m)
        {
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
                                    new computer().ShowDialog();
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
                                        new computer().ShowDialog();
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
                                    new computer().ShowDialog();
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
                                        new computer().ShowDialog();
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
                                    new computer().ShowDialog();
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
                                        new computer().ShowDialog();
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
                                    new computer().ShowDialog();
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
                                        new computer().ShowDialog();
                                        this.Close();
                                    }
                                }
            }
            else //remiza
                if (v == 43)
                {
                    remiza r = new remiza();
                    if (r.ShowDialog() == DialogResult.OK)
                    {
                        this.Hide();
                        new computer().ShowDialog();
                        this.Close();
                    }
                }
        }

        private void oprire_castig(ref int v, ref int castig, int[,] m)
        {
            //orizontala
            for(int i=5; i>=0; i--)
                for (int j = 0; j < 4; j++)
                {
                    //dupa
                    if (m[i, j] == m[i, j + 1] && m[i, j] == m[i, j + 2] && m[i, j] == 1)
                        if ((i == 5 || (i < 5 && m[i + 1, j + 3] != 0)) && m[i, j + 3] == 0)
                        {
                            g.FillEllipse(Brushes.Yellow, 20 + (j + 3) * 100, 20 + i * 100, 80, 80);
                            m[i, j + 3] = 2;
                            castig = 1;
                            v++;
                            return;
                        }

                    //intre col 2 si 4
                    if (m[i, j] == m[i, j + 1] && m[i, j] == m[i, j + 3] && m[i, j] == 1)
                        if ((i == 5 || (i < 5 && m[i + 1, j + 2] != 0)) && m[i, j + 2] == 0)
                        {
                             g.FillEllipse(Brushes.Yellow, 20 + (j + 2) * 100, 20 + i * 100, 80, 80);
                             m[i, j + 2] = 2;
                             castig = 1;
                             v++;
                             return;
                        }

                    //intre col 1 si 3
                    if (m[i, j] == m[i, j + 2] && m[i, j] == m[i, j + 3] && m[i, j] == 1)
                        if ((i == 5 || (i < 5 && m[i + 1, j + 1] != 0)) && m[i, j + 1] == 0)
                        {
                             g.FillEllipse(Brushes.Yellow, 20 + (j + 3) * 100, 20 + i * 100, 80, 80);
                             m[i, j + 1] = 2;
                             castig = 1;
                             v++;
                             return;
                        }
                }
            
            //orizontala inainte
            for(int i=5; i>=0; i--)
                for (int j = 6; j > 2; j--)
                    if (m[i, j] == m[i, j - 1] && m[i, j] == m[i, j - 2] && m[i, j] == 1)
                        if ((i == 5 || (i < 5 && m[i + 1, j - 3] != 0)) && m[i, j - 3] == 0)
                        {
                            g.FillEllipse(Brushes.Yellow, 20 + (j - 3) * 100, 20 + i * 100, 80, 80);
                            m[i, j - 3] = 2;
                            castig = 1;
                            v++;
                            return;
                        } 

            //verticala
            for(int j=0; j<=6; j++)
                for(int i=5; i>2; i--)
                    if (m[i, j] == m[i - 1, j] && m[i, j] == m[i - 2, j] && m[i, j] == 1 && m[i - 3, j] == 0)
                    {
                        g.FillEllipse(Brushes.Yellow, 20 + j * 100, 20 + (i-3) * 100, 80, 80);
                        m[i-3,j] = 2;
                        castig = 1;
                        v++;
                        return;
                    }

            //oblic crescator 
            for(int i=5; i>2; i--)
                for (int j = 0; j < 4; j++)
                {
                    //dupa
                    if (m[i, j] == m[i-1, j + 1] && m[i, j] == m[i-2, j + 2] && m[i, j] == 1)
                        if (m[i -2, j+3] != 0 && m[i-3, j + 3] == 0)
                        {
                            g.FillEllipse(Brushes.Yellow, 20 + (j + 3) * 100, 20 + (i-3) * 100, 80, 80);
                            m[i-3, j + 3] = 2;
                            castig = 1;
                            v++;
                            return;
                        }

                    //intre col 2 si 4
                    if (m[i, j] == m[i - 1, j + 1] && m[i, j] == m[i - 3, j + 3] && m[i, j] == 1)
                        if (m[i - 1, j + 2] != 0 && m[i - 2, j + 2] == 0)
                        {
                            g.FillEllipse(Brushes.Yellow, 20 + (j + 2) * 100, 20 + (i - 2) * 100, 80, 80);
                            m[i - 2, j + 2] = 2;
                            castig = 1;
                            v++;
                            return;
                        }

                    //intre col 1 si 3
                    if (m[i, j] == m[i - 2, j + 2] && m[i, j] == m[i - 3, j + 3] && m[i, j] == 1)
                        if (m[i, j + 1] != 0 && m[i - 1, j + 1] == 0)
                        {
                            g.FillEllipse(Brushes.Yellow, 20 + (j + 1) * 100, 20 + (i - 1) * 100, 80, 80);
                            m[i - 1, j + 1] = 2;
                            castig = 1;
                            v++;
                            return;
                        }
                }
            
            //oblic crescator inceput
            for(int i=0; i<3; i++)
                for(int j=6; j>2; j--)
                    if (m[i, j] == m[i +1, j -1 ] && m[i, j] == m[i +2, j -2] && m[i, j] == 1)
                        if (((i+3) == 5 || ((i+3) < 5 && m[i + 4, j - 3] != 0)) && m[i+3, j - 3] == 0)
                        {
                            g.FillEllipse(Brushes.Yellow, 20 + (j - 3) * 100, 20 + (i +3) * 100, 80, 80);
                            m[i + 3, j - 3] = 2;
                            castig = 1;
                            v++;
                            return;
                        }

            //oblic descrescator
            for(int i=0; i<3; i++)
                for (int j = 0; j < 4; j++)
                {
                    //dupa
                    if (m[i, j] == m[i + 1, j + 1] && m[i, j] == m[i + 2, j + 2] && m[i, j] == 1)
                        if (((i + 3) == 5 || ((i + 3) < 5 && m[i + 4, j + 3] != 0)) && m[i + 3, j + 3] == 0)
                        {
                            g.FillEllipse(Brushes.Yellow, 20 + (j + 3) * 100, 20 + (i + 3) * 100, 80, 80);
                            m[i + 3, j + 3] = 2;
                            castig = 1;
                            v++;
                            return;
                        }
                    
                    //intre col 2 si 4
                    if (m[i, j] == m[i + 1, j + 1] && m[i, j] == m[i + 3, j + 3] && m[i, j] == 1)
                        if (m[i+3, j + 2] != 0 && m[i + 2, j + 2] == 0)
                        {
                            g.FillEllipse(Brushes.Yellow, 20 + (j + 2) * 100, 20 + (i + 2) * 100, 80, 80);
                            m[i + 2, j + 2] = 2;
                            castig = 1;
                            v++;
                            return;
                        }

                    //intre col 1 si 3
                    if (m[i, j] == m[i + 2, j + 2] && m[i, j] == m[i + 3, j + 3] && m[i, j] == 1)
                        if (m[i + 2, j + 1] != 0 && m[i + 1, j + 1] == 0)
                        {
                            g.FillEllipse(Brushes.Yellow, 20 + (j + 1) * 100, 20 + (i + 1) * 100, 80, 80);
                            m[i + 1, j + 1] = 2;
                            castig = 1;
                            v++;
                            return;
                        }
                }

            //oblic descrescator inceput
            for(int i=5; i>2; i--)
                for(int j=6; j>2; j--)
                    if (m[i, j] == m[i - 1, j - 1] && m[i, j] == m[i - 2, j - 2] && m[i, j] == 1)
                        if (m[i - 2, j - 3] != 0 && m[i - 3, j - 3] == 0)
                        {
                            g.FillEllipse(Brushes.Yellow, 20 + (j - 3) * 100, 20 + (i - 3) * 100, 80, 80);
                            m[i - 3, j - 3] = 2;
                            castig = 1;
                            v++;
                            return;
                        }

        }
        private void placa2_MouseClick(object sender, MouseEventArgs e)
        {
            g = placa2.CreateGraphics();
            while(v%2==1)
                {
                    int a = e.X / 100;
                    int k = 1;
                    while ((m[6 - k, a] == 1 || m[6 - k, a] == 2) && k < 6)
                          k++;
                    g.FillEllipse(Brushes.Red, 20 + a * 100, 20 + (6 - k) * 100, 80, 80);
                    m[6 - k, a] = 1;
                    v++;
                    verifcastig(v, m);
                }
            while (v%2==0)
            {
                int castig = 0;
                oprire_castig(ref v, ref castig, m);

                if(v<=5 || castig==0)
                {
                    Random random = new Random();
                    int b = random.Next(0, 6);
                    int k = 1,ok=0;
                    //luare coordonata a unei coloane nepline
                    int[] ap = new int[7];
                    do
                    {
                        while (m[6 - k, b] != 0 && k < 6)
                            k++;
                        ap[b]++;
                        if (m[6 - k, b] != 0)
                            while (ap[b]!=0)
                                b = random.Next(0, 6);
                        else
                            ok = 1;
                    } while (ok == 0);
                    g.FillEllipse(Brushes.Yellow, 20 + b * 100, 20 + (6 - k) * 100, 80, 80);
                    m[6 - k, b] = 2;
                    v++;
                }
                verifcastig(v, m);
            }
          
        }

        private void computer_Load(object sender, EventArgs e)
        {

        }
    }
}
