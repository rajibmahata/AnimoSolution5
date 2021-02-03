using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class Photos
    {
        [Key]
        public int PhotoId { get; set; }
        public string PhotoName { get; set; }
        public string PhotoUrl { get; set; } 
        public List<UserPhotos> UserPhotos { get; set; }


    }
}
