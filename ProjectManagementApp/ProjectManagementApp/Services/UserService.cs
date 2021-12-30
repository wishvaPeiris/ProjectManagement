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
            var dbUser = _db.users.Find(user.userId);
            if (dbUser != null)
            {
                dbUser = user;
                _db.SaveChanges();

            }

            return dbUser;
        }

        public Developer UpateDev(Developer developer)
        {
            var dbDev = _db.developers.Find(developer.userId);
            if (dbDev != null)
            {
                dbDev = developer;
                _db.SaveChanges();

            }

            return dbDev;
        }
    }
}
