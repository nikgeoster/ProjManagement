using System;
using System.Data.Entity;

namespace ProjManagement.Models  
{
    public class ProjectAllocation
    {        
        public int ID { get; set; }
        public int Project_ID { get; set; }
        public int Client_ID { get; set; }
        public DateTime Allocation_Start { get; set; }    
        public DateTime Allocation_Start { get; set; }     

    }

}