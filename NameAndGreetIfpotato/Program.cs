using System;

namespace NameAndGreetIfpotato
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name: ");
            string isNamePotato = Console.ReadLine();
            if(isNamePotato == "Potato" || isNamePotato == "potato")
            {
                Console.WriteLine("Bonjour Mr Potato, please enter your password...");
            }
            Console.ReadLine();
        }
    }
}
