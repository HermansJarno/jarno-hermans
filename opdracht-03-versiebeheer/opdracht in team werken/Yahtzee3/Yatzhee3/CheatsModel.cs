using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzhee3
{
  public class CheatsModel
  {
    protected int numberBoughtCheats = 0;

    #region Properties

    public int NumberBoughtCheats
    {
      get { return numberBoughtCheats; }

      set { numberBoughtCheats = value; }
    }

    #endregion
  }
}
