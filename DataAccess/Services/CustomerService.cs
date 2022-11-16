using DataAccess.Contracts;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _dbContext;
        public StudentService(ApplicationDbContext context)
        {
            _dbContext = context;
        }
     
        public List<Student> GetStudents()
        {
            return _dbContext.Students.ToList();
        }      
    }
}
