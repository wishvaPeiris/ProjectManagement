using DataAccess.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectManagementApp.Services
{
    public interface IUser
    {
        Task<User> createAsync(User user);
        Task<Developer> createDev(Developer developer);
        User Get(int id);
        Developer GetByEmail(string email);
        Developer GetDev(string id);
        List<Developer> listOfUsers();
        List<Developer> listOfDevelopersInCompany(int companyId);
        List<Developer> listOfDevelopersInProject(int projectId);
        User Upate(User user);
        Developer UpateDev(Developer developer);
        bool DeleteDev(string id);
    }
}
