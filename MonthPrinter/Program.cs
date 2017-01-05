using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthPrinter
{
    class Program
    {
        static void Main()
        {

                Console.WriteLine("what index of the month do you require? to exit the game press space...");

                int numberInput = int.Parse(Console.ReadLine());
            
                switch (numberInput)
                {
                    case 1 :
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;

                    case 4:
                        Console.WriteLine("April");
                             break;
                     case 5:
                         Console.WriteLine("May");
                         break;
                     case  6:
                         Console.WriteLine("June");
                         break;
                     case 7:
                         Console.WriteLine("July");
                         break;
                     case 8:
                         Console.WriteLine("Auguest");
                         break;
                     case 9:
                         Console.WriteLine("September");
                         break;
                     case 10:
                         Console.WriteLine("October");
                         break;
                     case 11:
                         Console.WriteLine("November");
                         break;
                     case 12:
                         Console.WriteLine("December");
                         break;
                     default:
                         Console.WriteLine("please anter a valid number");
                         break;
                }

            Console.ReadLine();


            }
        }
    }

