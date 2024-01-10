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
            string operation;
            Console.WriteLine("write First Number :");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("write Second Number :");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write the operation :");
            operation = Console.ReadLine();

            if(operation == "+")
            {
                total = Addition(num1, num2);
            }
            else if(operation == "-")
            {
                total = Subtraction(num1, num2);
            }else if (operation == "*")
            {
                total = Multiplication(num1, num2);
            }else if (operation == "/") {
                total = Division(num1, num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Total :" + total);


            Console.ReadLine();
        }

        static double Addition(double a, double b) {
            return a + b;
        }
        static double Subtraction(double a , double b)
        {
            return a - b;
        }
        static double Multiplication(double a, double b)
        {
            return a * b;
        }

        static double Division(double a, double b)
        {
            return a / b;
        }
    }
}
