using DataAccess;
using DataAccess.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementApp.Services
{
    public class UserService : IUser
    {
        private readonly ApplicationDbContext _db;
        

        public UserService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<User> createAsync(User user)
        {
            var userRole = new UserStore<User>(_db);
            if (user != null)
            {
                await userRole.AddToRoleAsync(user, "admin");
                _db.users.Add(user);
                _db.SaveChanges();
            }

            return user;
        }

        public async Task<Developer> createDev(Developer developer)
        {
            var userRole = new UserStore<User>(_db);
            if (developer != null)
            {
                await userRole.AddToRoleAsync(developer, "developer");
                _db.developers.Add(developer);
                _db.SaveChanges();
            }

            return developer;
            
        }

        public bool DeleteDev(int id)
        {
            var dbDeveloper = _db.developers.Find(id);

            if (dbDeveloper != null)
            {
                _db.Remove(dbDeveloper);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public User Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Developer GetDev(int id)
        {
            return _db.developers.Find(id);
        }

        public List<Developer> listOfDevelopersInCompany(int companyId)
        {
            List<Developer> list = new List<Developer>();

            foreach (var developer in _db.developers)
            {
                if (developer.companyId == companyId)
                {
                    list.Add(developer);
                }
            }

            return list;
        }

        public List<Developer> listOfDevelopersInProject(int projectId)
        {
            List<Developer> list = new List<Developer>();

            foreach (var developer in _db.developers)
            {
                if (developer.projectId == projectId)
                {
                    list.Add(developer);
                }
            }

            return list;
        }

        public List<Developer> listOfUsers()
        {
            return _db.developers.ToList();
        }

        public User Upate(User user)
        {
            var dbUser = _db.users.Find(user.Id);
            if (dbUser != null)
            {
                dbUser = user;
                _db.SaveChanges();

            }
            return dbUser;
        }

        public Developer UpateDev(Developer developer)
        {
            var dbDev = _db.developers.Find(developer.Id);
            if (dbDev != null)
            {
                dbDev = developer;
                _db.SaveChanges();

            }
            return dbDev;
        }
    }
}
