using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imba
{
    public partial class Form1 : Form
    {
        private string currentPlayer = "X";
        private bool gameActive = true;
        private Button[,] board;
        private int playerXScore = 0;
        private int playerOScore = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            board = new Button[3, 3]
            {
                {btnTopLeft,  btnTopMiddle , btnTopRight},
                {btnMiddleLeft , btnMiddleMiddle , btnMiddleRight } ,
                {btnBottomLeft , btnBottomMiddle, btnBottomRight }
            };
        }




        private void ButtonClick(object sender, EventArgs e)
        {
if (!gameActive) return;

            Button button = sender as Button;
            if (button != null && button.Text == "")
            {
                button.Text = currentPlayer;
                CheckForWinner();
                currentPlayer = (currentPlayer == "X") ? "0" : "X";
                lblWhoseGo.Text = $"Player{currentPlayer}'s Turn";
            }
        }

        private void CheckForWinner()
        {
            if (!gameActive) return;

            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0].Text == currentPlayer) &&
                    (board[i, 1].Text == currentPlayer) &&
                    (board[i, 2].Text == currentPlayer))
                {
                    EndGame($"Player {currentPlayer} Wins!");
                }

            }

            for (int i = 0; i < 3; i++)
            {

                if ((board[0, i].Text == currentPlayer) &&
                     (board[1, i].Text == currentPlayer) &&
                     (board[2, i].Text == currentPlayer))
                {
                    EndGame($"Player {currentPlayer} Wins!");
                }
            }

            if ((board[0, 0].Text == currentPlayer) &&
             (board[1, 1].Text == currentPlayer) &&
             (board[2, 2].Text == currentPlayer))
            {
                EndGame($"Player {currentPlayer} Wins!");
            }

            if ((board[0, 2].Text == currentPlayer) &&
            (board[1, 1].Text == currentPlayer) &&
            (board[2, 0].Text == currentPlayer))
            {
                EndGame($"Player {currentPlayer} Wins!");
            }

            bool draw = true;
            foreach (Button b in board)
            {
                if (b.Text == "")
                {
                    draw = false;
                }

            }
            if (draw)
            {
                EndGame($"It's a draw");
            }

        }

        private void EndGame(string result)
        {
            gameActive = false;
            if (result.Contains("X")) { playerXScore++; }
            if (result.Contains("0")) { playerOScore++; }

            lblStatus.Text = result + $"     Player X : {playerXScore}   || Player O:   {playerOScore}";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Button b in board)
            {
                b.Text = "";
            }
            gameActive  = true;
            currentPlayer = "X";
            lblWhoseGo.Text = "X to start!";
            btnBottomLeft.Focus();
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode){
                case Keys.D1:
                    btnTopLeft.PerformClick();
                    break;
                    case Keys.D2:
                    btnTopMiddle.PerformClick();
                    break;
                case Keys.D3:
                    btnTopRight.PerformClick();
                    break;
                case Keys.D4:
                    btnMiddleLeft.PerformClick();
                    break;
                case Keys.D5:
                    btnMiddleMiddle.PerformClick();
                    break;
                case Keys.D6:
                    btnMiddleRight.PerformClick();
                    break;
                    case Keys.D7:
                    btnBottomLeft.PerformClick();
                    break;
                    case Keys.D8:
                    btnBottomMiddle.PerformClick();
                    break;
                    case Keys.D9:
                    btnBottomLeft.PerformClick();
                    break;


            }
        }
    }
}
