using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class Landes  
    {
        [Key]
        public int LandeId { get; set; }   
        public string LandeName { get; set; }
        public string LandeShort { get; set; }
        public string LandeFlag { get; set; } 
    }
}
