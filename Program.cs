using System;

namespace Loops
{
 class Program
    {
        static void Main()
        {

            string[] names = { "saif", "Aziz", "Zeeshan" };

            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            foreach(int k in numbers)
            {
                Console.WriteLine("Foreach loop"+ k);
            }


            foreach(string s in names)
            {
                Console.WriteLine(s);
            }

            for(int j = 0; j < names.Length; j++)
            {
                Console.WriteLine("for loop");
            }

            int i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine("While loop");
                i++;
            }
        }
    }
}
