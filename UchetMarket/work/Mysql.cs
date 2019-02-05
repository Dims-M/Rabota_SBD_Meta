using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UchetMarket.work
{
    /// <summary>
    /// Класс для соеденения и работы с БД
    /// </summary>
    class Mysql
    {
        /// <summary>
        /// Подключение к БД 
        /// </summary>
        /// <returns></returns>
        private static MySqlConnection Connection()
        {
            // обьект для работы с БД. Соединения и т. д.
            MySqlConnectionStringBuilder MyConnection = new MySqlConnectionStringBuilder();

            //Параметры подключения
            MyConnection.Server = "127.0.0.1";   // Имя сервера где нахоится БД
            MyConnection.Database = "VK"; // имя БД
            MyConnection.UserID = "root";   //Имя подлючения БД  
            MyConnection.Password = ""; // пароль к БД

            // обьект для  подключение к БД
            MySqlConnection connection = new MySqlConnection();
            // В обьект для соединения с БД передаем параметры подключения к БД
            connection.ConnectionString = MyConnection.ConnectionString;

            // запуск соединения
            connection.Open();

            // отправляем обьект типа connection. 
            return connection;

        }


        public static string Test()
        {
            MySqlConnection conn = Connection();
            // var coo = Connection();

            //Тестовой запрос
           string sql = "SELECT * FROM Shop WHERE id = 2";
           // string sql = "SELECT * FROM Shop";

            //  обьект для отправки команды к БД
            MySqlCommand command = new MySqlCommand(sql,conn);

            // обьект для прочтение ответа и БД на запрос
            MySqlDataReader reader = command.ExecuteReader();

            string test = "";

            // прочитаем полученные данные
            while (reader.Read())
            {
                //первыц столбец
                test += reader[0].ToString();
               // test += "\t\n";
            }

            reader.Close(); // закрываем подключение читалки
            conn.Close(); // закрываем подключение к БДЫ

            return test;
        }


        public void addTover()
        {
            MySqlConnection conn = Connection();
            // var coo = Connection();

            //Тестовой запрос
            string sql = "SELECT * FROM Shop WHERE id = 2";
            // string sql = "SELECT * FROM Shop";

            //  обьект для отправки команды к БД
            MySqlCommand command = new MySqlCommand(sql, conn);

            // обьект для прочтение ответа и БД на запрос
            MySqlDataReader reader = command.ExecuteReader();

            string test = "";

            // прочитаем полученные данные
            while (reader.Read())
            {
                //первыц столбец
                test += reader[0].ToString();
                // test += "\t\n";
            }

            reader.Close(); // закрываем подключение читалки
            conn.Close(); // закрываем подключение к БД
        }


    }
}
