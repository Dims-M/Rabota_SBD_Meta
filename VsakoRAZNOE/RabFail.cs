﻿using System;
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

            using (var sw = new StreamWriter("Log.txt", true, Encoding.Default)) // создание обьект потока для записи файла
            {
                //System.Text.Encoding.Default
                // sw.Write("\t\n");
                sw.Write($"{tempDateTime}" + "\t\n");
                sw.Write(text);
                sw.Write("\t\n");

            }
           

        }

        /// <summary>
        /// рандомнон заполнение текстого файла набором цифр
        /// </summary>
        public static void RandomZapisFailaInt()
        {
          lock  (loker)
            {

            DateTime now = DateTime.Now; // получение тек времени
            string text = $"Содержимое файла: \t\nДобавлено:{now} ";
            Random random = new Random();

            for (int i =0; i<1000; i++)
            {
                text += random.Next(10000);
                text += "\t\n";
            }

            ZapisFailaText(text);

            } // обьект локер - Семофор для потоков. Блокирует достут множества потоков одновременно

            Console.WriteLine("Работа цикла по заполнению значениями закончена");
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
        /// чтение файла с указанием пути.
        /// </summary>
        /// <param name="Path"></param>
        public static void ChteniefailaFailaPath(string Path)
        {
            string tempLog = "Log.txt";
            string tempText = "Содержимое файла \t\n";

            using (var sr = new StreamReader(tempLog, Encoding.Unicode)) // обьект для чтение потока при чтении файла с жестого диска  
            {
                //Encoding.Default
                // var text = sr.ReadLine().ToString();  // чтение построчно      
                tempText += sr.ReadToEnd().ToString(); // чтение файла полностью
            }
            Console.WriteLine(tempText); //проверочный вывод
            Console.ReadKey(true);
        }



        //Работа с потоками
        //Многопоточность. Работа с потоками(тред)
        //Параленьное программирование Вычисление на основе нескольких ядрах процессерах

        /// <summary>
        /// метод для опкатки многопотосности
        /// </summary>
        public static void DoWork()
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                Console.WriteLine($"Текущее значение = {i} из {int.MaxValue}");

            }
           
        }
       
        /// <summary>
        /// метод для откатки многопотосности
        /// </summary>
        /// <param name="max"></param>
        public static void DoWorkTest(object max)
        {
            int maxx = (int)max;
            
            for (int i = 0; i < maxx; i++)
            {
                if (i % 100 ==0)
                {
                    Console.WriteLine($"Поток№2_\t\nВходящее значение={max} \t\nЗначение от остатка от деления = {i}");
                }

                // Console.WriteLine($"Текущее значение = {i} из {maxx}");
               
            }
            Console.ReadKey(true);
        }

        //семофор для потоков и асинхронных функций
        
        public static object loker = new object(); // обьект синхронизаций


    } // конец класса

}
