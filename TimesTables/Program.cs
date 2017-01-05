using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesTables
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Which number do u wat to find the tables of?");
            int numberInput = int.Parse(Console.ReadLine());
            Console.WriteLine("What number would you times it by?");
            int secondNumberInput = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            for (int i = 0; i == secondNumberInput; i++)
            {
                int finalAnswer = numberInput * i;
                Console.Write(finalAnswer + ", ");
            }
            Console.ReadLine();





        }
    }
}
