using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobytie_delegat_Itvn
{

    /// <summary>
    ///Пустой Тестовой делегат для событий
    /// </summary>
    public delegate void eiventDelegate();

    /// <summary>
    /// Пример работы событий
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

        }

        /// <summary>
        /// проверочный метод №1
        /// </summary>
        static private void Handler1()
        {
            Console.WriteLine("Метод №1");
        }

        /// <summary>
        /// проверочный метод №2
        /// </summary>
        static private void Handler2()
        {
            Console.WriteLine("Метод из главного класса №2");
        }


    }

    /// <summary>
    /// Тестовой класс
    /// </summary>
   class MyTestClass
        {

        // событийный обьект делегата относится к этому классу
        public event eiventDelegate myEvent = null;


        }

}

