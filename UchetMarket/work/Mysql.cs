using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UchetMarket.work
{
    /// <summary>
    /// Класс для соеденения и работы с БД
    /// </summary>
   public class Mysql
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


        public static string TekDateTime()
        {
            DateTime dateTime = new DateTime();

            string ff = DateTime.Now.ToString();

            return ff;
        }

        public static string Test()
        {
            MySqlConnection conn = Connection();
            // var coo = Connection();

            //Тестовой запрос
            string sql = "SELECT * FROM Shop WHERE id = 2";
           // string sql = "SELECT * FROM Shop WHERE Count = 5";
            // string sql = "SELECT * FROM Shop";

            //  обьект для отправки команды к БД
            MySqlCommand command = new MySqlCommand(sql,conn);

            // обьект для прочтение ответа и БД на запрос
            MySqlDataReader reader = command.ExecuteReader();

            string test = "";
            int countTable = 0;
            // прочитаем полученные данные
            while (reader.Read())
            {

                //первыц столбец
                // test += reader[0].ToString();
                test += reader[countTable].ToString();
                test += "\t\n";
                //countTable =+1;
            }

            reader.Close(); // закрываем подключение читалки
            conn.Close(); // закрываем подключение к БДЫ

            return test;
        }

        /// <summary>
        /// Добавить в БД.
        /// </summary>
        public static void addTover(int id, string tovar ,int Count, string opisanieTover, string commeti)
        {
            Random random = new Random();
            int topTover = random.Next(20);
            string tekDateTime = DateTime.Now.ToString();

            // обьект для подключения к БД Получаем доступ к бд.
            MySqlConnection conn = Connection();

            try
            {
   
            // отправляем команду для добавления в БД
           // string sql = "INSERT INTO Shop(Id,Tover,COUNT,DATETIME,Top,OpisanieTovara,COMMENT)VALUES ('10','Пробное добавление ','23','06.02.2019','1','Пробное добавление товара','Пробное добавление товара через форму');";
            string sql = $"INSERT INTO Shop(Id,Tover,COUNT,DATETIME,Top,OpisanieTovara,COMMENT)VALUES ('{id}','{tovar}','{Count}','{tekDateTime}','{topTover}','{opisanieTover}','{commeti}');";
            // string sql = "SELECT * FROM Shop";
           
            //  обьект для отправки команды к БД
            MySqlCommand command = new MySqlCommand(sql, conn);

            // обьект для прочтение ответа и БД на запрос
            MySqlDataReader reader = command.ExecuteReader();

                ZapisfailaBD(sql); // запись в лог
                conn.Close(); // закрываем подключение к БД
            }
            catch (Exception ex)
            {
                string errorText = $"{DateTime.Now.ToString()}\t\nПроизошла ошибка при добавлении товара в БД \t\n"+ex;
                MessageBox.Show(errorText);
                ZapisfailaBD(errorText);
            }
            finally
            {
                conn.Close();
            }
          
        }

        public static void ZapisfailaBD(string stroka)
        {
            string path = "Log.txt";
            string tempStrokaZapis = "****** \t\n";
            string dateTimes = DateTime.Now.ToString();
            tempStrokaZapis += dateTimes += "\t\n";
            tempStrokaZapis += stroka+="\t\n******";

            try
            {
                // поток для записи файла.// В качестве параметров указываем путь к сохр. true это перезапись, и кодировка
                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(tempStrokaZapis);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при записи файла: \t\n" +
                                "******** \t\n "+ex+ "\t\n *********");
            }

        }
    }
}
