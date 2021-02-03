using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Shared  
{
    public class Users 
    {
        [Key]
        public int UserId { get; set;}          
        public string Username { get; set;} 
        public string  Email { get; set;}
        public string Password { get; set; } 

        public byte[] PasswordHash {get; set;}        
        public byte[] PasswordSalt { get; set;}        
        public DateTime Dob { get; set; } = DateTime.Now;
        public DateTime Doc { get; set; } = DateTime.Now;         
        public DateTime Dol { get; set; } = DateTime.Now;
        public bool isDeleted { get; set; } = false;
        public bool isBanned { get; set; } = false;
        public string FullName { get; set; } 
        public string UserPoster { get; set; }
        public int LandeId { get; set; } 
        public int FirmaId { get; set; }
        public int RoleId { get; set; }
        public string JobPosition { get; set; }
        public string JobPositionDescription { get; set; }
        public string Phone { get; set; }
        public int? OrderPosition { get; set; }   

        // relationships

        public List<UserPhotos> UserPhotos { get; set; } 
        public Landes Lande { get; set; } 
        public Firmas Firma { get; set; }
        public Roles Role { get; set; }  








    }
}
