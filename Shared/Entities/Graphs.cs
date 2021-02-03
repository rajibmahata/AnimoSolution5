using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class Graphs
    {
        [Key]
        public int GraphId { get; set; }
        public string GraphName { get; set; }
        public string GraphUrl { get; set; }

        public int Order { get; set; } 

    }
}
