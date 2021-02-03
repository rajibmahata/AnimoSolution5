using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class Tecnos
    {
        [Key]
        public int TecnoId { get; set; }
        [Required(ErrorMessage = "Bitte ausfüllen")]
        public string TecnoName { get; set; }

    }
}
