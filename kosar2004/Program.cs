﻿using System;
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

    }

    private static void HatodikFeladat()
    {

    }

    private static void OtodikFeladat()
    {

    }

    private static void NegyedikFeladat()
    {

    }

    private static void HarmadikFeladat()
    {

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
