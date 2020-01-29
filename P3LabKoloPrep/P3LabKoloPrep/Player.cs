using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
#nullable enable

namespace BasketStats.Models
{
    [Table("Players")]
    public class Player
    {
        private static int Id=1;
        public Player(string name, string surname ="", string nick ="")
        {
            PlayerId = Id++;
            Name = name; Surname = surname; NickName = nick;
        }
        public Player() {
            PlayerId = Id++;
        }
        public int PlayerId  { get; set; }
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        public string? Surname { get; set; }
        [Display(Name = "Nick")]
        public string? NickName { get; set; }
        public ICollection<Play>? Plays { get; set; }        
    }
}
