﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalSharp.Data
{
    public class Employer : Entity
    {
        public string Details { get; set; }
        public ICollection<JobPost> JobPosts { get; set; }
    }
}
