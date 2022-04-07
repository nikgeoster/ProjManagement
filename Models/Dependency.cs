using System;
using System.Data.Entity;

namespace ProjManagement.Models  
{
    public class Dependency
    {        
        public int ID { get; set; }
        public string Dependency_Type {get;set;}
        public int Task_ID { get; set; }
        public int Role_ID { get; set; }
        public string Status {get;set;}


    }

}