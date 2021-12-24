using DataAccess;
using DataAccess.Model;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagementApp.Services
{
    public class ProjectService : IProjectService
    {
        private readonly ApplicationDbContext _db;

        public ProjectService(ApplicationDbContext db)
        {
            _db = db;
        }
        public Project create(Project project)
        {
            if (project != null)
            {
                _db.projects.Add(project);
                _db.SaveChanges();
            }

            return project;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Project Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Project> listOfProjects()
        {
            return _db.projects.ToList();
        }

        public Project Upate(Project company)
        {
            throw new System.NotImplementedException();
        }
    }
}
