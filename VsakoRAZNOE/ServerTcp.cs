using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VsakoRAZNOE
{
    /// <summary>
    /// Сервер с протоколом передачи Tcp
    /// </summary>
    class ServerTcp
    {
        
    
        public static void ZapuskServera()
        {
            const string ip = "127.0.0.1";
            const int port = 8080;

            // обьект дляобьединения ip адреса и порта
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

        }


    }
}
