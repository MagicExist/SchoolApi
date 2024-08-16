using System;
using System.Collections.Generic;

namespace SchoolApi.CoreLayer.DomainLayer.Domain.SchoolDbModels
{
    public partial class Course
    {
        public int Id { get; set; }

        public string CourseName { get; set; } = null!;

        public virtual ICollection<StudentsCoursesProfessor> StudentsCoursesProfessors { get; set; } = new List<StudentsCoursesProfessor>();
    }
}