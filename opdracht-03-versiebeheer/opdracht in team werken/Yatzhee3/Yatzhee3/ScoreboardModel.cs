using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzhee3
{
    public class ScoreboardModel
    {

        string[] mScoreNamen = { "Aantal Worpen :", "Score :", "Highscore :" };
        private int aantalWorpen;
        private int score;

        public string[] ScoreNamen
        {
            get { return mScoreNamen; }
        }

        public int Aantalworpen
        {
            get { return aantalWorpen; }
            set { aantalWorpen = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

    }
}
