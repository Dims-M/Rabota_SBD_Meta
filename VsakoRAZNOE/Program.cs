using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsakoRAZNOE
{
    class Program
    {
        public delegate int summint();
        public delegate bool Proverka(bool zna);
        public delegate bool SravninieIntCount(int a, int b);

        static void Main(string[] args)
        {
           

            testClass program = new testClass();
            // LocalMethod(); // локальный метод
            //PoluchenieTupeClassa();

            //запуск делегата
            // zapuskLambaMetoda(10, 10);
            //zapuskLambaMetoda(25, 25);

            //булевские значения
            // zapuskBollDelegata(true);
            //zapuskBollDelegata(false);

            sravnenieIntCouts(11,12);
            sravnenieIntCouts(10,10);
        }

        // запуск интового делегата
       static void zapuskLambaMetoda(int a, int b)
        {
            // в экземпляр делегата присваиваем ляба метод
            summint si = () => a + b; // без хводящий парметров

            Console.WriteLine($"Сложение 2x чисел \n Первое число:{a} \n Второе число:{b}");
            Console.WriteLine(si.Invoke()); // запуск делегата
            Console.ReadKey();
        }

        static void zapuskBollDelegata(bool boolCount)
        {
            bool temtBool = false;
            Proverka proverkaBool;
            // Proverka proverkaBool = (biilZnavh) => 

            if (boolCount == temtBool)
            {
                Console.WriteLine("Хрень моржовая");
                 proverkaBool = (z) => boolCount == temtBool;
            }

           else{
                proverkaBool = (z) => boolCount == temtBool;
                Console.WriteLine($"++++++----++++\t\n {boolCount}+{temtBool}");
            }

            Console.ReadKey();
        }


        static void sravnenieIntCouts( int a, int b)
        {
            Console.WriteLine("*");
            SravninieIntCount sravninieIntCountDelegat; // локальная переменная делегата
            sravninieIntCountDelegat = (aD, bD) => a == b; // создание лямба метода и априсваивание его булевскому делегату

            intBollSravninie( sravninieIntCountDelegat.Invoke(a,b)); //запуск делегата
            Console.WriteLine("!!*!!s");
        }
        //сравнение по булевскому признаку
        static void intBollSravninie(bool count)
        {
            if (count == true)
            {
                Console.WriteLine($"текущие значение истинное. {count}");
            }
            else
            {
                Console.WriteLine($"текущие значение НЕ истинное!!!!. {count}");
            }

            Console.WriteLine("*****");
            Console.ReadKey(true);
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

        /// <summary>
        /// Получение и вывод класса на кансоль
        /// </summary>
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
