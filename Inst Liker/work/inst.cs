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
   public class inst
    {

        // глобальная переменная для работы с запросами(в инете) к серверу.
        static HttpRequest request = new HttpRequest();
        static RequestParams Params = new RequestParams(); // массив папаметров запросов(логи, пароль, куки и т.д) 
       

        // получение параметров для парсера
        public static string getgetPage()
        {
            request = new HttpRequest(); // обьект для запроса при авторизации
           // string response = request.Get("https://www.instagram.com/accounts/login/ajax/").ToString(); // получаем страницу авторизации место на странице куда вводим логин и пароль
            string response = request.Get("https://www.instagram.com/accounts/login/?source=auth_switcher").ToString(); // получаем страницу авторизации место на странице куда вводим логин и пароль

            return response;


        }

        /// <summary>
        /// парсим ннужные данные со страници авторизации
        /// </summary>
        public static string[] ParsParams()
        {
            string response = getgetPage(); // получение страници

            return new string[] {
            System.Text.RegularExpressions.Regex.Match(response, "rollout_hash\":\"*(.*?)\"" ).Groups[0].Value,   
            System.Text.RegularExpressions.Regex.Match(response, "csrf_token\":\"(.*?)\"").Groups[1].Value,
            }; 
        }

        /// <summary>
        /// Получение страници авторизации
        /// </summary>
        /// <returns></returns>
        public static string Auth(string login, string password)
        {
            string[] Data = ParsParams(); // массив с 2 регулярными выражениями

            Params = new RequestParams();
            request = new HttpRequest(); // обьект для запроса при авторизации

            request.UserAgentRandomize(); // рандомное перевыключение браузера
            request.KeepAlive = true; // устанавливаем постоянное подключение с сервером
            request.Cookies = new CookieStorage(true); // работаем с куками запросами
           
            // Параметры заголовка
            request.AddHeader(HttpHeader.Origin, "https://www.instagram.com"); // 
          //  request.AddHeader("X-Instagram-AJAX", Data[0]);//"rollout_hash":"2cf620f80a88"
            request.AddHeader("X-Instagram-AJAX", $"rollout_hash\":\"ee72defd9231"); //"rollout_hash":"2cf620f80a88"
            request.AddHeader(HttpHeader.ContentType, "application/x-www-form-urlencoded");
            request.AddHeader(HttpHeader.Accept, "*/*");
            request.AddHeader("X-Requested-With", "XMLHttpRequest");
           // request.AddHeader("X-CSRFToken", Data[1]); //936619743392459
            request.AddHeader("X-CSRFToken", "936619743392459"); //936619743392459
            request.AddHeader(HttpHeader.Referer, "https://www.instagram.com/accounts/login/?source=auth_switcher");
            request.AddHeader("Accept-Language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
           // request.AddHeader("", "");
            
            // набор параметров для запроса к страници автоматизации
            // Params["username"] = "+79179037140";
             Params["username"] = login;
             Params["queryParams"] = "{\"source\":\"auth_switcher\"}";
            //  Params["password"] = "d51215045";
              Params["password"] = password;

            // отправляем наши параметры серверу
            string response = request.Post("https://www.instagram.com/accounts/login/ajax/", Params).ToString(); // получаем страницу авторизации место на странице куда вводим логин и пароль

            //string temp = "";

            return response;
        }
    }
}
