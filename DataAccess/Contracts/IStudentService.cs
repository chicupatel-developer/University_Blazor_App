﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.DTO;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudents();
        Student GetStudent(int id);
        List<Transaction> GetStudentTransactions(int id);

        List<TransactionSummary> GetTransactionsSummary(List<int> ids);

        bool AddStudent(Student student);
        
    }
}
