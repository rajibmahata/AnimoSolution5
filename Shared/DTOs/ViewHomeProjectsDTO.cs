using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Shared.DTOs
{
    public class ViewHomeProjectsDTO 
    {

        public List<Projects> ProjectsInVorarlberg { get; set; }
        public List<Projects> ProjectsInRestAustria { get; set; } 
        public List<Projects> ProjectsInternational { get; set; }
        public List<Projects> AllProjects { get; set; } 


    }
}
