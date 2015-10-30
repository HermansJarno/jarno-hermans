using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzhee3
{
  public partial class CheatsView : UserControl
  {
    public CheatsController controller;
    protected CheatsModel model = new CheatsModel();
    protected TeerlingView teerlingView;
    public List<PlayerController> mPlayerControl = new List<PlayerController>();
    static public List<TeerlingController> mTeerlingControl = new List<TeerlingController>();
    static List<ScoreboardController> mScoreboardControl = new List<ScoreboardController>();

        public void addController(ScoreboardController scoreboardcontrol)
        {
            mScoreboardControl.Add(scoreboardcontrol);
        }

        public CheatsView(CheatsController c)
    {
      InitializeComponent();
      controller = c;
    }

    public CheatsView()
    {
      InitializeComponent();
    }

    #region Methods

    public void AddTeerling(TeerlingController c)
    {
      mTeerlingControl.Add(c);
    }

    public void ShowMessageNoCheats(string kindOfCheat)
    {
      MessageBox.Show("First buy a " + kindOfCheat + " before you can use one!");
    }

    public void viewWerpButtons()
    {
      for (int i = 0; i < mTeerlingControl.Count; i++)
      {
        mTeerlingControl[i].cheatButtonVisibility();
      }
    }
    
    public void getExtraButton()
    {
      
    }

    public void btnUseOneCheat(int cheatNumber)
    {
      switch (cheatNumber)
      {
        case 1:
          int minusOneCheat1 = model.NumberBoughtCheats--;
          lblAantalCheat1.Text = minusOneCheat1.ToString();
          break;
        case 2:
          int minusOneCheat2 = model.NumberBoughtCheats--;
          lblAantalCheat2.Text = minusOneCheat2.ToString();
          break;
      }
    }

        private void UseTotalScore(int i)
        {
            int totalscore = mScoreboardControl[i].model.TotalScore;
            totalscore -= 5;
            Yahtzee formYahtzee = Globals.formYahtzee;
            formYahtzee.updateTotalLabelScore(i, totalscore);
        }

        private void btnCheat1_Click(object sender, EventArgs e)
        {
            updateLabelandScore(0);
        }

        private void updateLabelandScore(int i)
        {
            Yahtzee formYahtzee = Globals.formYahtzee;
            string targetLabel = "lblTotalScore" + (i + 1);
            Control[] labels2 = formYahtzee.Controls.Find(targetLabel, true);
            Label lblScore = (Label)labels2[0];
            int score = 0;
            score = int.Parse((lblScore.Text));
            if (score >= 5)
            {
                if (i == 0)
                {
                    int newNumberOfCheats = model.NumberBoughtCheats++;
                    lblAantalCheat1.Text = newNumberOfCheats.ToString();
                    UseTotalScore(i);
                }
                else
                {
                    int newNumberOfCheats = model.NumberBoughtCheats++;
                    lblAantalCheat2.Text = newNumberOfCheats.ToString();
                    UseTotalScore(i);
                }
            }
            else
            {
                MessageBox.Show("You need at least 5 points to use this cheat!");
            }
        }

        private void btnUseCheat1_Click(object sender, EventArgs e)
    {
      if (lblAantalCheat1.Text == "0")
      {
        ShowMessageNoCheats("Cheat1");
      }
      else
      {
        if (ScoreboardModel.Aantalworpen == 3)
        {
          btnUseOneCheat(1);
          viewWerpButtons();
        }
        else
        {
          MessageBox.Show("Roll at least 3 times before you can use this cheat!");
        }        
      }
    }

        private void btnCheat2_Click(object sender, EventArgs e)
        {
            updateLabelandScore(1);
        }

    private void btnUseCheat2_Click(object sender, EventArgs e)
    {
      if (lblAantalCheat2.Text == "0")
      {
        ShowMessageNoCheats("Cheat2");
      }
      else
      {
        if (ScoreboardModel.Aantalworpen == 3)
        {
                    Yahtzee formyahtzee = new Yahtzee();
                    btnUseOneCheat(2);
                    formyahtzee.extraTeerlingTonen();
        }
        else
        {
          MessageBox.Show("Roll at least 3 times before you can use this cheat!");
        } 
      }
    }

    #endregion
    
  }
}
