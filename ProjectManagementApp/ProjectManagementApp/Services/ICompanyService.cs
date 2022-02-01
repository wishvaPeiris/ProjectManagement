using DataAccess.Model;
using System.Collections.Generic;

namespace ProjectManagementApp.Services
{
    public interface ICompanyService
    {
        bool create(Company company);
        Company Get(int id);
        List<Company> listOfCompanies();
        Company Upate(Company company);
        bool Delete(int id);    
    }
}
