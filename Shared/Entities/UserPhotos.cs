using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class UserPhotos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PhotoId { get; set; }
        public Photos Photo { get; set; }
        [Required]
        public int UserId { get; set; }
        public Users User { get; set; }
        public int Order { get; set; }

    }
}
