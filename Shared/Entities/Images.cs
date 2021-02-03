using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class Images
    {
        [Key]
        public int ImageId { get; set; }   
        public string ImageName { get; set; }
        public string ImageFile { get; set; }
        public int order { get; set; } 


    }
}
