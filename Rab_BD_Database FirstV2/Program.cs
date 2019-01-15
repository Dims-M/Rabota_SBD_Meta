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
            /// 
            ///*****Подключение , добавление товаров в с помощью методов с парметрами таблиц
           // AddDateBDInTable("123");
            //VivodDateNiTable("UserSet");
            // AddDateBDInTable("UserSet");
            //VivodDateNiTable("UserSet");
            //*
            //VivodDateNiTable("PhoneSet"); //Вывод талицы
            // AddDateBDInTable("PhoneSet"); // Добавление в БД

            AddDatePhoneTable("Хрень моржовая","10050","Вигня необыкновенная");
            VivodDateNiTable("PhoneSet");
            ///******
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
      
        
        /// <summary>
        /// Вывод из таблицы с указанием нужной таблици 
        /// </summary>
        /// <param name="nameTableBD"></param>
        static void VivodDateNiTable(string nameTableBD)
        {

            try
            {
                UserContainer bd = new UserContainer();
               // UserContainerP bdPhone = new UserContainerP();

            
                //UserContainer bd = new UserContainer().UserSet();
               tempBD += "Содержимое БД \t\n";

                // значь по умолчанию.
                // var users = bd.UserSet;

                if (nameTableBD == "UserSet")
                {

                    // ссылка к таблице БД
                    var users = bd.UserSet;
                }

                if(nameTableBD == "PhoneSet")
                {
      
                    // другая ссылка к таблице БД
                    Console.WriteLine("Подключение к др. БД");
                   // var usersP = bdPhone.PhoneSet;
                    var usersP = bd.PhoneSet;

                    foreach (Phone u in usersP)
                    {
                        tempBD +=   $"ID телефона:{u.Id} \t\n" +
                                     $"Название телефона:{u.NameT} \t\n" +
                                     $"Цена:{u.Price} \t\n" +
                                     $"Описание телефона:{u.Opisanie} \t\n";
                    }
                }


                else
                {
                    Console.WriteLine("Подключение к БД Не удалось.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка "+ex);
            }

                Console.WriteLine(tempBD);
                Console.ReadKey(true);

            Console.ReadKey(true);
        }



        /// <summary>
        /// Добавление в БД с параметрами выбора таблиц
        /// </summary>
        /// <param name="nameTableBD"></param>
        static void AddDateBDInTable(string nameTableBD)
        {
            UserContainer bd = new UserContainer();
            UserContainerP bdPone = new UserContainerP();

            try
            {
                // проверка 
              if(nameTableBD == "UserSet")
                {

                // добавление новой строки в таблицу БД
                // bd.UserSet.Add(new User { Name = "Hec", Age = "25", Adress ="Rfpfym",PKI="1",Coment = "Первохах" } );
                bd.UserSet.Add(new User { Name = "dcwfw", Age = "10000", Adress = "vdfsrar", PKI = RandomPki(), Coment = "Ghjgstgete4v" });
            }

                if (nameTableBD == "PhoneSet")
                {
                    Console.WriteLine("Попытка подключения к БД PhoneSet");
                    // добавление новой строки в таблицу БД
                    bd.PhoneSet.Add( new Phone { NameT= "Проверочный", Price= "100",Opisanie = "Проверочное описание для теста базы" } );
                }

                else
                {
                    Console.WriteLine("Что то пошло не так. \n Проверте правильность написания название БД");
                }

                }
            catch (Exception ex)
            {
                Console.WriteLine("Что то пошло не так. \n"+ex);
            }

                // сохранение изменений в Бд
                bd.SaveChanges();

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
        /// Метод добавления в таблицу Телефоны с праметрами таблици(имя, цена, описание)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="opisanie"></param>
        static void AddDatePhoneTable(string name, string price, string opisanie)
        {

            using (UserContainerP phone = new UserContainerP())
            {
            // Обьект для добавлении в таблицу в качестве строки
            Phone p1 = new Phone { NameT = name, Price = price, Opisanie = opisanie };

                // Добавление экземпляра класса в качестве строки в таблице
                phone.PhoneSet.Add(p1);

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
