using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            // sravnenieIntCouts(11,12);
            // sravnenieIntCouts(10,10);

            //Запись файла
            RabSFiles();


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

            else
            {
                proverkaBool = (z) => boolCount == temtBool;
                Console.WriteLine($"++++++----++++\t\n {boolCount}+{temtBool}");
            }

            Console.ReadKey();
        }


        static void sravnenieIntCouts(int a, int b)
        {
            Console.WriteLine("*");
            SravninieIntCount sravninieIntCountDelegat; // локальная переменная делегата
            sravninieIntCountDelegat = (aD, bD) => a == b; // создание лямба метода и априсваивание его булевскому делегату

            intBollSravninie(sravninieIntCountDelegat.Invoke(a, b)); //запуск делегата
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


        /// <summary>
        /// Запись в файл
        /// </summary>
        public static void RabSFiles()
        {
            // коменты
            #region Тестовые методы
            // RabFail.ZapisFailaPatch("textFail.txt", "Хрень");
            // RabFail.ZapisFailaText("Проверочная хрень для лога");
            // чтение файла
            //  RabFail.ChteniefailaLoga();

            // работа с "многопоточностью".
            // RabFail.DoWork(); //вывод из максимального значения инта

            #endregion

            // запуск метода в новом потоке. С параметраризатором ThreadStart
            Thread thread = new Thread(new ThreadStart(RabFail.DoWork));
            //  thread.Start();
            // паралельный запуск двух потоков с параметрами. Используется параметр ParameterizedThreadStart
            Thread thread2 = new Thread(new ParameterizedThreadStart(RabFail.DoWorkTest));
           // thread2.Start(10000);

            Thread thread3 = new Thread(new ParameterizedThreadStart(RabFail.DoWorkTest));
            // thread3.Start(12500);

            //Вызываем методы асинхронного вызовов
            // RabThreadAsync(); //асинхронный метод

            // Вызываем метод с параметром для передачи в нужный метод
           // RabThreadParametrAsync(12475);

          //  thread.Start(); асинхронные методы работают паралельно
            Console.ReadKey(true);

        }
        /// <summary>
        /// aсинхронный метод обертку над нужным методом
        /// </summary>
        public async static Task RabThreadAsync()
        {
            Console.WriteLine("Работаем с асинронными методами");
            // aсинхронный метод обертку над нужным методом
            // Task DoWorkAsync();

            // через ананимную лямбу вызываем нужный метод
           // await Task.Run(()=> RabFail.DoWork());
            await Task.Run(()=> RabFail.DoWorkTest(55040));

            Console.ReadKey();
        }

        /// <summary>
        /// aсинхронный метод обертку над нужным методом с Параметрами
        /// </summary>
        public async static Task RabThreadParametrAsync(int paramss)
        {
            Console.WriteLine("Работаем с асинронными методами c указанием параметра");

            await Task.Run(()=> RabFail.DoWorkTest(paramss));
        }

    } // конец класса
      /// <summary>
      /// Тестовой  внуттренний класс
      /// </summary>
    class testClass
    {

    }

}
