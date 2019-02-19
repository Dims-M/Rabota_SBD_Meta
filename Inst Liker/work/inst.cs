using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;
using Newtonsoft.Json.Linq;
using AngleSharp.Html;


namespace Inst_Liker.work
{
   

    /// <summary>
    /// Класс для работы в инстаграмме.
    /// </summary>
    class inst
    {

        // глобальная переменная для работы с запросами(в инете) к серверу.
        static HttpRequest request = new HttpRequest();

        /// <summary>
        /// Получение страници авторизации
        /// </summary>
        /// <returns></returns>
        public static string getPageAuth()
        {
           
            request = new HttpRequest(); // обьект для запроса при авторизации

            string response = request.Get("https://www.instagram.com/accounts/login/?__a=1").ToString(); // получаем страницу авторизации

            string temp = "";

            return temp;
        }
    }
}
