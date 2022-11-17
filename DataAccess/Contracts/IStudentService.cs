﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Contracts
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudent(int id);
        List<Transaction> GetStudentTransactions(int id);
    }
}
