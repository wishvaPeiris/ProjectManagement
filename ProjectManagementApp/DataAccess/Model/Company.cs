using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [StringLength(500,ErrorMessage = "The title is too long, try a shorter one (500 character limit) ")]
        public string CompanyName { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<Developer> companyDevs { get; set; }
        public ICollection<Project> companyProjects { get; set; }
    }
}
