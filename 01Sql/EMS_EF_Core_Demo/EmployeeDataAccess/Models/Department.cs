﻿using System;
using System.Collections.Generic;

namespace EmployeeDataAccess.Models
{
    public partial class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
