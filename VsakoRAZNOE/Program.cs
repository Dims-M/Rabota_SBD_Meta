using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsakoRAZNOE
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalMethod();
        }

        /// <summary>
        /// локальные методы
        /// </summary>
        public static void LocalMethod()
        {
            var result = GetResult(new int[] { -3, -2, -1, 0, 1, 2, 3 });
            Console.WriteLine(result);  // 6
            Console.ReadKey(true);
        }
        static int GetResult(int[] numbers)
        {
            int limit = 0;
            // локальная функция
            bool IsMoreThan(int number)
            {
                return number > limit;
            }

            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsMoreThan(numbers[i]))
                {
                    result += numbers[i];
                }
            }

            return result;
        }
    }
}
