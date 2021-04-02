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
            
        }

        public void Game3x3_Load(object sender, EventArgs e)
        {

        }



        //Игра
        bool turn = false;

        bool isclicked = false;

        private void button_Click(object sender, EventArgs e)
        {
            Label b = (Label)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;

            b.Enabled = false;
            CheckWinner();

        }

        private void CheckWinner()
        {
            bool IsWinner = false;

            //Горизонтальные комбинации
            if((LeftTop.Text == MidTop.Text)&&(MidTop.Text == RightTop.Text)&&(!LeftTop.Enabled))
            {
                IsWinner = true;
            }
            if ((LeftCenter.Text == MidCenter.Text) && (MidCenter.Text == RightCenter.Text) && (!LeftCenter.Enabled))
            {
                IsWinner = true;
            }
            if ((LeftBottom.Text == MidBottom.Text) && (MidBottom.Text == RightBottom.Text) && (!LeftBottom.Enabled))
            {
                IsWinner = true;
            }

            //Вертикальные комбинации
            if ((LeftTop.Text == LeftCenter.Text) && (LeftCenter.Text == LeftBottom.Text) && (!LeftTop.Enabled))
            {
                IsWinner = true;
            }
            if ((MidTop.Text == MidCenter.Text) && (MidCenter.Text == MidBottom.Text) && (!MidTop.Enabled))
            {
                IsWinner = true;
            }
            if ((RightTop.Text == RightCenter.Text) && (RightCenter.Text == RightBottom.Text) && (!RightTop.Enabled))
            {
                IsWinner = true;
            }

            //Диагональные комбинации
            if ((LeftTop.Text == MidCenter.Text) && (MidCenter.Text == RightBottom.Text) && (!LeftTop.Enabled))
            {
                IsWinner = true;
            }
            if ((LeftBottom.Text == MidCenter.Text) && (MidCenter.Text == RightTop.Text) && (!RightTop.Enabled))
            {
                IsWinner = true;
            }


            //Вывод победителя
            if (IsWinner)
            {
                string winner;
                if (!turn) { winner = "X"; }
                else { winner = "O"; }
                label1.Text = "Победитель - " + winner;

            }
        }

    }
}
