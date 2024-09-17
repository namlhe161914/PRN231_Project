﻿using System;
using System.Collections.Generic;

namespace PRN231Project.Models
{
    public partial class Job
    {
        public Job()
        {
            Applies = new HashSet<Apply>();
        }

        public int JobId { get; set; }
        public string JobName { get; set; } = null!;
        public string JobDesc { get; set; } = null!;
        public string JobRequire { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Salary { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual ICollection<Apply> Applies { get; set; }
    }
}