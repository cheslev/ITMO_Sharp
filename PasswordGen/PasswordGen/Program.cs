using System;
using System.Text;

namespace PasswordGen
{
    class Program
    {
       
        public static string GetRandomPassword(int lenght)
        {
            const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
            const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string NUMBERS = "123456789";

            StringBuilder sb = new StringBuilder();
            Random rdm = new Random();


            for (int i = 0; i < lenght; i++)
            {
                int index = rdm.Next(LOWER_CASE.Length);
                sb.Append(LOWER_CASE[index]);
                
                int index_1 = rdm.Next(UPPER_CASE.Length);
                sb.Append(UPPER_CASE[index]);

                int index_2 = rdm.Next(NUMBERS.Length);
                sb.Append(NUMBERS[index]);
                
            }

            return sb.ToString();

        }
        
        public static void Main()
        {
            int lenght = 8;

            string password = GetRandomPassword(lenght);
            Console.WriteLine(password);
        }

    }
}
