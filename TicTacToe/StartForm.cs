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
    public partial class StartForm : Form
    {
        
        public StartForm()
        {
            InitializeComponent();
        }

        private void Start3x3_Click(object sender, EventArgs e)
        {
            Game3x3 g = new Game3x3();
            g.Show();
            this.Hide();
            
        }

        private void Start4x4_Click(object sender, EventArgs e)
        {
            using (Game4x4 g = new Game4x4())
            {
                g.Show();
            }
            this.Hide();
        }
    }
}
