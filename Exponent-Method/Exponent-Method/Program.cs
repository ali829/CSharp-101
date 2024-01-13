using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponent_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(32, 2));
            Console.ReadLine();
        }



        static Int64 GetPow(int powNum , int baseNum)
        {
            Int64 result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }


            return result;
        }
    }
}
