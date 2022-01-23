﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Developer:User
    {
        public int companyId { get; set; }
        public int projectId { get; set; }
        public Company companyDev { get; set; }

        public ICollection<Ticket> tickets { get; set; }
    }
}
