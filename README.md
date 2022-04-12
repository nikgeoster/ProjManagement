# ProjManagement
Create an object model for a project management application. 
1.       A project can be managed as a set of tasks performed by users utilizing resources in some amount of time adhering to a schedule. 
2.       The object model should contain the classes, the attributes, methods and events on those classes 
3.       The code should be well commented to inform the design decisions taken in defining the classes. 
4.       It should be hosted on Github (public/private with access provided to us) with proper meaningful incremental commits.  
5.       Do not commit the whole code in one commit. We would like to observe your thought process while designing the solution and the evolution of the code. 
6.       The code should compile without any errors. 
7.       Add a README file with the use cases that your model will support 
8.       Using the classes you have created, write the necessary code in the appropriate classes to perform the following. Assuming 
    a.       each task has an amount of time it takes to complete 
    b.       it may have a dependency on some other task to be completed first 
    c.       It may require a user/resource of some specific type 
9.       Write a function to verify if a project can be completed by a given date assuming the project is started today. 

##Use Cases:

Client Model
Client Id should be unique

Dependency Model:
Dependency Type should be Role or Task
Both RoleID and TaskId should not be null

Employee Model:
Should contain all the tasks assigned to a particular employee

Project Model:
Allocated Effort should be lesser than or equal to the number of days of the project duration

Project Allocation Model:
An Employee should be allocated to only one project
Allocation Date should be within the project duration

Project Lead Model:
There should be atleast one lead for a project

Role Model:
List all possible unique roles available in a company

Task Model:
Allocation Date should be within the project duration
Each task may have 0 or more dependencies

Task Assignee Model:
Each task assigned to only one employee

Team Model:
There maybe 1 or more teams for a project

Team Emp Model:
An Employee can only perform one role in a team
An Employee can be part of multiple teams in a project

User Account Model:
An email id can be associated with only one user account
User Type can be either Employee or Client