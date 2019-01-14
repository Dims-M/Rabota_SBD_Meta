using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Rab_BD_Code_FirstV2.AutoCodeSecond;

namespace Rab_BD_Code_FirstV2
{
    class Program
    {
        static void Main(string[] args)
        {
            vividBD();
            //AddBD(); // добавление в БД
            AddBDParams("111Test", "5555100500");
            vividBD();
           
        }

        static public void vividBD()
        {
            Console.WriteLine("***");
            using(UserContext db = new UserContext())
                {

                foreach (User u in db.Users) {  
                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
                        }
                Console.WriteLine("***");
            }
            
            Console.ReadKey(true);
        }

     static public void AddBD()
        {
            Console.WriteLine("Добавление инфы в БД");
            // обьект для работы и конекта к Бд. 
            // Обьект типа  Класс для свзяки БД и Клаассов в коде
            UserContext context = new UserContext();

            //Добавление инфы в БД.
            context.Users.Add(
                // создаем обьект Типа узер(имя Таблицы )
            new User { Name = "Alex", Age = "26" });
           
            // Сохраняем изменения в контексте
            context.SaveChanges();
        }

        /// <summary>
        /// Добавление в БД с  параметрами.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static public void AddBDParams(string name, string age)
        {
            Console.WriteLine("Добавление инфы в БД");
            // обьект для работы и конекта к Бд. 
            // Обьект типа  Класс для свзяки БД и Клаассов в коде
            UserContext context = new UserContext();

            //Добавление инфы в БД.
            context.Users.Add(
            // создаем обьект Типа узер(имя Таблицы )
            new User { Name = $"{name}, Age = {name}" });

            // Сохраняем изменения в контексте
            // Если этого не сделать, то предыдущие строки не имеют смысла, т.к
            // в базу ничего не запишется.
                context.SaveChanges();
        }


    }
}
