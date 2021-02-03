using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class Firmas
    {
        [Key]
        public int FirmaId { get; set; }  
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int LandeId { get; set; } 
        public string Logo { get; set; }
        public string Zip { get; set; }
        public string Town  { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmail { get; set; }
        public bool isActive { get; set; } = true;
        public Landes Lande { get; set; }  
    }
}
