using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzhee3
{
  public class CheatsController
  {
    public CheatsModel model;
    public CheatsView view;
    public TeerlingView teerlingView;
    public TeerlingController teerlingController;


    #region CTR

    public CheatsController()
    {
      view = new CheatsView();
     // model = new CheatsModel();
      teerlingView = new TeerlingView(teerlingController);
      teerlingController = new TeerlingController();
      model =  new CheatsModel();

    }

    #endregion

    #region Methods

    public CheatsView GetViewCheats()
    {
      return view;
    }

    #region Comment 

    //public int AddOneCheat()
    //{
    //  return model.NumberBoughtCheats++;
    //}

    //public int MinusOneCheat()
    //{
    //  return model.NumberBoughtCheats--;
    //}

    #endregion

    public void cheatButtonVisibility()
    {
      teerlingController.cheatButtonVisibility();
    }

    #endregion

  }
}
