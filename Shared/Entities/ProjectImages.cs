using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class ProjectImages
    {

        public int Id { get; set; }   
        public int ProjectId { get; set; }
        public Projects Project { get; set; }     
        public int ImageId { get; set; }         
        public Images Image { get; set; }

    }
}
