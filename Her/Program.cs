using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Her
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you love ME?");
            Console.Write("Yes or No: ");
            string userinput = Console.ReadLine();

            if (userinput == "Yes")
            {
                string message = "I love you too :)";
                Console.WriteLine(message);
            }
            else if (userinput == "No")
              {
                string message = "I take the no as a yes so I love you too!";
                Console.WriteLine(message);
            }
            else
            {
                string message = "Choose Yes or No girl -_-";
                Console.WriteLine(message);
            }
            
            Console.ReadLine();



        }
    }
}
