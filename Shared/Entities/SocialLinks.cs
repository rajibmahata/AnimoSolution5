using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class SocialLinks
    {
        
        public int GlobalConfigId { get; set; }
        public int SocialId { get; set; }
        public string SocialUrlTarget { get; set; }
        public Social Social { get; set; }
        public GlobalConfig GlobalConfig { get; set; }

    }
}
