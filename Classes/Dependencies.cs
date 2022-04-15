using ProjManagement.Models.Dependency;

namespace ProjManagement.Classes  
{
    public class Dependencies{
        public Dependencies(Models.Dependency dep)
        {
            //constructor
        }
        public decimal GetDependencyType(Models.Dependency dep)
        {                           
            switch(dep.Dependency_Type){
                //Task
                //get pending effort of dependent task
                case "Task":
                    return GetTaskEffort(dep);
                    break;
                //Role
                //Get pending effort of employees with selected role or get unallocated employee of team
                case "Role":
                    return GetRoleEffort(dep);
                    break;
            }
        }
        public decimal GetTaskEffort(Models.Dependency dep)
        {
            return 10;
        }
        public decimal GetRoleEffort(Models.Dependency dep)
        {
            return 15;
        }
    }
}