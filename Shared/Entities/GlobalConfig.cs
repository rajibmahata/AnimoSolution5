using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class GlobalConfig
    {
        [Key]
        public int Id { get; set; }
        public string FirmaName { get; set; }
        public string FirmaLegalName { get; set; }        
        public int LandeId { get; set; }
        public string FirmaWeb { get; set; }
        public string FirmaHost { get; set; }
        public string FirmaSmtp { get; set; }
        public string FirmaSmtpUser { get; set; }
        public string FirmaSmtpPass { get; set; }
        public int FirmaSmtpPort { get; set; }
        public bool isPublished { get; set; }

        public string MailDestination { get; set; } = "";

        public List<SocialLinks> SocialLinks { get; set; }
    }
}
