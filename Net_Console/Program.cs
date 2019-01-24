using System;
using System.Collections.Generic;
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

            RabotaIP.MyIp();
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
            IPAddress myIp =  IPAddress.Loopback;
            IPAddress myIp1 =  IPAddress.Broadcast;

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
                tempIP += myIp.ToString()+ "\t\n";

            }

            Console.WriteLine(tempIP);
            Console.ReadKey(true);
        }

    }
}
