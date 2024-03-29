﻿using DataAccess.Contracts;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.DTO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _dbContext;
        public StudentService(ApplicationDbContext context)
        {
            _dbContext = context;
        }
     
        public async Task<List<Student>> GetStudents()
        {
            return await _dbContext.Students.ToListAsync();
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

        public List<TransactionSummary> GetTransactionsSummary(List<int> ids)
        {
            List<TransactionSummary> transactionSummary = new List<TransactionSummary>();

            var results = from p in _dbContext.Transactions
                              // where p.StudentId==ids.FirstOrDefault()
                          where ids.Contains(p.StudentId)
                          group p by p.GLACCTNO into g
                          select new TransactionSummary
                          {
                              GLACCTNO = g.Key,
                              TotalCreditAmount = g.Sum(x => x.CreditAmount) ?? 0 ,
                              TotalDebitAmount = g.Sum(x => x.DebitAmount) ?? 0
                          };
            if (results != null && results.Count() > 0)
            {
                foreach (var r in results)
                {
                    transactionSummary.Add(new TransactionSummary()
                    {
                        GLACCTNO = r.GLACCTNO,
                        TotalCreditAmount = r.TotalCreditAmount,
                        TotalDebitAmount = r.TotalDebitAmount,
                    });
                }
                return transactionSummary;
            }
            else
                return transactionSummary;
        }

        public bool AddStudent(Student student)
        {
            try
            {
                _dbContext.Students.Add(student);
                _dbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }          
        }
    }
}
