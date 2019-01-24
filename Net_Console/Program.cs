using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Net_Console
{
    class Program
    {
      static  RabotaIP RabotaIP = new RabotaIP();

        static void Main(string[] args)
        {
            // узнат IP по доменным именам
            //RabotaIP.UznatAdress("www.microsoft.com");
            // RabotaIP.UznatAdress("lk.platformaofd.ru");
            // RabotaIP.UznatAdress("google.com");

            // получение ip компа
            // RabotaIP.MyIp();

            // загрузка файла
            // RabotaIP.DownloadFileSite();

            // загрузка текстового файла. Вывод на консоль, сохранение на диск
            // RabotaIP.DownloadFileSiteStreem();

            //асинронная закачка файла
            RabotaIP.DownloadFileSiteAsync();

        }



    }
    /// <summary>
    /// Кдасс для работы с ip адресами
    /// </summary>
    class RabotaIP
    {
        /// <summary>
        /// Тестовой метод работы с IP адресами
        /// </summary>
        public void MyIp()
        {
            Console.WriteLine("Тестовой метод работы с IP адресами \t\n");

            string NameComp = "Имя текущего компа \t\n";
            string MyIpComp = "IP текущего компа \t\n";

            //IPAddress myIp =  IPAddress.Parse("127.0.0.1");
            IPAddress myIp = IPAddress.Loopback;
            IPAddress myIp1 = IPAddress.Broadcast;

            Console.WriteLine(myIp); //получение ip "127.0.0.1"
            Console.WriteLine(myIp1); // маска 255

            string host = Dns.GetHostName(); // имя текущего компа
            NameComp += Dns.GetHostName(); // имя текущего компа
            MyIpComp += Dns.GetHostByName(host).AddressList[0]; // получение ip компа

            Console.WriteLine(NameComp + MyIpComp);

            Console.ReadKey(true);
        }

        /// <summary>
        /// Получить числовой адресс IP сайта
        /// </summary>
        /// <param name="adressIp"></param>
        public void UznatAdress(string adressIp)
        {
            string tempIP = "Список IP \t\n";
            // IPHostEntry host1 = Dns.GetHostEntry("www.microsoft.com");

            IPHostEntry host1 = Dns.GetHostEntry(adressIp);

            Console.WriteLine(host1.HostName); // вывод контейнера с ip

            // в цикле пройдемся по контейнеру с ip
            foreach (IPAddress myIp in host1.AddressList)
            {
                tempIP += myIp.ToString() + "\t\n";

            }

            Console.WriteLine(tempIP);
            Console.ReadKey(true);
        }


        public void DownloadFileSite()
        {

            string pach = "http://komotoz.ru/kartinki/images/prikolnye_kartinki_s_pyatnicej/prikolnye_kartinki_s_pyatnicej_03.jpg";
            string name = "prikolnye_kartinki_s_pyatnicej_03.jpg";

            WebClient client = new WebClient();
            client.DownloadFile(pach, name);

            Console.WriteLine("Файл загружен в папку с программой");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Поток для скачивания файла и вывода на кансоль.
        /// </summary>
        public void DownloadFileSiteStreem()
        {
            //обьект для работы с сайтами(запросы ответы)
            WebClient client = new WebClient();

            string pathFail = "https://knigogo.net/wp-content/uploads/2018/01/Tarmashev_S._Tma3._Zakat_Tmyi.txt";

            Console.WriteLine("Происходит попытка скачивания файла. ");

            // поток стрим для загрузки с сайта
            using (Stream stream = client.OpenRead(pathFail))
            {
                // поток для чтения с последущим выводом в консоль
                using (StreamReader reader = new StreamReader(stream, System.Text.Encoding.Default))
                {
                    string line = ""; // записываем построчно в переменную. Пока не закончится поток
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    
                }
                client.DownloadFile(pathFail, "Tarmashev_S._Tma3._Zakat_Tmyi.txt");
                Console.WriteLine("Файл загружен");
            }
            Console.WriteLine("*******************************");

            //Console.ReadRe(true);
            Console.ReadKey(true);
        }
       
        /// <summary>
        /// Асинхронная скачка файла
        /// </summary>
        public static async Task DownloadFileSiteAsync()
        {
            Console.WriteLine("Попытка осинхронная скачка файла");
            string pathFail = "https://knigogo.net/wp-content/uploads/2018/01/Tarmashev_S._Tma3._Zakat_Tmyi.txt";

            DateTime now = DateTime.Now;
            string dateTek = now.ToString();
            WebClient client = new WebClient();
            await client.DownloadFileTaskAsync(new Uri(pathFail), $"mytxtFile.txt{dateTek}");

            Console.ReadKey(true);
        }

    }
}
