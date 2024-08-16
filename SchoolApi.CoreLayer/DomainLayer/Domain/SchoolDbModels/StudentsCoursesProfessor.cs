using System;
using System.Collections.Generic;

namespace SchoolApi.CoreLayer.DomainLayer.Domain.SchoolDbModels
{
    public partial class StudentsCoursesProfessor
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int ProfessorId { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; } = null!;

        public virtual Professor Professor { get; set; } = null!;

        public virtual Student Student { get; set; } = null!;
    }

}

