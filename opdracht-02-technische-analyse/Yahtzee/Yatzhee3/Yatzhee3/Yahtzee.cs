using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Yatzhee3
{
    public partial class Yahtzee : Form
    {
        public Yahtzee()
        {
            InitializeComponent();
        }

        int aantalTeerlingen = 5;
        int aantalSoortenScores = 3;
        List<TeerlingController> teerlingen = new List<TeerlingController>();
        List<ScoreboardController> scoreboard = new List<ScoreboardController>();
        
        
        

        private void Yahtzee_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < aantalSoortenScores; i++)
            {
                //instantie van ScoreboardController
                ScoreboardController tijdelijkeScore = new ScoreboardController();
                scoreboard.Add(tijdelijkeScore);
            }


            for (int i = 0; i < aantalTeerlingen; i++)
            {
                //instantie van teerlingcontroller
                TeerlingController tijdelijkeTeerling = new TeerlingController();
                teerlingen.Add(tijdelijkeTeerling);
            }

            //teerlingen tonen
            for (int i = 0; i < aantalTeerlingen; i++)
            {
                TeerlingView teerlingView = teerlingen[i].getView();
                int horizontalPosition;
                horizontalPosition = i * teerlingView.Width;
                
                teerlingView.Location = new System.Drawing.Point(horizontalPosition, 0);

                Controls.Add(teerlingView);
            }

            for (int i = 0; i < aantalSoortenScores; i++)
            {
                ScoreboardView scoreboardView = scoreboard[i].getView();
                int horizontalPosition;
                horizontalPosition = i * scoreboardView.Width;

                scoreboardView.Location = new System.Drawing.Point(this.Width/2 + horizontalPosition, 180);

                Controls.Add(scoreboardView);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (scoreboard[0].model.Score < 3)
            {
                for (int i = 0; i < aantalTeerlingen; i++)
                {
                    if (!teerlingen[i].model.ColorIsRed)
                    {
                        teerlingen[i].Werp();

                        teerlingen[i].UpdateUI();
                    }
                }
            
                scoreboard[0].UpdateAantalWorpen();
            }
            

        }
    }
}
