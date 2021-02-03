using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Shared.DTOs
{
    public class ViewProjectDTO
    {
        public Projects Project { get; set; } 
        public List<Tecnos> Tecnos { get; set; } 
        public List<Images> Images { get; set; } 
    
    }
}
