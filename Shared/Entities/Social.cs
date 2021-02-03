using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class Social
    {
        [Key]
        public int SocialId { get; set; }
        public string Name { get; set; } 
        public string SocialIconUrl { get; set; }
        public string TargetUrl { get; set; }
        public bool isActive { get; set; } = true;

    }
}
