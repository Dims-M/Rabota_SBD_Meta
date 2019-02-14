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
            testClass program = new testClass();
            // LocalMethod(); // локальный метод
            PoluchenieTupeClassa();
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


        public static void PoluchenieTupeClassa()
        {
            string tempZnanh = typeof(testClass).ToString(); // имя класса

            var type = typeof(testClass); // получение всех атрибутов

            var atribyte = type;

            Console.WriteLine(tempZnanh);
            Console.ReadKey(true);
        }


    }

    /// <summary>
    /// Тестовой  внуттренний класс
    /// </summary>
    class testClass
    {
    }

}
