using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Shared.DTOs
{
    public class ViewProjectImagesDTO 
    {       
       
        public Projects Project { get; set; }    
        public List<Images> Images { get; set; }
        public List<ProjectImages> ProjectImages { get; set; } 


    }
}
