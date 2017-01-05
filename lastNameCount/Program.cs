using System;

namespace lastNameCount
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type your full name with spaces to separate each part:");
            string fullName = Console.ReadLine();

            var splitlist = fullName.Split(' ');
            var lastword = splitlist[splitlist.Length - 1];

            int lastwordCount = 0;

            foreach (char letter in lastword)
            {
                lastwordCount += 1;
            }
            Console.WriteLine(lastwordCount);
        }



    }
}

