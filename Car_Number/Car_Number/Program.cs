using System;

namespace Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; ++i)
                Console.WriteLine(NumberGen.GetNumber());
        }
    }

    class NumberGen
    {
        public static char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'O', 'P', 'T', 'X', 'Y' };
        public static string GetNumber()
        {
            char[] numberSymbols = new char[6];
            Random rnd = new Random();

            numberSymbols[0] = letters[rnd.Next(0, letters.Length)];
            for (int i = 1; i < 4; i++)
                numberSymbols[i] = Convert.ToChar(Convert.ToString(rnd.Next(0, 10)));
            for (int i = 4; i < 6; i++)
                numberSymbols[i] = letters[rnd.Next(0, letters.Length)];
            string number = new string(numberSymbols);
            return number;
        }
    }
}
