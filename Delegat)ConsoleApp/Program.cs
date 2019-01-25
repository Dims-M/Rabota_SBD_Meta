using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_ConsoleApp
{

    // обьявляем делегат(класс делегат)
    delegate void myDelegate();

    class Program
    {
     // static  Rsbota_Delegate rsbota_Delegate;

        static void Main(string[] args)
        {
            Rsbota_Delegate rsbota_Delegate = new Rsbota_Delegate();

            rsbota_Delegate.RabDelegat(10);
           // rsbota_Delegate.RabDelegat(13);
        }

    }

    class Rsbota_Delegate
    {
        myDelegate myDelegate1; // обьявили обьект делегата(конкретный обьект делегата)


        public void RabDelegat(int znach )
        {
            Console.WriteLine($"Сработал метод RabDelegat \t\nТекущие значение: {znach}");


            if (znach < 12)
            {
                // присваиваем(привязываем) в делегат этот метод
                myDelegate1 = tectMethod1;
                
            }

            else
            {
                // присваиваем(привязываем) в делегат этот метод
                myDelegate1 = tectMethod2;
            }

            myDelegate1(); // запуск делегата! 
            
        }



        /// <summary>
        /// тестовые  методы для делегатов
        /// </summary>
        public void tectMethod1()
        {
            Console.WriteLine($"Сработал метод № 1: \t\nТекущие время:{CurrentTime()} ");
            Console.ReadKey();
        }

        public void tectMethod2()
        {
            Console.WriteLine($"******* /t/n Сработал метод № 2: \t\nТекущие время:{CurrentTime()} ******");
            Console.ReadKey();
        }

        /// <summary>
        /// Получение времени
        /// </summary>
        /// <returns></returns>
        public string CurrentTime()
        {
            DateTime dateTime = DateTime.Now;

            return dateTime.ToString();


        }
    }



}
