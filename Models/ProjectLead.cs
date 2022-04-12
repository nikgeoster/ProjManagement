using System;
using System.Data.Entity;

namespace ProjManagement.Models  
{
    public class ProjectLead
    {        
        public int ID { get; set; }
        public int Project_ID { get; set; }
        public int Employee_ID { get; set; }
    }
}