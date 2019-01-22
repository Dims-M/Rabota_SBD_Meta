using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoobollBD
{
    /// <summary>
    /// Описывает класс для работы с  БД
    /// </summary>
   public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }

        public int? TeamId { get; set; }

//в классе Player называется навигационным свойством - при получении данных об игроке оно будет автоматически получать данные из БД.

        public Team Team { get; set; }

    }


}
