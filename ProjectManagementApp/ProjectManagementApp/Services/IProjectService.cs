using DataAccess.Model;
using System.Collections.Generic;

namespace ProjectManagementApp.Services
{
    public interface IProjectService
    {
        Project create(Project project);
        Project Get(int id);
        List<Project> listOfProjects();
        List<Project> listOfProjectsToCompanyIdAsync(int comp_id);
        Project Upate(Project project);
        bool Delete(int id);
    }
}
