using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Game3x3 : Form
    {
        public Game3x3()
        {
            InitializeComponent();
            byte[,] pole = new byte[3, 3]; 
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            Pen p = new Pen(Color.Black);
            g.DrawRectangle(p, 0, 0, 50, 50);
            g.DrawRectangle(p, 50, 0, 50, 50);
            g.DrawRectangle(p, 0, 50, 50, 50);
            g.DrawRectangle(p, 50, 50, 50, 50);
            g.DrawRectangle(p, 0, 0, 50, 50);
        }

        public void Game3x3_Load(object sender, EventArgs e)
        {

        }
    }
}
