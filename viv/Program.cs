using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person sergey = new Person ("Сергей",16);
            sergey.Print();
            Person viktor = new Person("Виктор", 16);
            viktor.Print();
            Console.ReadKey();
        }

        public class Person
        {
            public string Name { get; set; }
            public byte Age { get; set; }

            public Person (string name, byte age)
            {
                this.Name = name;
               this.Age = age;
            }   
            public void Print()
            {
                Console.WriteLine($"Name: {Name}\nAge:{Age}");
            }
        }
    }

}
