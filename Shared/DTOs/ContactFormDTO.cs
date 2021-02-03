using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Shared.DTOs
{
    public class ContactFormDTO
    {
        [Key]
        public int Id { get; set; } 
        public string FullName { get; set; }
   
        [Required]
        public string EmailAddress { get; set; }

        public string Firma { get; set; }

        public string Message { get; set; }



        //**********************************************
        // SHOULD I SAVE this data sent in a database ? 
        //***********************************************

    }
}
