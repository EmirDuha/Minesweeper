using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace FORMSDENEME2
{
    public partial class Form3 : Form
    {

        //DECLARING SCOREBOARD CLASS 
        Game.Scoreboard scoreboard;

        //CONSTRUCTOR
        public Form3(string sName, int sScore)
        {
            InitializeComponent();

            scoreboard = new Game.Scoreboard(sName, sScore);

        }

        //SCOREBOARD LOAD FUNCTION
        private void Scoreboard_Load(object sender, EventArgs e)
        {

            scoreboard.LoadScores();
            UpdateScoreboard();
            scoreboard.AddScore(scoreboard.name, scoreboard.score);
            UpdateScoreboard(); 
            scoreboard.SaveScores();

        }

        //UPDATESCOREBOARD FUNCTION
        private void UpdateScoreboard()
        {
            var topScores = scoreboard.playerScores
                .OrderByDescending(kv => kv.Value)
                .Take(10);

            listBoxScoreboard.Items.Clear();

            foreach (var score in topScores)
            {
                listBoxScoreboard.Items.Add(score.Key + ": " + score.Value);
                listBoxScoreboard.Items.Add(" ");
            }
        }
    }
}
