using ExeptionsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            DemoCode demo = new DemoCode();
            try
            {
                int result = demo.GrandParent(6);
                Console.WriteLine($"The value of the given position is : {result}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                var inner = ex.InnerException;

                if(inner != null)
                {
                    Console.WriteLine(inner.StackTrace);
                    inner = inner.InnerException;
                }
            }
            Console.ReadLine();
        }
    }
}
