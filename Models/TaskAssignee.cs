using System;
using System.Data.Entity;

namespace ProjManagement.Models  
{
    public class TaskAssignee
    {        
        public int ID { get; set; }
        public int Task_ID { get; set; }
        public int Employee_ID { get; set; }    

    }

}