using System;
using System.Drawing;
using System.Windows.Forms;
using static FORMSDENEME2.Game;

namespace FORMSDENEME2
{
    public class Game
    {
        //GAME CLASS VARIABLES
        public string name;
        public int mineNum;
        public int gridSize;
        public int allCells;
        public Button[,] Cells;
        public bool gameOver = false;
        public bool youWon = false;
        public int flagCount;
        public int timeCount;
        public int moveCount;
        public int score;
        public Image flag = Image.FromFile("C:\\Users\\Asus\\source\\repos\\FORMSDENEME2\\FORMSDENEME2\\Resources\\flag.png");
        public Image mine = Image.FromFile("C:\\Users\\Asus\\source\\repos\\FORMSDENEME2\\FORMSDENEME2\\Resources\\mine.png");
        private Random rnd = new Random();

        //CONSTRUCTOR
        public Game(string gName, int gMineNum, int gGridSize)
        {
            name = gName;
            mineNum = gMineNum;
            gridSize = gGridSize;
            flagCount = mineNum;
            timeCount = 0;
            moveCount = 0;
        }

        //CREATEGRID FUNCTION
        public void CreateGrid(Form form, int rows, int cols)
        {
            rows = cols = gridSize;
            Cells = new Button[rows, cols];

            int cellSize = 0;
            switch (gridSize)
            {
                case 30: cellSize = 30; break;
                case 29: cellSize = 31; break;
                case 28: cellSize = 32; break;
                case 27: cellSize = 33; break;
                case 26: cellSize = 34; break;
                case 25: cellSize = 36; break;
                case 24: cellSize = 37; break;
                case 23: cellSize = 39; break;
                case 22: cellSize = 41; break;
                case 21: cellSize = 43; break;
                case 20: cellSize = 45; break;
                case 19: cellSize = 47; break;
                case 18: cellSize = 50; break;
                case 17: cellSize = 52; break;
                case 16: cellSize = 55; break;
                case 15: cellSize = 58; break;
                case 14: cellSize = 63; break;
                case 13: cellSize = 67; break;
                case 12: cellSize = 71; break;
                case 11: cellSize = 78; break;
                case 10: cellSize = 85; break;
            }

            int GridWidth = cellSize * cols;
            int GridHeight = cellSize * rows;

            int startX = (form.ClientSize.Width - GridWidth) / 2;
            int startY = (form.ClientSize.Height - GridHeight) / 2;

            Form2 gameForm = form as Form2;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Button cell = new Button();
                    cell.Width = cellSize;
                    cell.Height = cellSize;
                    cell.Left = startX + (cellSize * j);
                    cell.Top = startY + (cellSize * i);
                    cell.BackColor = Color.LightGray;

                    cell.MouseDown += gameForm.Cells_MouseDown;

                    form.Controls.Add(cell);
                    Cells[i, j] = cell;
                }
            }
        }

        //REVEALNEIGHBORS FUNCTION
        public void RevealNeighbors(int row, int col)
        {
            if (row < 0 || col < 0 || row >= gridSize || col >= gridSize)
                return;

            Button cell = Cells[row, col];

            if (cell.BackColor == Color.LightSkyBlue || cell.BackgroundImage == flag)
                return;

            int mineCount = 0;
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (i >= 0 && i < gridSize && j >= 0 && j < gridSize)
                    {
                        if (Cells[i, j].Tag != null && Cells[i, j].Tag.ToString() == "X")
                        {
                            mineCount++;
                        }
                    }
                }
            }

            if (mineCount > 0)
            {
                cell.Text = mineCount.ToString();
                cell.Font = new Font(cell.Font, FontStyle.Bold);
                cell.BackColor = Color.LightSkyBlue;
            }
            else
            {
                cell.Text = "";
                cell.BackColor = Color.LightSkyBlue;

                for (int i = row - 1; i <= row + 1; i++)
                {
                    for (int j = col - 1; j <= col + 1; j++)
                    {
                        if (i >= 0 && i < gridSize && j >= 0 && j < gridSize)
                        {
                            if (Cells[i, j].BackColor != Color.LightSkyBlue)
                            {
                                RevealNeighbors(i, j);
                            }
                        }
                    }
                }
            }
        }

        //PLACEMINES FUNCTION
        public void PlaceMines()
        {
            int placedMines = 0;
            allCells = gridSize * gridSize;

            while (placedMines < mineNum)
            {
                int randomPosition = rnd.Next(0, allCells);
                int row = randomPosition / gridSize;
                int col = randomPosition % gridSize;

                if (Cells[row, col].Tag == null)
                {
                    Cells[row, col].Tag = "X";
                    placedMines++;
                }
            }
        }

        //YOUWON FUNCTION
        public void YouWon()
        {
            int blueCount = 0;
            allCells = gridSize * gridSize;

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (Cells[i, j].BackColor == Color.LightSkyBlue)
                    {
                        blueCount++;
                    }
                }
            }

            if (blueCount == allCells - mineNum)
            {
                youWon = true;
            }

            if (youWon)
            {
                score = 0;
                int trueFlag = 0;

                for (int i = 0; i < gridSize; i++)
                {
                    for (int j = 0; j < gridSize; j++)
                    {
                        if (Cells[i, j].Tag == "X" && Cells[i, j].BackgroundImage == flag)
                        {
                            trueFlag++;
                        }
                    }
                }

                if (timeCount >= 1)
                    score = (trueFlag * 1000) / timeCount;
                else
                    score = 0;
            }
        }

        //RESTARTGAME FUNCTION
        public void RestartGame()
        {
            gameOver = false;
            youWon = false;
            flagCount = mineNum;
            timeCount = 0;
            moveCount = 0;

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    Cells[i, j].Tag = null;
                    Cells[i, j].Text = "";
                    if (Cells[i, j].BackgroundImage == flag)
                        Cells[i, j].BackgroundImage = null;
                    if (Cells[i, j].BackgroundImage == mine)
                        Cells[i, j].BackgroundImage = null;
                    Cells[i, j].BackColor = Color.LightGray;
                }
            }

            PlaceMines();
        }

        //SCOREBOARD CLASS
        public class Scoreboard 
        {
            //SCOREBOARD CLASS VARIABLES
            public string name;
            public int score;
            public bool youWon;
            public Dictionary<string, int> playerScores = new Dictionary<string, int>();
            public string scoreFile = "scores.txt";

            //CONSTRUCTOR
            public Scoreboard(string sName, int sScore) 
            {
                name = sName;
                score = sScore;
            }

            //ADDSCORE FUNCTION 
            public void AddScore(string name, int score)
            {
                if (playerScores.ContainsKey(name))
                {
                    if (score > playerScores[name])
                    {
                        playerScores[name] = score;
                    }
                }
                else
                {
                    playerScores.Add(name, score);
                }
            }

            //SAVESCORES FUNCTION
            public void SaveScores()
            {
                var lines = playerScores.Select(kv => kv.Key + ": " + kv.Value);
                File.WriteAllLines(scoreFile, lines);
            }

            //LOADSCORES FUNCTION
            public void LoadScores()
            {
                if (File.Exists(scoreFile))
                {

                    var lines = File.ReadAllLines(scoreFile);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(':');
                        if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int score))
                        {
                            playerScores[parts[0].Trim()] = score;
                        }
                    }

                }
            }
        }
    }
}