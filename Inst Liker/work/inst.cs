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
        static RequestParams Params = new RequestParams(); // массив папаметров запросов(логи, пароль, куки и т.д) 

        /// <summary>
        /// Получение страници авторизации
        /// </summary>
        /// <returns></returns>
        public static string getPageAuth(string login, string password)
        {
            Params = new RequestParams();
            request = new HttpRequest(); // обьоект для запроса при авторизации

            request.UserAgentRandomize(); // рандомное перевыключение браузера

            request.KeepAlive = true; // устанавливаем постоянное подключение с сервером

            request.Cookies = new CookieStorage(true); // работаем с куками запросами
            
            // набор параметров для запроса к страници автоматизации
            // Params["username"] = "+79179037140";
             Params["username"] = login;
             Params["queryParams"] = "{\"source\":\"auth_switcher\"}";
            //  Params["password"] = "d51215045";
              Params["password"] = password;

            string response = request.Get("https://www.instagram.com/accounts/login/ajax/").ToString(); // получаем страницу авторизации место на странице куда вводим логин и пароль




            string temp = "";

            return temp;
        }
    }
}
