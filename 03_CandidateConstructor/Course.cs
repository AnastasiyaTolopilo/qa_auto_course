﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CandidateConstructor
{
    internal class Course
    {
        public string Title;
        public string Description;

        public Course(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}