using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Collections;

namespace botvk
{
    class Program
    {
        static void Main(string[] args)
        {
            фракции фракция = new фракции("Test", "TST");
            List<фракции> фр = new List<фракции>(4);
            фр.Add(фракция);
            foreach (фракции ф in фр) Console.WriteLine(ф.ToString());
            Console.ReadKey();
        }
    }

}
