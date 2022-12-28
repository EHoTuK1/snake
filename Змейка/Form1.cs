using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Змейка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    g.DrawString(Convert.ToString(a[i,j]), Font, Brush, i*25, j*30);
                }
            }
        }
        public static int[,] a = new int[6, 6];
        public Random random = new Random();
        public static Brush Brush = new SolidBrush(Color.Black);
        public static Font Font = new Font("Calibri",30, FontStyle.Bold | FontStyle.Regular);
        public static int x1 = new Random().Next(0,7);
        public static int y1 = new Random().Next(0,7);
        public static int x = x1;
        public static int y = y1;



        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = 0;
                }
            }
            a[x1, y1] = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (left==true)
            {

            }
            Invalidate();
        }
        public static bool left = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                left = true;
            }
            else
            {
                left = false;
            }
        }
    }
}
