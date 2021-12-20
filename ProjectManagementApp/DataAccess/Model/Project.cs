using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Project
    {
        public int projectId { get; set; }
        public string projectName { get; set; }
        public int companyProjectId { get; set; }

        public Company companyProject { get; set; }

        public ICollection<Developer> developers { get; set; }
        public ICollection<Ticket> companyTask { get; set; }

    }
}
