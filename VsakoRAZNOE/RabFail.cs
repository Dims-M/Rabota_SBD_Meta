using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsakoRAZNOE
{
    /// <summary>
    /// Работа с файлами и файлстримами
    /// </summary>
    class RabFail
    {


        // Методы

        /// <summary>
        /// Запись файла с указанием пути нахождения файла
        /// </summary>
        /// <param name=" patch">Путь к файлу.</param>
        public static void ZapisFailaPatch(string patch, string text)
        {
            Console.WriteLine("Тестовой вывод");

            DateTime now = DateTime.Now; // получение тек времени
            string tempDateTime = now.ToString();

            Console.WriteLine($"Тестовой вывод \t\n{tempDateTime}\t\n{text}");

            using (var sw = new StreamWriter(patch,true, System.Text.Encoding.Default)) // создание обьект потока для записи файла
            {
               // sw.Write("\t\n");
                sw.Write($"{tempDateTime}" + "\t\n");
                sw.Write(text);
                sw.Write("\t\n");

            }
            Console.ReadKey(true);

        }

   

            } // конец класса

}
