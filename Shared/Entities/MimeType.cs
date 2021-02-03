using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class MimeType
    {
        [Key]
        public int MimeTypeId { get; set; }
        [Required]
        public string MimeTypeName { get; set; }


    }

}
