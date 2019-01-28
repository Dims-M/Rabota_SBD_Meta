using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Net_Console
{
    /// <summary>
    /// Работо с ФТП. Отправка и получение файлов с ФТП
    /// </summary>
    class Rabota_FTP
    {

        /// <summary>
        /// получаем txt файл с фтп
        /// </summary>
        public void LoadFailFTP()
        {
            string pathFile = @"http://tesftpmail.ucoz.net/ofd.txt";

            // обьект для работы с запросам к серверу(фтп)
            WebRequest request = WebRequest.Create(pathFile);

            // работа с ответами от сервера.
            WebResponse response = request.GetResponse();



        }

        /// <summary>
        /// Загрузка файла с фтп и сохранение на комп
        /// </summary>
        public void DownloadFile()
        {
            string pathFile = $"http://tesftpmail.ucoz.net/ofd.txt";

            string tekst = " ";

            string nameFail = TekDateTime();
            nameFail += "_.txt";

            // обьект для работы с запросом к клиенту
            WebClient client = new WebClient();


          
          //Основной поток для подключение к файла с фтп.
            using (Stream stream = client.OpenRead(pathFile))
            {
                // поток типаStreamReader  для считывания и чтения текстовых файла с фтп
                using (StreamReader reader = new StreamReader(stream, Encoding.Default))
                {
                    string line = "";
                    
                    while ((line = reader.ReadLine()) != null)
                    {
                        tekst += line; // для сохранения в файл.
                        // вывод на консоль
                        Console.WriteLine(line);
                        tekst += "\n";
                    }
                }

                //*****************
                string dateTimeV = TekDateTime();
                string dateTime = @""+dateTimeV+"test.txt";
              
               
                // поток для записи из текс поля в файл. 
                using (StreamWriter sw = new StreamWriter("test.txt", false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(tekst);
                }

            } // конец основного потока

            Console.WriteLine("Файл загружен");
            Console.Read();


        }

        public string TekDateTime()
        {
            string dateTimeStr = "";
           // DateTime dateTime = new DateTime();
            dateTimeStr = DateTime.Now.ToString(("hh:mm:ss"));
            return dateTimeStr;
        }

    }
}
