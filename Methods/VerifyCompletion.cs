using System;
using System.Data.Entity;
using ProjManagement.Classes;
using ProjManagement.Models;

namespace ProjManagement.Methods  
{
    public class VerifyCompletion
    {        
           public bool VerifyProjectCompletion(int ProjectId,DateTime CompletionDate)
           {
                //Get Tasks of a Project
                Project pro=new Project(ProjectId);
                List<Task> taskList=pro.GetTasks();
                decimal Effort=0;
                if(taskList.Count>0)
                {
                    //Check If there is a dependecy for a particular task if so get the type and the corresponding effort
                    foreach(Task task in taskList)
                    {
                        Tasks tsk=new Tasks(task.ID);
                        Models.Dependency dep=tsk.GetDependency(task.ID);
                        if(dep){
                            Dependencies deps=new Dependencies(dep);
                            Effort+=deps.GetDependencyType(dep);
                        }
                    }
                }
                else{
                    Effort=pro.GetEffort(ProjectId);
                }                
                //check if completion date is lesser than current date + effort   and return comparison
                if(DateTime.Now.AddDays(Effort)<=CompletionDate)
                    return true;
                else
                    return false;              
           } 

    }

}