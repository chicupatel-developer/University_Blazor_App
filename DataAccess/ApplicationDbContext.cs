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
        public DbSet<Student> Students { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<GL_Posting> GL_Postings { get; set; }
        public DbSet<GLPS_Data> GLPS_Datas { get; set; }
    }
}
