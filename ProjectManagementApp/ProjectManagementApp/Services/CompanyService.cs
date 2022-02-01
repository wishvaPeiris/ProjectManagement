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

        public bool create(Company company)
        {
            if (company != null)
            {
               _db.companies.Add(company);
               _db.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            var dbCompany = _db.companies.Find(id);

            if (dbCompany != null)
            {
                _db.Remove(dbCompany);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public Company Get(int id)
        {
            return _db.companies.Find(id);
        }

        public List<Company> listOfCompanies()
        {
            return _db.companies.ToList();
        }

        public Company Upate(Company company)
        {
            var dbCompany = _db.companies.Find(company.Id);
            if(dbCompany != null)
            {
                dbCompany = company;
                _db.SaveChanges();  
            }

            return dbCompany;
        }
    }
}
