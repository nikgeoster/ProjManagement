using System;
using System.Data.Entity;

namespace ProjManagement.Methods  
{
    public class VerifyCompletion
    {        
           public bool VerifyProjectCompletion(int ProjectId,DateTime CompletionDate)
           {
                //check if Project has dependency
                //if true
                    //Check Type of Dependency
                        //switch(type)
                            //Role
                                //Get pending effort of employees with selected role or get unallocated employee of team
                            //Task
                                //get pending effort of dependent task
                //check if completion date is lesser than current date + effort                
                //else
                    //check if completion date is lesser than current date + effort  of project

                //Return comparison
           } 

    }

}