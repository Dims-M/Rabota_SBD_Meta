using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientTcp
{
    /// <summary>
    /// Клиент по отправки сообщений по протоколу Tpc
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ZapuskatorClient();
        }

       static void ZapuskatorClient()
        {
            const string ip = "127.0.0.1";
            const int port = 8090;

            string textLog = "Лог событий \t\n";

            // обьект для обьединения ip адреса и порта. сетевую конечную точку в виде IP-адреса
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            //Cocket. В качестве параметра передаем Тип и схема подключения для сокета((используется ip 4 версии)). Тип самого сокета(выб поток) Потом пип конкретного протокола 
            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            textLog += $"{NewDateTime()} \t\nСоздание сокета на подключение";

            Console.WriteLine("ВВедите сообщение:");
            var message = Console.ReadLine();
            textLog += $"\t\n{NewDateTime()} Былоо введено сообщение на отправку \t\n {message.ToString()}"; // логирование

            var data = Encoding.UTF8.GetBytes(message); // кодирование сообщение в поток байтов.

            // открываем сокет для соединения с сервером и отправкой сообщения
            // создаем сокет с параметрами
            tcpSocket.Connect(tcpEndPoint);

            tcpSocket.Send(data); // отправка сообщения к серверу
            textLog += $"\t\n{NewDateTime()}Сообщение отправленно...";

            // получение ответа после отправки сообщения

            //бефер для подключения.  данные из 2 сокетов.(клиента и сокета) хранятся и передаются в байтовым видом 
            var buffer = new byte[256]; // хранение данных полученные из сокета
            var size = 0; // реальное количество байт
            var answer = new StringBuilder(); // Изменяеммая строка.

            do // цикл с пост условием.
            {
                size = tcpSocket.Receive(buffer); // получаем данные из сокета.
                answer.Append(Encoding.UTF8.GetString(buffer, 0, size)); // добавляем в строку данные из буфера с указанной кодировкой

            }
            while (tcpSocket.Available > 0); // Проверяем что полученное значение больше 0

            Console.WriteLine(answer.ToString());

           // tcpSocket.Shutdown(SocketShutdown.Both); // отключение сокета
           // tcpSocket.Close(); // закрытие сокета и освобождение ресурсов

            ZapisFailaText(textLog); // запись лога в файл
            Console.ReadLine();
            tcpSocket.Shutdown(SocketShutdown.Both); // отключение сокета
            tcpSocket.Close(); // закрытие сокета и освобождение ресурсов

        }

        /// <summary>
        /// Запускатор клиента UDP
        /// </summary>
      static void  ZapuskatorClientUDP()
        {
            const string ip = "127.0.0.1";
            //const string ip = "192.168.1.189";
            const int port = 8091;

            //string textLog = ""; // строка для лога. Тут не используется

            // обьект для обьединения ip адреса и порта. сетевую конечную точку в виде IP-адреса
            var udpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            //Cocket. В качестве параметра передаем Тип и схема подключения для сокета((используется ip 4 версии)). Тип самого сокета(выб поток) Потом пип конкретного протокола 
            var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            // создание сокета 
            udpSocket.Bind(udpEndPoint);

            while (true)
            {
                Console.WriteLine("Введите сообщение ");
                var message = Console.ReadLine();

                var serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8091);

                // отправлем сообщение в байтовом виде на конкретный  ip и порт
                udpSocket.SendTo(Encoding.UTF8.GetBytes(message), serverEndPoint);


                var buffer = new byte[256]; // хранение данных полученные из сокета
                var size = 0; // реальное количество байт
                var data = new StringBuilder(); // Изменяеммая строка. 
                // Сохранение адреса подключение Адресс клиента
               // EndPoint senderEndPoint = new IPEndPoint(IPAddress.Any, 0);
                EndPoint senderEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8091);

                do
                {

                    size = udpSocket.ReceiveFrom(buffer, ref senderEndPoint);
                    data.Append(Encoding.UTF8.GetString(buffer)); // добавляем в строку полученные данные из буфера
                }
                while (udpSocket.Available > 0); // пока данные есть. Цикл будет работать

                Console.WriteLine(data);
                Console.ReadLine();

            }




        }

        /// <summary>
        /// получение текущей даты
        /// </summary>
        /// <returns></returns>
        static string NewDateTime()
        {
            DateTime dateTime = DateTime.Now; // получение текущей даты
            return dateTime.ToString();
        }


        /// <summary>
        /// Запись текстового файла. В файл логирования по умолчанию
        /// </summary>
        /// <param name="text"></param>
       static void ZapisFailaText(string text)
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

    }
}
