namespace HelloWorld
{
    using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

    
   // <summary>
    //   Hello World!
   // </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("what is your name");
            var name = Console.ReadLine();
            var currentDate= DateTime.Now;
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine($"Today is {currentDate.ToShortDateString()}");
           
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
        }
    }
}