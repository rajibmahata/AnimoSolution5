using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Shared
{
    public class Projects
    {
        [Key]
        public int ProjectId { get; set; }     
        public string Name { get; set; }     
        public string KundeName { get; set; }
        public DateTime Doc { get; set; } = DateTime.Now;
        public DateTime Dlu { get; set; } = DateTime.Now;                
        public string Poster { get; set; }

        public string VideoPreview { get; set; }
         
        public string VideoUrl { get; set; } 
       
        public string Description { get; set; }

        public string ShortDesc
        {
            get
            {
                if (string.IsNullOrEmpty(Description))
                { return null; }
                if (Description.Length > 60)
                { return Description.Substring(0, 30) + "..."; }
                else
                { return Description; }
            }
        }

        public bool isVorarlberg { get; set; }

        public bool isRestAustria { get; set; }

        public bool isInternational { get; set; }



        public bool isActive { get; set; } = true;
        public List<ProjectTecnos> ProjectTecnos { get; set; } = new List<ProjectTecnos>();

        public List<ProjectImages> ProjectImages { get; set; } = new List<ProjectImages>();


    }
}
