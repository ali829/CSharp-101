﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Lib
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;
            Console.Write("Enter a color :");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun :");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity :");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses Are " + color);
            Console.WriteLine(pluralNoun + " Are Red");
            Console.WriteLine("I Love You " + celebrity);

            Console.ReadLine();
        }
    }
}
