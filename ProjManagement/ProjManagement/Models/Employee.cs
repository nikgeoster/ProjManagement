namespace ProjManagement.Models  
{
    public class Employee
    {        
        public int ID { get; set; }
        public string First_Name { get; set; }        
        public string Last_Name { get; set; }        
        public int UserAccount_ID { get; set; }
        public int[] Assigned_Task_Ids {get; set;}
 
    }

}