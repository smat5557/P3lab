using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
#nullable enable

namespace BasketStats.Models
{
    public enum PlayType
    {
        Score, Miss, Assist, Rebound, Steal, Turnover, SubIn, SubOut
    }
    public enum ReboundType
    {
        Defensive, Offensive
    }
    public enum Team
    {
        ATeam, BTeam
    }
    [Table("Plays")]
    public class Play
    {      
        
        public int PlayID { get; set; }            
        [DataType(DataType.DateTime)]
        public DateTime Time { get; set; }
        public PlayType Type { get; set; }
        public int? PointsScored { get; set; }
        public ReboundType? Rebound { get; set; }
        public Team Team { get; set; }
    }
}
