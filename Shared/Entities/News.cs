using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class News
    {
        [Key]
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string PosterImage { get; set; }
        public string Body { get; set; }       
        public string Tags { get; set; }
        public DateTime Doc { get; set; } = DateTime.Now;
        public DateTime Dlu { get; set; } = DateTime.Now;
        public int UserId { get; set; }
        public string VideoUrl { get; set; }
        public string LinkUrl { get; set; }
        public bool isActive { get; set; } = true;
        public int Clicks { get; set; } = 1;
        public List<NewsGraphs> NewsGraphs { get; set; } 



    }
}
