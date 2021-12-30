﻿using DataAccess;
using DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public bool Delete(int id)
        {
            var dbProject = _db.projects.Find(id);

            if(dbProject != null)
            {
                _db.Remove(dbProject);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public Project Get(int id)
        {
            return _db.projects.Find(id);
        }

        public List<Project> listOfProjects()
        {
            return _db.projects.ToList();
        }

        public List<Project> listOfProjectsToCompanyIdAsync(int comp_id)
        {
            List<Project> list = new List<Project>();

            foreach (var project in _db.projects)
            {
                if(project.companyProjectId == comp_id)
                {
                    list.Add(project);
                }
            }

            return list;
        }

        public Project Upate(Project project)
        {
            var dbProject = _db.projects.Find(project.projectId);
            if (dbProject != null)
            {
                dbProject = project;
                _db.SaveChanges();

            }

            return dbProject;
        }
    }
}
