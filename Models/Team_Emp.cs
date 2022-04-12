using System;
using System.Data.Entity;

namespace ProjManagement.Models  
{
    public class Team_Emp
    {        
        public int ID { get; set; }
        public int Employee_ID { get; set; }
        public int Team_ID { get; set; }
        public int Role_ID { get; set; }
    }
}