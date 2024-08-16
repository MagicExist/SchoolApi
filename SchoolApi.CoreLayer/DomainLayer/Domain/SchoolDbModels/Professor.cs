using System;
using System.Collections.Generic;

namespace SchoolApi.CoreLayer.DomainLayer.Domain.SchoolDbModels
{
    public partial class Professor
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public virtual ICollection<StudentsCoursesProfessor> StudentsCoursesProfessors { get; set; } = new List<StudentsCoursesProfessor>();
    }
}


