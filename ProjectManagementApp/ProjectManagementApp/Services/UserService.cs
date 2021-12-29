using DataAccess;
using DataAccess.Model;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagementApp.Services
{
    public class UserService : IUser
    {
        private readonly ApplicationDbContext _db;

        public UserService(ApplicationDbContext db)
        {
            _db = db;
        }
        public User create(User user)
        {
            if (user != null)
            {
                _db.users.Add(user);
                _db.SaveChanges();
            }

            return user;
        }

        public Developer createDev(Developer developer)
        {
            if (developer != null)
            {
                _db.developers.Add(developer);
                _db.SaveChanges();
            }

            return developer;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public User Get(int id)
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }
    }
}
