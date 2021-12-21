using DataAccess.Model;
using System.Collections.Generic;

namespace ProjectManagementApp.Services
{
    public interface IProjectService
    {
        //create project method
        Project create(Project company);

        //read project method
        //get project one
        Project Get(int id);
        //get all project
        List<Project> listOfCompanies();

        //update project method
        Project Upate(Project company);

        //delete project method
        void Delete(int id);
    }
}
