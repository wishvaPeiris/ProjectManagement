﻿using DataAccess.Model;
using System.Collections.Generic;

namespace ProjectManagementApp.Services
{
    public interface ICompanyService
    {
        //create company method
        bool create(Company company);

        //read company method
        //get company one
        Company Get(int id);
        //get all companies
        List<Company> listOfCompanies();

        //update company method
        Company Upate(Company company); 

        //delete company method
        void Delete(int id);    
    }
}
