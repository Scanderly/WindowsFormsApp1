﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Vacancy:Entity
    {
        public Skill[] Skills { get; set; }
        public string Description { get; set; }
        public string Deadline { get; set; }
    }
}
