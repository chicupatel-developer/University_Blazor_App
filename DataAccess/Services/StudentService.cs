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
        
        public Student GetStudent(int id)
        {
            return _dbContext.Students.Where(x => x.StudentId == id).FirstOrDefault();
        }

        public List<Transaction> GetStudentTransactions(int id)
        {
            var transactions = _dbContext.Transactions
                                    .Where(x => x.StudentId == id);
            if(transactions!=null && transactions.Count() > 0)
            {
                return transactions.ToList();
            }
            else
            {
                return new List<Transaction>();
            }
        }
    }
}
