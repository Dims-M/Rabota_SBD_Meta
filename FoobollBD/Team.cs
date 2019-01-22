using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoobollBD
{
    /// <summary>
    /// класс описывающий команду футболиста
    /// </summary>
   public class Team
    {

        public int Id { get; set; }
        public string Name { get; set; } // название команды
        public string Coach { get; set; } // тренер

       // навигационным свойством
        public ICollection<Player> Players { get; set; }

    }
}
