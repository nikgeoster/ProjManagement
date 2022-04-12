using System;
using System.Data.Entity;

namespace ProjManagement.Models  
{
    public class Client
    {        
        public int ID { get; set; }
        public string Client_Name { get; set; }      
        public int UserAccount_ID { get; set; }
        public string Client_Email { get; set; }
    }

}