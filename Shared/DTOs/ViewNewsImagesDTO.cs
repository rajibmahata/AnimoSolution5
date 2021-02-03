using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Shared.DTOs
{
    public class ViewNewsImagesDTO  
    {       
       
        public News News { get; set; }    
        public List<Graphs> Graphs { get; set; } 
        public List<NewsGraphs> NewsGraphs { get; set; }    


    }
}
