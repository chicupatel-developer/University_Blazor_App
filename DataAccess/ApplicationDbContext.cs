using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(bc => new { bc.StudentId, bc.CourseId });
            modelBuilder.Entity<StudentCourse>()
                .HasOne(bc => bc.Student)
                .WithMany(b => b.StudentCourse)
                .HasForeignKey(bc => bc.StudentId);
            modelBuilder.Entity<StudentCourse>()
                .HasOne(bc => bc.Course)
                .WithMany(c => c.StudentCourse)
                .HasForeignKey(bc => bc.CourseId);
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<GL_Posting> GL_Postings { get; set; }
        public DbSet<GLPS_Data> GLPS_Datas { get; set; }
    }
}
