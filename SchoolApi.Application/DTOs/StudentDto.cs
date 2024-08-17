﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApi.Application.DTOs
{
    public class StudentDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Age { get; set; }
    }
}
