using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabotaBD_Database_First
{
    class Program
    {
        static void Main(string[] args)
        {
            VivodT_User();
        }

       static public void VivodT_User()
        {
            // Обьект для доступа к данным таблицам
            userstoredbEntities bd= new userstoredbEntities();

            // обьект получает данные бд
            var users = bd.User;

            // в цикле выводим содержимое бд

            string tempSoderzimoeBD = "В БД содержится \t\n";

            foreach (User u in users)
            {
                //  tempSoderzimoeBD += $"Номер:{u.Id},\t\n" +
                //       $"ИМЯ:{u.Name},\t\n" +
                //      $"Возвраст:{u.Age}\t\n";

                tempSoderzimoeBD += $"Номер: {u.Id}| ИМЯ: {u.Name}| Возвраст:{ u.Age}\n";
            }
            Console.WriteLine(tempSoderzimoeBD);
            Console.ReadKey(true);
        } 



    }
}
