namespace ProjManagement.Models  
{
    public class Projects
    {        
        public int ID { get; set; }
        public int Client_ID { get; set; }
        public string Project_Name { get; set; }        
        public string Project_Desc { get; set; }        
        public DateTime Project_Start { get; set; }    
        public DateTime Project_End { get; set; }    
        public decimal Allocated_Effort {get;set;}
    }
}