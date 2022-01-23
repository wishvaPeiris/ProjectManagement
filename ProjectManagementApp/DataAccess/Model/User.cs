using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class User:IdentityUser
    {
        public static ClaimsIdentity Identity { get; set; }
        public string userContactNo { get; set; }
        public string userAddress { get; set; }
    }
}
