using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<Developer> companyDevs { get; set; }
        public ICollection<Project> companyProjects { get; set; }
    }
}
