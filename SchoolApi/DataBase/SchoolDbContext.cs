using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Domain.Entities;


namespace SchoolApi.DataBase;

public partial class SchoolDbContext : DbContext
{
    public SchoolDbContext()
    {
    }

    public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Professor> Professors { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentsCoursesProfessor> StudentsCoursesProfessors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.Property(e => e.CourseName).HasDefaultValue("");
        });

        modelBuilder.Entity<StudentsCoursesProfessor>(entity =>
        {
            entity.HasIndex(e => e.CourseId, "IX_StudentsCoursesProfessors_CourseId");

            entity.HasIndex(e => e.ProfessorId, "IX_StudentsCoursesProfessors_ProfessorId");

            entity.HasIndex(e => e.StudentId, "IX_StudentsCoursesProfessors_StudentId");

            entity.HasOne(d => d.Course).WithMany(p => p.StudentsCoursesProfessors).HasForeignKey(d => d.CourseId);

            entity.HasOne(d => d.Professor).WithMany(p => p.StudentsCoursesProfessors).HasForeignKey(d => d.ProfessorId);

            entity.HasOne(d => d.Student).WithMany(p => p.StudentsCoursesProfessors).HasForeignKey(d => d.StudentId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
