using System;
using System.Collections.Generic;

namespace Romanian_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert q = new Convert();
            Console.Write("Введите римские цифры: ");
            Console.WriteLine(q.convr(Console.ReadLine()));
            Console.ReadKey();
        }
    }

    class Convert
    {
        private Dictionary<char, int> digits;

        public Convert()
        {
            digits = new Dictionary<char, int>
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };
        }
        public int convr(string r)
        {
            string rom = r.ToUpper();
            int value = 0;
            char[] rv = rom.ToCharArray(0, rom.Length);
            try
            {
                for (int i = 0; i < rv.Length; ++i)
                {
                    if (i == rv.Length - 1)
                        value += digits[rv[i]];
                    else if (digits[rv[i + 1]] > digits[rv[i]])
                        value -= digits[rv[i]];
                    else
                        value += digits[rv[i]];
                }
            }

            catch (System.Collections.Generic.KeyNotFoundException end)
            {
                Console.WriteLine("Неверно");
            }
                return value;
        }

        
    }
}
