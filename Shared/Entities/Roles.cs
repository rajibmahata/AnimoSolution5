using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; } 

        [Required(ErrorMessage ="Please Complete")]
        public string RoleName { get; set; }
         
    }
}
