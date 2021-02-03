using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class Logos
    {
        [Key]
        public int LogoId { get; set; } 
        public string LogoName { get; set; }   
        public string LogoFile { get; set; }
        public bool isDefaultActive { get; set; } = true;
    }
}
