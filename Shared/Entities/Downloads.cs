using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class Downloads
    {
        [Key]
        public int DownloadId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Doc { get; set; } = DateTime.Now;
        public DateTime Dlu { get; set; }
        public bool isPassworded { get; set; }
        public int MimeTypeId { get; set; }
        public string FileUrl { get; set; }
        public int Order { get; set; }
        public bool isActive { get; set; } = true;
        public MimeType MimeType { get; set; }



    }
}
