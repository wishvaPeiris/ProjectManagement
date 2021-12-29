using DataAccess.Model;
using System.Collections.Generic;

namespace ProjectManagementApp.Services
{
    public interface IUser
    {
        //create project method
        User create(User user);
        Developer createDev(Developer developer);
        //read project method
        //get project one
        User Get(int id);
        //get all project
        List<Developer> listOfUsers();
        //get all developers for that specific company id
        List<Developer> listOfDevelopersInCompany(int companyId);
        List<Developer> listOfDevelopersInProject(int projectId);
        //update project method
        User Upate(User user);

        //delete project method
        void Delete(int id);
    }
}
