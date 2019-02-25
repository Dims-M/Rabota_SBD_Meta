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
                Console.WriteLine("Записанно в файл"); //проверочный вывод
            }
           // Console.WriteLine("Записанно в файл"); //проверочный вывод
            Console.ReadKey(true);

        }

        /// <summary>
        /// Запись в файл рядом с exe и передачей текста в метод
        /// </summary>
        /// <param name="text">Текст что нужно записать в лог по умолчанию</param>
        public static void ZapisFailaText( string text)
        {
            DateTime now = DateTime.Now; // получение тек времени
            string tempDateTime = now.ToString();

            using (var sw = new StreamWriter("Log.txt", true, Encoding.Unicode)) // создание обьект потока для записи файла
            {
                //System.Text.Encoding.Default
                // sw.Write("\t\n");
                sw.Write($"{tempDateTime}" + "\t\n");
                sw.Write(text);
                sw.Write("\t\n");

            }
           

        }

        /// <summary>
        /// Чтене файла(лога) по умолчанию
        /// </summary>
        public static void ChteniefailaLoga()
        {
            string tempLog = "Log.txt";
            string tempText = "Содержимое файла \t\n";

            using (var  sr = new StreamReader(tempLog, System.Text.Encoding.Default)) // обьект для чтение потока при чтении файла с жестого диска  
            {
                // var text = sr.ReadLine().ToString();           
                tempText += sr.ReadToEnd().ToString();
            }
            Console.WriteLine(tempText);
            Console.ReadKey(true);
        }

        /// <summary>
        /// Чтение файла с указание пути хранения файла.
        /// </summary>
        /// <param name="Path">Путь к файлу. </param>
        public static void ChteniefailaFailaPath(string Path)
        {
            string tempLog = "Log.txt";
            string tempText = "Содержимое файла \t\n";

            using (var sr = new StreamReader(tempLog, Encoding.Unicode)) // обьект для чтение потока при чтении файла с жестого диска  
            {
                //Encoding.Default
                // var text = sr.ReadLine().ToString();           
                tempText += sr.ReadToEnd().ToString();
            }
            Console.WriteLine(tempText); //проверочный вывод
            Console.ReadKey(true);
        }


    } // конец класса

}
