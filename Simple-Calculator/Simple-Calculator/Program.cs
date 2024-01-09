using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2,total;
            Console.WriteLine("write First Number :");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("write Second Number :");
            num2 = Convert.ToDouble(Console.ReadLine());


            total = num1 + num2;
            Console.WriteLine("Total :" + total);


            Console.ReadLine();
        }
    }
}
