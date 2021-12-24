using DataAccess;
using DataAccess.Model;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagementApp.Services
{
    
    public class CompanyService : ICompanyService
    {
        private readonly ApplicationDbContext _db;

        public CompanyService(ApplicationDbContext db)
        {
            _db = db;    
        }

        public Company create(Company company)
        {
            if (company != null)
            {
               _db.companies.Add(company);
               _db.SaveChanges();
            }

            return company;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Company Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Company> listOfCompanies()
        {
            return _db.companies.ToList();
        }

        public Company Upate(Company company)
        {
            var dbCompany = _db.companies.Find(company.Id);
            if(dbCompany == null)
            {
                dbCompany = company;

                _db.SaveChanges();  
                
            }

            return dbCompany;
        }
    }
}
