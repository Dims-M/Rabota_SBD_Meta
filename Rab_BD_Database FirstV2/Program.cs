using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rab_BD_Database_FirstV2
{
    /// <summary>
    /// Работа с БД по методу  Model First
    /// </summary>
    class Program
    {

        // Переменные
       static string tempBD;

        static void Main(string[] args)
        {
            // VivodDateBD();
            // AddDateBD();
            /// VivodDateBD();
            /// 
            VivodDateNiTable("sgtvvre");
        }

        /// <summary>
        /// Вывод данных из БД
        /// </summary>
        static void VivodDateBD()
        {
            
            // создание обьекта контекста, для доступа 
            using(UserContainer bd = new UserContainer())
            {
                tempBD += "Содержимое БД \t\n";
                // ссылка к таблице БД
                var users = bd.UserSet;

                // в цикле пройдем по таблицам БД
                foreach(User u in users)
                {
                    tempBD += $"ID Клиента:{u.Id} \t\n" +
                              $"Имя Клиента:{u.Name} \t\n" +
                              $"Возраст Клиента:{u.Age} \t\n" +
                              $"Адресс Клиента:{u.Adress} \t\n" +
                              $"PKI Клиента:{u.PKI} \t\n" +
                              $"Коментарии Клиента: {u.Coment}\t\n";
                }

                Console.WriteLine(tempBD);
                Console.ReadKey(true);
            }
 
        }

        static void VivodDateNiTable(string nameTableBD)
        {

            using (UserContainer bd = new UserContainer())
            {
                //UserContainer bd = new UserContainer().UserSet();
                tempBD += "Содержимое БД \t\n";

                // значь по умолчанию.
                var users = bd.UserSet;

               

                if (nameTableBD == "UserSet")
                {

                    // ссылка к таблице БД
                    users = bd.UserSet;
                }
                else
                {
                    // другая ссылка к таблице БД
                    Console.WriteLine("Подключение к др. БД");
                    var usr = bd.PhoneSet;
                }

                // в цикле пройдем по таблицам БД
                foreach (User u in users)
                {
                    tempBD += $"ID Клиента:{u.Id} \t\n" +
                              $"Имя Клиента:{u.Name} \t\n" +
                              $"Возраст Клиента:{u.Age} \t\n" +
                              $"Адресс Клиента:{u.Adress} \t\n" +
                              $"PKI Клиента:{u.PKI} \t\n" +
                              $"Коментарии Клиента: {u.Coment}\t\n";
                }



                Console.WriteLine(tempBD);
                Console.ReadKey(true);

            }
        }
      
        
        
        /// <summary>
        /// Добавление в базу Данных
        /// </summary>
        static void AddDateBD()
        {
            // обьект для подключения и работы с бд
            using (UserContainer bd = new UserContainer())
            {
               
                // добавление новой строки в таблицу БД
               // bd.UserSet.Add(new User { Name = "Hec", Age = "25", Adress ="Rfpfym",PKI="1",Coment = "Первохах" } );
                bd.UserSet.Add(new User { Name = "хрен gjl горой", Age = "15", Adress ="й3ч3",PKI= RandomPki(), Coment = "хах" } );

                // сохранение изменений в Бд
                bd.SaveChanges();

            }
        }

        /// <summary>
        /// Получение рандомного числа
        /// </summary>
        /// <returns></returns>
        static string RandomPki()
        {
            Random random = new Random();
            string randomStr = random.Next(10000*1000).ToString();
            return randomStr;
        }


    }
}
