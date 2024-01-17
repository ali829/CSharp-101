using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_value_types
{
    class Program
    {

        public struct CustomValue
        {
            public int intValue;
            public string stringValue;
        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }


        static void Main(string[] args)
        {
            CustomValue cv = new CustomValue();

            cv.intValue = 24;
            cv.stringValue = "hello worl!";

            Console.WriteLine($"Int Value : {cv.intValue}");
            Console.WriteLine($"String Value : {cv.stringValue}");
            //====================================================================

            Person person1 = new Person();
            Person person2 = person1;

            person1.Name = "ali";
            person1.Age = 23;

            person2.Name = "abdo";

            Console.WriteLine($"name of {nameof(person1)} : {person1.Name}");
            //=======================================================

            Person person3 = new Person();
            person3.Name = "Jhon";
            person3.Age = 90;

            UpdatePerson(person3);
            Console.WriteLine($"The value of {nameof(person3)} after UpdatePerson : {person3.Name} , {person3.Age}");
            Console.ReadLine();
        }


        static void UpdatePerson(Person person)
        {
            person.Name = "Albert";
            person.Age = 30;
        }
    }
}
