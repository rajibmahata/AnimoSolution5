using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Shared.Entities
{
    public class Bilboard
    {
        [Key]
        public int BilboardId { get; set; }
        public string BilboardName { get; set; }
        public string BilboardFile { get; set; }
        public bool isDefaultActive { get; set; } = true;
    }
}
