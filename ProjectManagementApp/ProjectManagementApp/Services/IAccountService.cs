using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ProjectManagementApp.Services
{
    public interface IAccountService
    {
        //create company method
        bool create(UserManager<IdentityUser> userManager);

        //read company method
        //get company one
        UserManager<IdentityUser> Get(int id);
        //get all companies
        List<UserManager<IdentityUser>> listOfUsersManagers();

        //update company method
        UserManager<IdentityUser> Upate(UserManager<IdentityUser> userManager);

        //delete company method
        void Delete(int id);
    }
}
