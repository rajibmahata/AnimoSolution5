using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Shared.Entities
{
    public class GlobalLocations
    {
        [Key]
        public int Id { get; set; }

        public string LocationReference { get; set; }

        public string StreetFull { get; set; }

        public string Zip { get; set; }

        public string Town { get; set; }

        public int LandeId { get; set; }

        public Landes Lande { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Mail { get; set; }

        public bool isAcive { get; set; } = true;




    }
}
