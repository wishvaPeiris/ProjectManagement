using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class User
    {
        public int userId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "The username is too long, try a shorter one (50 character limit) ")]
        public string userName { get; set; }
        [Required]
        public string userEmail { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "The contact number needs to be 10 characters")]
        public string userContactNo { get; set; }

        public string DiscriminatorValue
        {
            get
            {
                return this.GetType().Name;
            }
        }
    }
}
