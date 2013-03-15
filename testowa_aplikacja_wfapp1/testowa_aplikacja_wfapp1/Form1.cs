using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testowa_aplikacja_wfapp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Button[,] pola;

        private void utworzPola(int x, int y)
        {
            pola = new Button[x, y];

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    pola[i, j] = new Button();
                    pola[i, j].Text = "";
                    pola[i, j].Width = 20;
                    pola[i, j].Height = 20;
                    pola[i, j].Left = 5 + i * pola[i, j].Width;
                    pola[i, j].Top = 5 + j * pola[i, j].Height;
                    pola[i, j].Parent = this;
                   // pola[i, j].Click += new EventHandler(Form1_Click);
                   // pola[i, j].Tag = new int[] { i, j };
                }
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utworzPola(10,11);
        }

        private void gRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            // a tutaj ramzes ;)
            // plkuto
            //cost acostam 
            //dodaje kolejne zmiany w tym pliku i proboje przez konsole to ogarnac
               //raz jeszcze lalalalal

            
        }
    }
}
