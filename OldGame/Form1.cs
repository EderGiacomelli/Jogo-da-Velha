using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int clique = 0, vitX = 0, vitO = 0;
        public string b1, b2, b3, b4, b5, b6, b7, b8, b9;


        private void button1_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button1.Text = "O";
                b1 = "O";
            }
            else
            {
                button1.Text = "X";
                b1 = "X";
            }  
            clique++;

            Win();
            campeao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button2.Text = "O";
                b2 = "O";
            }
            else
            {
                button2.Text = "X";
                b2 = "X";
            }
            clique++;
            Win();
            campeao();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button3.Text = "O";
                b3 = "O";
            }
            else
            {
                button3.Text = "X";
                b3 = "X";
            }
            clique++;
            Win();
            campeao();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button4.Text = "O";
                b4 = "O";
            }
            else
            {
                button4.Text = "X";
                b4 = "X";
            }
            clique++;
            Win();
            campeao();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button5.Text = "O";
                b5 = "O";
            }
            else
            {
                button5.Text = "X";
                b5 = "X";
            }
            clique++;
            Win();
            campeao();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button6.Text = "O";
                b6 = "O";
            }
            else
            {
                button6.Text = "X";
                b6 = "X";
            }
            clique++;
            Win();
            campeao();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button7.Text = "O";
                b7 = "O";
            }
            else
            {
                button7.Text = "X";
                b7 = "X";
            }
            clique++;
            Win();
            campeao();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button8.Text = "O";
                b8 = "O";
            }
            else
            {
                button8.Text = "X";
                b8 = "X";
            }
            clique++;
            Win();
            campeao();
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(200, 200, 200);
            button2.BackColor = Color.FromArgb(200, 200, 200);
            button3.BackColor = Color.FromArgb(200, 200, 200);
            button4.BackColor = Color.FromArgb(200, 200, 200);
            button5.BackColor = Color.FromArgb(200, 200, 200);
            button6.BackColor = Color.FromArgb(200, 200, 200);
            button7.BackColor = Color.FromArgb(200, 200, 200);
            button8.BackColor = Color.FromArgb(200, 200, 200);
            button9.BackColor = Color.FromArgb(200, 200, 200);

            vitO = 0;
            vitX = 0;
            clique = 0;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            lb_ptO.Text = vitO.ToString();
            lb_ptX.Text = vitX.ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button9.Text = "O";
                b9 = "O";
            }
            else
            {
                button9.Text = "X";
                b9 = "X";
            }
            clique++;
            Win();
            campeao();
           }

        

        private void btn_recomecar_Click(object sender, EventArgs e)
        {
            clique = 0;

            lb_ptO.Text = vitO.ToString();
            lb_ptX.Text = vitX.ToString();

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        public void Win()
        {
            int comb1, comb2, comb3, comb4, comb5, comb6, comb7, comb8;
            int comb11, comb12, comb13, comb14, comb15, comb16, comb17, comb18;

            comb1 = 0;
            comb2 = 0;
            comb3 = 0;
            comb4 = 0;
            comb5 = 0;
            comb6 = 0;
            comb7 = 0;
            comb8 = 0;
            comb11 = 0;
            comb12 = 0;
            comb13 = 0;
            comb14 = 0;
            comb15 = 0;
            comb16 = 0;
            comb17 = 0;
            comb18 = 0;

            if (b1 == "X" && b2 == "X" && b3 == "X")
                comb1++;
            else if (b1 == "X" && b4 == "X" && b7 == "X")
                comb2++;
            else if (b1 == "X" && b5 == "X" && b9 == "X")
                comb3++;
            else if (b2 == "X" && b5 == "X" && b8 == "X")
                comb4++;
            else if (b3 == "X" && b5 == "X" && b7 == "X")
                comb5++;
            else if (b3 == "X" && b6 == "X" && b9 == "X")
                comb6++;
            else if (b4 == "X" && b5 == "X" && b6 == "X")
                comb7++;
            else if (b7 == "X" && b8 == "X" && b9 == "X")
                comb8++;
            else if (b1 == "O" && b2 == "O" && b3 == "O")
                comb11++;
            else if (b1 == "O" && b4 == "O" && b7 == "O")
                comb12++;
            else if (b1 == "O" && b5 == "O" && b9 == "O")
                comb13++;
            else if (b2 == "O" && b5 == "O" && b8 == "O")
                comb14++;
            else if (b3 == "O" && b5 == "O" && b7 == "O")
                comb15++;
            else if (b3 == "O" && b6 == "O" && b9 == "O")
                comb16++;
            else if (b4 == "O" && b5 == "O" && b6 == "O")
                comb17++;
            else if (b7 == "O" && b8 == "O" && b9 == "O")
                comb18++;

            if (comb1 == 1 || comb2 ==1 || comb3 ==1 || comb4 ==1
                ||comb5 ==1 || comb6 == 1 || comb7 == 1 || comb8 == 1)
            {
                MessageBox.Show ("O Jogador 2 (X) venceu!!! ");
                vitX++;
                b1 = ""; b2 = ""; b3 = ""; b4 = ""; b5 = ""; b6 = ""; b7 = ""; b8 = ""; b9 = "";
                comb1 = 0; comb2 = 0; comb3 = 0; comb4 = 0; comb5 = 0; comb6 = 0; comb7 = 0; comb8 = 0;
            }
            else if (comb11 == 1 || comb12 == 1 || comb13 == 1 || comb14 == 1
                || comb15 == 1 || comb16 == 1 || comb17 == 1 || comb18 == 1)
            {
                MessageBox.Show ("O Jogador 1 (O) venceu!!! ");
                vitO++;
                b1 = ""; b2 = ""; b3 = ""; b4 = ""; b5 = ""; b6 = ""; b7 = ""; b8 = ""; b9 = "";
                comb11 = 0; comb12 = 0; comb13 = 0; comb14 = 0; comb15 = 0; comb16 = 0; comb17 = 0; comb18 = 0;
            }

        }

        public void campeao()
        {
            if (vitO == 5)
            {
                MessageBox.Show("O Jogador 1 (O) é o grande vencedor!!!!");
                vitO = 0;
                vitX = 0;
                button1.BackColor = Color.FromArgb(50, 200, 50);
                button2.BackColor = Color.FromArgb(50, 200, 50);
                button3.BackColor = Color.FromArgb(50, 200, 50);
                button4.BackColor = Color.FromArgb(50, 200, 50);
                button5.BackColor = Color.FromArgb(200, 200, 200);
                button6.BackColor = Color.FromArgb(50, 200, 50);
                button7.BackColor = Color.FromArgb(50, 200, 50);
                button8.BackColor = Color.FromArgb(50, 200, 50);
                button9.BackColor = Color.FromArgb(50, 200, 50);

                btn_recomecar.Enabled = false;
            } else if (vitX == 5)
            {
                MessageBox.Show("O Jogador 2 (X) é o grande vencedor!!!!");
                vitX = 0;
                vitO = 0;
                button1.BackColor = Color.FromArgb(200, 50, 50);
                button2.BackColor = Color.FromArgb(200, 200, 200);
                button3.BackColor = Color.FromArgb(200, 50, 50);
                button4.BackColor = Color.FromArgb(200, 200, 200);
                button5.BackColor = Color.FromArgb(200, 50, 50);
                button6.BackColor = Color.FromArgb(200, 200, 200);
                button7.BackColor = Color.FromArgb(200, 50, 50);
                button8.BackColor = Color.FromArgb(200, 200, 200);
                button9.BackColor = Color.FromArgb(200, 50, 50);

                btn_recomecar.Enabled = false;
            }

            lb_ptO.Text = vitO.ToString();
            lb_ptX.Text = vitX.ToString();
        }
        
    }
}
