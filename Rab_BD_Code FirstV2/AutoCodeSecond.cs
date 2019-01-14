using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rab_BD_Code_FirstV2
{

/// <summary>
/// Класс для свзяки БД и Клаассов в коде
/// </summary>
    class AutoCodeSecond
    {

       public class UserContext : DbContext
        {
            // конструктор с именем БД
            public UserContext() : base("UserContext")
            { }

            public DbSet<User> Users { get; set; }
        }

    }
}
