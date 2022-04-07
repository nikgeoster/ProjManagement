using System;
using System.Data.Entity;

namespace ProjManagement.Models  
{
    public class Dependency
    {        
        public int ID { get; set; }
        public int Task_ID { get; set; }
        public string Status {get;set;}

    }

}