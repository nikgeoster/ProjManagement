
namespace ProjManagement.Classes  
{
    public class Dependencies{
        public Dependencies(Models.Dependency dep)
        {
            //constructor
        }
        public double GetDependencyType(Models.Dependency dep)
        {                           
            switch(dep.Dependency_Type){
                //Task
                //get pending effort of dependent task
                case "Task":
                    return GetTaskEffort(dep);
                //Role
                //Get pending effort of employees with selected role or get unallocated employee of team
                case "Role":
                    return GetRoleEffort(dep);
                default:
                    return 0;
            }
        }
        public double GetTaskEffort(Models.Dependency dep)
        {
            return 10;
        }
        public double GetRoleEffort(Models.Dependency dep)
        {
            return 15;
        }
    }
}