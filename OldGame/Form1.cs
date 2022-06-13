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

        public int clique = 0, somaX = 0, somaO = 0, vitX = 0, vitO = 0;

                       
        private void button1_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button1.Text = "O";
                somaO = somaO + 1;
            }
                

            else
            {
                button1.Text = "X";
                somaX = somaX + 2;
            }
                
            clique++;

            if (somaO == 21 || somaO == 27 || somaO == 33 || somaO == 9 || somaO == 45)
            {
                label1.Text = "O Jogador 1 (O) venceu!!! ";
                vitO++;
            } else if (somaX == 24 || somaX == 30 || somaX == 36 || somaX == 12 || somaX == 48)
            {
                label1.Text = "O Jogador 2 (X) venceu!!! ";
                vitX++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button2.Text = "O";
                somaO = somaO + 3;
            }


            else
            {
                button2.Text = "X";
                somaX = somaX + 4;
            }

            clique++;

            if (somaO == 21 || somaO == 27 || somaO == 33 || somaO == 9 || somaO == 45)
            {
                label1.Text = "O Jogador 1 (O) venceu!!! ";
                vitO++;
            }
            else if (somaX == 24 || somaX == 30 || somaX == 36 || somaX == 12 || somaX == 48)
            {
                label1.Text = "O Jogador 2 (X) venceu!!! ";
                vitX++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button3.Text = "O";
                somaO = somaO + 5;
            }


            else
            {
                button3.Text = "X";
                somaX = somaX + 6;
            }

            clique++;

            if (somaO == 21 || somaO == 27 || somaO == 33 || somaO == 9 || somaO == 45)
            {
                label1.Text = "O Jogador 1 (O) venceu!!! ";
                vitO++;
            }
            else if (somaX == 24 || somaX == 30 || somaX == 36 || somaX == 12 || somaX == 48)
            {
                label1.Text = "O Jogador 2 (X) venceu!!! ";
                vitX++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button4.Text = "O";
                somaO = somaO + 7;
            }


            else
            {
                button4.Text = "X";
                somaX = somaX + 8;
            }

            clique++;

            if (somaO == 21 || somaO == 27 || somaO == 33 || somaO == 9 || somaO == 45)
            {
                label1.Text = "O Jogador 1 (O) venceu!!! ";
                vitO++;
            }
            else if (somaX == 24 || somaX == 30 || somaX == 36 || somaX == 12 || somaX == 48)
            {
                label1.Text = "O Jogador 2 (X) venceu!!! ";
                vitX++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button5.Text = "O";
                somaO = somaO + 9;
            }


            else
            {
                button5.Text = "X";
                somaX = somaX + 10;
            }

            clique++;

            if (somaO == 21 || somaO == 27 || somaO == 33 || somaO == 9 || somaO == 45)
            {
                label1.Text = "O Jogador 1 (O) venceu!!! ";
                vitO++;
            }
            else if (somaX == 24 || somaX == 30 || somaX == 36 || somaX == 12 || somaX == 48)
            {
                label1.Text = "O Jogador 2 (X) venceu!!! ";
                vitX++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button6.Text = "O";
                somaO = somaO + 11;
            }


            else
            {
                button6.Text = "X";
                somaX = somaX + 12;
            }

            clique++;

            if (somaO == 21 || somaO == 27 || somaO == 33 || somaO == 9 || somaO == 45)
            {
                label1.Text = "O Jogador 1 (O) venceu!!! ";
                vitO++;
            }
            else if (somaX == 24 || somaX == 30 || somaX == 36 || somaX == 12 || somaX == 48)
            {
                label1.Text = "O Jogador 2 (X) venceu!!! ";
                vitX++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button7.Text = "O";
                somaO = somaO + 13;
            }


            else
            {
                button7.Text = "X";
                somaX = somaX + 14;
            }

            clique++;

            if (somaO == 21 || somaO == 27 || somaO == 33 || somaO == 9 || somaO == 45)
            {
                label1.Text = "O Jogador 1 (O) venceu!!! ";
                vitO++;
            }
            else if (somaX == 24 || somaX == 30 || somaX == 36 || somaX == 12 || somaX == 48)
            {
                label1.Text = "O Jogador 2 (X) venceu!!! ";
                vitX++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button8.Text = "O";
                somaO = somaO + 15;
            }


            else
            {
                button8.Text = "X";
                somaX = somaX + 16;
            }

            clique++;

            if (somaO == 21 || somaO == 27 || somaO == 33 || somaO == 9 || somaO == 45)
            {
                label1.Text = "O Jogador 1 (O) venceu!!! ";
                vitO++;
            }
            else if (somaX == 24 || somaX == 30 || somaX == 36 || somaX == 12 || somaX == 48)
            {
                label1.Text = "O Jogador 2 (X) venceu!!! ";
                vitX++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (clique % 2 == 0)
            {
                button9.Text = "O";
                somaO = somaO + 17;
            }


            else
            {
                button9.Text = "X";
                somaX = somaX + 18;
            }

            clique++;

            if (somaO == 21 || somaO == 27 || somaO == 33 || somaO == 9 || somaO == 45)
            {
                label1.Text = "O Jogador 1 (O) venceu!!! ";
                vitO++;
            }
            else if (somaX == 24 || somaX == 30 || somaX == 36 || somaX == 12 || somaX == 48)
            {
                label1.Text = "O Jogador 2 (X) venceu!!! ";
                vitX++;
            }
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

        
    }
}
