using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionsLibrary
{
    public class DemoCode
    {
        public int GrandParent(int position)
        {
            int output = 0;
            Console.WriteLine("Open database connection!");
            try
            {
                return output = Parent(position);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("You Passed In Bad Data",ex);
            }
            finally {
                Console.WriteLine("Close database conection!");
            };
        }
        public int Parent(int position)
        {
            return GetNumber(position);
        }
        public int GetNumber(int position)
        {
            int output = 0;
            int[] numbers = new int[] { 1, 3, 10, 89, 19 };

            output = numbers[position];


            return output;
        }
    }
}
