using DataAccess.Model;
using System.Collections.Generic;

namespace ProjectManagementApp.Services
{
    public interface IUser
    {
        //create project method
        User create(User company);

        //read project method
        //get project one
        User Get(int id);
        //get all project
        List<User> listOfCompanies();

        //update project method
        User Upate(User company);

        //delete project method
        void Delete(int id);
    }
}
