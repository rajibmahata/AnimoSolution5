using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Shared
{
    public class NewsGraphs
    {
        [Key]
        public int Id { get; set; }      
        public int Order { get; set; }  
        public int GraphId { get; set; }
        public Graphs Graph { get; set; }   
        public int NewsId { get; set; }
        public News New { get; set; }

    }
}
