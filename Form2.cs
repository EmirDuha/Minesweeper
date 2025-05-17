
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace FORMSDENEME2
{
    public partial class Form2 : Form
    {

        //DECLARING GAME CLASS 
        Game game;

        //CONSTRUCTOR
        public Form2(string fName, int fMineNum, int fGridSize)
        {
            InitializeComponent();

            game = new Game(fName, fMineNum, fGridSize);
            game.CreateGrid(this, game.gridSize, game.gridSize);
            game.PlaceMines();
        }

        //FORMLOAD FUNCTION
        private void Form2_Load(object sender, EventArgs e)
        {
            labelName.Text = game.name.Replace(" ", "\n");

            labelFlagCounter.Text = game.flagCount.ToString();

            game.timeCount = 0;
            timerCounter.Interval = 1000;
            timerCounter.Start();
        }

        //TIMECOUNTER FUNCTION
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            game.timeCount++;
            labelTimeCounter.Text = game.timeCount.ToString();
        }

        // MOUSEDOWN FUNCTION
        public void Cells_MouseDown(object? sender, MouseEventArgs e)
        {

            if (game.gameOver)
                return;

            else
            {

                // Null Control
                if (sender is Button clickedCell) 
                {
                    //Mine Detect Variables
                    int clickedRow = -1;
                    int clickedCol = -1;

                    for (int i = 0; i < game.gridSize; i++)
                    {
                        for (int j = 0; j < game.gridSize; j++)
                        {
                            if (game.Cells[i, j] == clickedCell)
                            {
                                clickedRow = i;
                                clickedCol = j;
                                break;
                            }
                        }
                    }
                    if (clickedRow == -1 || clickedCol == -1)
                        return;

                    //Left Click
                    if (e.Button == MouseButtons.Left)
                    {
                        if (!game.youWon)
                        {
                            if (clickedCell.Tag == "X" && clickedCell.BackgroundImage != game.flag)
                            {
                                clickedCell.BackColor = Color.Red;

                                //Showing All Mines 
                                for (int i = 0; i < game.gridSize; i++)
                                {
                                    for (int j = 0; j < game.gridSize; j++)
                                    {
                                        if (game.Cells[i, j].Tag == "X")
                                            game.Cells[i, j].BackgroundImage = game.mine;
                                        game.Cells[i, j].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }

                                game.gameOver = true;
                                labelGameStatement.Visible = true;
                                timerCounter.Stop();

                            }

                            else if (clickedCell.BackgroundImage == game.flag)
                            {
                                clickedCell.BackgroundImage = clickedCell.BackgroundImage;
                            }

                            else
                            {
                                game.RevealNeighbors(clickedRow, clickedCol);
                                clickedCell.BackColor = Color.LightSkyBlue;
                            }
                        }
                        if (!game.youWon)
                        {
                            game.moveCount++;
                            labelMoveCounter.Text = game.moveCount.ToString();
                        }
                        game.YouWon();
                        if (game.youWon)
                        {
                            labelScore.Text = "Your Score: " + game.score.ToString();
                            labelGameStatement.Visible = true;
                            labelGameStatement.Text = "You won!";
                            labelGameStatement.Location = new Point(20, 767);
                            timerCounter.Stop();
                        }
                    }

                    //Right Click
                    else if (e.Button == MouseButtons.Right)
                    {
                        if (!game.youWon)
                        {
                            if (clickedCell.BackColor != Color.LightSkyBlue && clickedCell.BackgroundImage != game.flag && clickedCell.BackgroundImage != game.mine && game.flagCount != 0)
                            {
                                clickedCell.BackgroundImage = game.flag;
                                clickedCell.BackgroundImageLayout = ImageLayout.Zoom;
                                if (game.flagCount == 0)
                                {
                                    game.flagCount = 0;
                                }
                                else
                                {
                                    game.flagCount--;
                                    labelFlagCounter.Text = game.flagCount.ToString();
                                }

                            }
                            else if (clickedCell.BackgroundImage == game.flag)
                            {
                                clickedCell.BackgroundImage = null;
                                game.flagCount++;
                                labelFlagCounter.Text = game.flagCount.ToString();
                            }

                            game.moveCount++;
                            labelMoveCounter.Text = game.moveCount.ToString();
                        }
                    }
                }
            }
        }

        //BACK BUTTON CLICK FUNCTION
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
        }

        //RESTART BUTTON CLICK FUNCTION
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            timerCounter.Interval = 1000;
            timerCounter.Start();
            game.RestartGame();
            labelGameStatement.Text = "Game Over!";
            labelGameStatement.Location = new Point(0, 767);
            labelGameStatement.Visible = false;
            labelScore.Text = "";
            labelFlagCounter.Text = game.flagCount.ToString();
            labelTimeCounter.Text = game.timeCount.ToString();
            labelMoveCounter.Text = game.moveCount.ToString();
        }

        //SCOREBOARD BUTTON CLICK FUNCTION
        private void buttonScoreboard_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form3)
                {
                    return;
                }
            }

            Form3 form3 = new Form3(game.name, game.score);
            form3.Show();
        }
    }
}


