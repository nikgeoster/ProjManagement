using System;
using System.Data.Entity;

namespace ProjManagement.Models  
{
    public class Projects
    {        
        public int ID { get; set; }
        public string Project_Name { get; set; }        
        public string Project_Desc { get; set; }        
        public DateTime Project_Start { get; set; }    
        public DateTime Project_End { get; set; }    
    }

}