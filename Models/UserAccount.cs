using System;
using System.Data.Entity;

namespace ProjManagement.Models  
{
    public class UserAccount
    {        
        public int ID { get; set; }
        public string User_Name { get; set; }        
        public string Password { get; set; }        
        public string Email { get; set; }
        public string User_Type {get; set;}
        public DateTime Acct_Create_Time { get; set; }    
    }
}