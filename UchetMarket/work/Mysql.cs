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
            // обьект для  подключение к БД
            MySqlConnection connection = new MySqlConnection();
            try
            {

                //Параметры подключения
                MyConnection.Server = "127.0.0.1";   // Имя сервера где нахоится БД
                MyConnection.Database = "VK"; // имя БД
                MyConnection.UserID = "root";   //Имя подлючения БД  
                MyConnection.Password = ""; // пароль к БД

                // обьект для  подключение к БД
                // MySqlConnection connection = new MySqlConnection();
                // В обьект для соединения с БД передаем параметры подключения к БД
                connection.ConnectionString = MyConnection.ConnectionString;

                // запуск соединения
                connection.Open();

            }
            catch (Exception ex)
            {
                ZapisfailaBD("Ошибка при подключении к БД \t\n" + ex);
            }

            // отправляем(возвращаем обьект из метода) обьект типа connection. 
            return connection;
        }


        public static string TekDateTime()
        {
            DateTime dateTime = new DateTime();

            string ff = DateTime.Now.ToString();

            return ff;
        }
        //ПРОБНЫЙ метод
        public static string Test()
        {
            MySqlConnection conn = Connection();
            // var coo = Connection();

            //Тестовой запрос
            string sql = "SELECT * FROM Shop WHERE id = 2";
            // string sql = "SELECT * FROM Shop WHERE Count = 5";
            // string sql = "SELECT * FROM Shop";

            //  обьект для отправки команды к БД
            MySqlCommand command = new MySqlCommand(sql, conn);

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
        ///обновление страници без параметров        /// </summary>
        /// <returns></returns>
        public static List<string> UpdateTable()
        {
            MySqlConnection conn = Connection();

            // запрос к БД
            string sql = "SELECT * FROM Shop";

            //  обьект для отправки команды к БД
            MySqlCommand command = new MySqlCommand(sql, conn);

            // обьект для прочтение ответа и БД на запрос
            MySqlDataReader reader = command.ExecuteReader();

            string test = " ";
            List<string> dataList = new List<string>();

            // прочитаем полученные данные
            while (reader.Read())
            {
                // записываем.
                dataList.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " +
                    reader[3].ToString() + ", " + reader[4].ToString() + ", " + reader[4].ToString() + ", ");

                //получаем нужный  столбец
                //test += reader["Id"].ToString() + ":" + reader[1].ToString()+ Environment.NewLine;
                test += reader["Id"].ToString() + ":" + reader[1].ToString() + " в наличии:" + reader["Count"].ToString() + " Дата прихода:" + reader["DateTime"].ToString() + Environment.NewLine;
                test += "\n";
            }

            reader.Close(); // закрываем подключение читалки
            conn.Close(); // закрываем подключение к БДЫ

            return dataList;
        }

        /// <summary>
        /// запрос к БД с параметрами.Количество строк изБД 
        /// </summary>
        /// <returns></returns>
        public static List<string> UpdateTable(int countRows)
        {
            MySqlConnection conn = Connection();

            // запрос к БД
            string sql = "SELECT * FROM Shop";

            //  обьект для отправки команды к БД
            MySqlCommand command = new MySqlCommand(sql, conn);

            // обьект для прочтение ответа и БД на запрос
            MySqlDataReader reader = command.ExecuteReader();

            int Rows = 0;

            // записываем в лист полученные данные о товаре в коллекцию лист
            List<string> dataList = new List<string>();

            // прочитаем полученные данные
            while (reader.Read())
            {

                if (Rows == countRows) // проверка на количество строк запрошенным пользователем
                {
                    // записываем запрос из БД 

                    break; // выйдем из цикла
                }
                dataList.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " +
                reader[3].ToString() + ", " + reader[4].ToString() + ", " + reader[5].ToString() + ", " + reader[6].ToString());

                Rows++;
                
            }


            reader.Close(); // закрываем подключение читалки
            conn.Close(); // закрываем подключение к БД

            return dataList;
        }

        /// <summary>
        /// Получение количество всех id в базе
        /// </summary>
        /// <returns></returns>
        public static int zaprosID()
        {
            MySqlConnection conn = Connection();

            // запрос к БД
            string sql = "SELECT Id FROM Shop";

            //  обьект для отправки команды к БД
            MySqlCommand command = new MySqlCommand(sql, conn);

            // обьект для прочтение ответа и БД на запрос
            MySqlDataReader reader = command.ExecuteReader();

            int countIdd = 0; 
           // countIdd = Convert.ToInt32(sql);

            // цикл прочитает весь обьект 
            while (reader.Read())
            {
                countIdd = (int)reader[0];
            }
            
            return countIdd;
        }

    
        /// <summary>
        /// Добавить в БД.
        /// </summary>
        public static bool addTover(int id, string tovar ,int Count, string opisanieTover, string commeti)
        {
            Random random = new Random();
            int topTover = random.Next(20);
            string tekDateTime = DateTime.Now.ToString();
            bool rez = true;

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

                rez = false;
            }
            finally
            {
                conn.Close();
            }
            return rez;
        }

        //Заисать текст в файл
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
