using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kosar2004
{
  class Program
  {
    static List<kosarak> kosar = new List<kosarak>();
    static Dictionary<string, int> husznaltobb = new Dictionary<string, int>();
    static void Main(string[] args)
    {
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      HetedikFeladat();
      Console.ReadKey();

    }

    private static void HetedikFeladat()
    {
      Console.WriteLine("7. feladat:");
      foreach (var k in kosar)
      {
        if (!husznaltobb.ContainsKey(k.Helyszin))
        {
          husznaltobb.Add(k.Helyszin, 1);
        }
        else
        {
          husznaltobb[k.Helyszin]++;
        }
      }
      foreach (var h in husznaltobb)
      {
        if (h.Value > 20)
        {
          Console.WriteLine("\t{0} : {1}", h.Key, h.Value);
        }
      }
    }

    private static void HatodikFeladat()
    {
      Console.WriteLine("6. feladat");
      foreach (var k in kosar)
      {
        if (k.Idopont == DateTime.Parse("2004.11.21"))
        {
          Console.WriteLine("\t{0} - {1} ({2}:{3})", k.Hazai, k.Idegen, k.Hazai_pont, k.Idegen_pont);
        }
      }
    }

    private static void OtodikFeladat()
    {
      string neve = String.Empty;
      foreach (var k in kosar)
      {
        if (k.Hazai.Contains("Barcelona"))
        {
          neve = k.Hazai;
        }
      }
      Console.WriteLine("5. feladat: barcelonai csapat neve: {0}", neve);
    }

    private static void NegyedikFeladat()
    {
      bool volte = false;
      foreach (var k in kosar)
      {
        if (k.Hazai_pont == k.Idegen_pont)
        {
          volte = true;
        }
      }
      if (volte == true)
      {
        Console.WriteLine("4. feladat: Volt döntetlen? igen");
      }
      else
      {
        Console.WriteLine("4. feladat: Volt döntetlen? nem");
      }
    }

    private static void HarmadikFeladat()
    {
      int hazai = 0;
      int idegen = 0;
      foreach (var k in kosar)
      {
        if (k.Hazai == "Real Madrid")
        {
          hazai++;
        }
        else if (k.Idegen == "Real Madrid")
        {
          idegen++;
        }

      }
      Console.WriteLine("3. feladat: Real Madrid: Hazai: {0}, Idegen: {1}", hazai, idegen);
    }

    private static void MasodikFeladat()
    {
      StreamReader be = new StreamReader("eredmenyek.csv");
      be.ReadLine();
      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');
        kosar.Add(new kosarak(a[0], (a[1]), int.Parse(a[2]), int.Parse(a[3]), a[4], DateTime.Parse(a[5])));
      }
      be.Close();
    }

  }
}
