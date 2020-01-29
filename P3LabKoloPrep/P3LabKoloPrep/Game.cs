using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
#nullable enable
namespace BasketStats.Models
{
    [Table("Games")]
    public class Game
    {
     public Game()
        {
            Plays = new HashSet<Play>();
        }          
        public int GameID { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Start { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? End { get; set; }       
        public ICollection<Play>? Plays { get; set; }
    }
}
