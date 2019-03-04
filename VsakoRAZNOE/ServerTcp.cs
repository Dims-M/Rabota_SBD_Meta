using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace VsakoRAZNOE
{
    /// <summary>
    /// Сервер с протоколом передачи Tcp
    /// </summary>
    class ServerTcp
    {
        
         /// <summary>
         /// 
         /// </summary>
        public static void ZapuskServera()
        {
            const string ip = "127.0.0.1";
            const int port = 8080;

            string textLog = "";
            DateTime dateTime = DateTime.Now; // получение текущей даты

            // обьект для обьединения ip адреса и порта. сетевую конечную точку в виде IP-адреса
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            //Cocket. В качестве параметра передаем Тип и схема подключения для сокета((используется ip 4 версии)). Тип самого сокета(выб поток) Потом пип конкретного протокола 
            var tcpSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            // Связывание сокета с настройками(какой ip и порт слушать).
            tcpSocket.Bind(tcpEndPoint);

            // запуск сокета на прошлушку порта.В качестве параметров указываем количество подключений клиентов
            tcpSocket.Listen(5);


            // процесс прошлушивания порта
            textLog = $"{dateTime}\t\n Запуск службы прошлушивания IP{ip} И Potr{port}";

            Console.WriteLine($"Запуск службы прошлушивания IP{ip} И Potr{port}");

            while (true)
            {
                // создает новый сокет для каждого нового подключения
                var listener = tcpSocket.Accept();

                //бефер для подключения.  данные из 2 сокетов.(клиента и сокета) хранятся и передаются в байтовым видом 
                var buffer = new byte[256]; // хранение данных полученные из сокета
                var size = 0; // реальное количество байт
                var data = new StringBuilder(); // Изменяеммая строка. 

                do // цикл с пост условием.
                {
                    size = listener.Receive(buffer); // получаем данные из сокета.
                    data.Append(Encoding.UTF8.GetString(buffer,0,size)); // добавляем в строку данные из буфера с указанной кодировкой

                } while (listener.Available >0); // Проверяем что полученное значение больше 0

                Console.WriteLine($"Тест{data}");
            }

            //Console.WriteLine("");
        }


    }
}
