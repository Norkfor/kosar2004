using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosar2004
{
  class kosarak
  {
    private string hazai;

    public string Hazai
    {
      get { return hazai; }
      set { hazai = value; }
    }

    private string idegen;

    public string Idegen
    {
      get { return idegen; }
      set { idegen = value; }
    }

    private int hazai_pont;

    public int Hazai_pont
    {
      get { return hazai_pont; }
      set { hazai_pont = value; }
    }

    private int idegen_ponnt;

    public int Idegen_pont
    {
      get { return idegen_ponnt; }
      set { idegen_ponnt = value; }
    }

    private string helyszin;

    public string Helyszin
    {
      get { return helyszin; }
      set { helyszin = value; }
    }

    private DateTime idopont;



    public DateTime Idopont
    {
      get { return idopont; }
      set { idopont = value; }
    }
    public kosarak(string hazai, string idegen, int hazai_pont, int idegen_ponnt, string helyszin, DateTime idopont)
    {
      this.hazai = hazai;
      this.idegen = idegen;
      this.hazai_pont = hazai_pont;
      this.idegen_ponnt = idegen_ponnt;
      this.helyszin = helyszin;
      this.idopont = idopont;
    }

  }
}
