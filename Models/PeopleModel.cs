﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTestCompany1.Models
{
    public class PeopleModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int DeptNumber { get; set; }
        public char Type { get; set; } = 's';
        public bool IsActive { get; set; } = true;
    }
}