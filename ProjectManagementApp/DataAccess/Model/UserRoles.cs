using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class UserRoles<IdentityUserRoles>
    {
        public int roleId { get; set; }
        public string userId { get; set; }
    }
}
