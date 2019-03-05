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
         /// Запуск сервера TCP подключений
         /// </summary>
        public  void ZapuskServera()
        {
            const string ip = "127.0.0.1";
            //const string ip = "192.168.1.189";
            const int port = 8090;

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
            textLog = $"{dateTime}\t\nЗапуск службы прошлушивания IP{ip} И Potr{port}";

            Console.WriteLine($"\t\nЗапуск службы прошлушивания IP{ip} И Potr{port}");

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

                Console.WriteLine($"{data}"); //TODO строку

                // отправка ответа 
                listener.Send(Encoding.UTF8.GetBytes("\t\n Соединение установленно!")); // отправление байтов 
                textLog += $"\n{dateTime}: Успех! \t\n Соединение установленно!"; // запись в лог

                listener.Shutdown(SocketShutdown.Both); // закрываем соединение сокета у клиента и у сервера

                listener.Close(); // закрытие и освобождение ресурсов сокета

                textLog += $"\t\n{TekDateTime()}:Закрытие соединения";

                RabFail.ZapisFailaText(textLog); // запись лога в файл


            }

            //Console.WriteLine("");
        }

        /// <summary>
        /// Запуск Udp сервера c сокетами
        /// </summary>
       public void Zapusk_UDP_Servera()
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

            // создает новый прошлушиватель для каждого нового подключения
            var listener = udpSocket.Accept();

            //бефер для подключения.  данные из 2 сокетов.(клиента и сокета) хранятся и передаются в байтовым видом 
            var buffer = new byte[256]; // хранение данных полученные из сокета
            var size = 0; // реальное количество байт
            var data = new StringBuilder(); // Изменяеммая строка. 
             // Сохранение адреса подключение Адресс клиента
            EndPoint senderEndPoint = new IPEndPoint(IPAddress.Any, 0);

            do
            {
               
                size = udpSocket.ReceiveFrom(buffer, ref senderEndPoint);
                data.Append(Encoding.UTF8.GetString(buffer)); // добавляем в строку полученные данные из буфера
            }
            while (udpSocket.Available >0); // пока данные есть. Цикл будет работать
            // отправляеем сообщение подключившемся к нам сокету
            udpSocket.SendTo(Encoding.UTF8.GetBytes("Сообщение полученно."), senderEndPoint);
          
            // udpSocket.Shutdown();
            Console.WriteLine(data);

            
        }

        public  string TekDateTime()
        {
            DateTime dateTime = DateTime.Now; // получение текущей даты
            return dateTime.ToString();
        }


    }
}
