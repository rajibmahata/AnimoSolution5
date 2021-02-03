using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Shared.DTOs
{
    public class ViewUpdateProjectDTO
    {
        public Projects Project { get; set; }
        public List<Images> ProjectImages { get; set; }

        public List<Tecnos> TecnosSelected { get; set; }

        public List<Tecnos> TecnosUnSelected { get; set; }




    }
}
