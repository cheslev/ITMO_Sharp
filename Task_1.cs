using System;

namespace C_
{
    class Task
    {  
        public static bool IsPrime(int a)
        {
            if (a <= 1 )
                return false;
            for (int i = 2; i < a; i++)
                if ((a % i) == 0)
                    return false;
            return true;
        }
        
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
          

            for(int i = n; i <= m; i++)
                if (IsPrime(i))
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}