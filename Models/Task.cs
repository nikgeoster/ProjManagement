using System;
using System.Data.Entity;

namespace ProjManagement.Models  
{
    public class Task
    {        
        public int ID { get; set; }
        public string Task_Name { get; set; }
        public int Project_ID { get; set; }
        public int Task_Assignee_ID { get; set; }
        public int Priority { get; set; }    
        public DateTime Task_Start { get; set; }     
        public DateTime Task_End { get; set; }     
        public decimal Effort {get;set;}
        public bool Dependency {get;set;}
        public int Dependency_Id {get;set;}
        public string Status {get;set;}

    }

}