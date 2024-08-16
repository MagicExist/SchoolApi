using System;
using System.Collections.Generic;

namespace SchoolApi.Domain.Entities;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public virtual ICollection<StudentsCoursesProfessor> StudentsCoursesProfessors { get; set; } = new List<StudentsCoursesProfessor>();
}


