using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Collections;

namespace botvk
{
    class Program
    {  /*bool proverka (string aser)
        {
            var per = aser.GetEnumerator();
            while (per.MoveNext())
            { if
                char.
            }


        }*/
        static void Main(string[] args)
        {
            фракции фракция = new фракции();
            Console.Write("Введите: имя фракции тег ");
            фракция.namefr = Console.ReadLine( );
            фракция.teg = Console.ReadLine();
            
            //string.Empty.ToUpper

            
            //****
            List<фракции> фр = new List<фракции>();
            фр.Add(new фракции(фракция.teg, фракция.namefr));
            foreach (фракции ф in фр) ф.вывод();

        }
    }

}
