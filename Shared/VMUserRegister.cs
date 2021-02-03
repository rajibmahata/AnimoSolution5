using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Shared  
{
    public class VMUserRegister  
    {
        public int UserId { get; set; }
        public string Username { get; set; } 
        public string Email { get; set; }    
        public string FullName { get; set; }   
        public string Password { get; set; }
        public DateTime Dob { get; set; }
        public DateTime Doc { get; set; } = DateTime.Now;
        public DateTime Dol { get; set; } = DateTime.Now;
        public string UserPoster { get; set; } 
        public bool isDeleted { get; set; } = false; 
        public bool isBanned { get; set; } = false; 
        public int RoleId { get; set; } 
        public int LandeId { get; set; }
        public int FirmaId { get; set; }
        public string JobPosition { get; set; }
        public string JobPositionDesc { get; set; } 
        public string Phone { get; set; }
        public int OrderPosition { get; set; } = 5;

    }
}
