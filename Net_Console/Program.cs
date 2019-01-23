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
           //RabotaIP.UznatAdress("www.microsoft.com");
           RabotaIP.UznatAdress("lk.platformaofd.ru");
        }



    }
    /// <summary>
    /// Кдасс для работы с ip адресами
    /// </summary>
    class RabotaIP
    {

        public void MyIp()
        {

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
