using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Entities;


namespace OOPPROJECT1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Malka", 1234);
            Person person2 = new Person("sima", 1234);
            Person person3 = new Person("shevy", 1234);
            Product product1 = new Product(10, "computer", 123.45);
            Console.WriteLine(person1);
            Person[] array = new Person[5];
            
            StreamReader input = new StreamReader("TextFile1.txt");
          
            using (input)
            {
                for(int i=0; i<array.Length; i++)
                {
                    array[i] = new Person(input.ReadLine(), int.Parse(input.ReadLine()));
                    Console.WriteLine(array[i]);
                    Console.WriteLine("running this program");
                }
            }

        }
    }
}
