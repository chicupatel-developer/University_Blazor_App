using System;
using System.Collections.Generic;
using System.Linq;
using Student.EFCore.Context.DTO;
using Student.EFCore.Context.Models;

namespace ConsoleApp
{
    class Program
    {
        static void DisplayStudent_Course_Department_Info(DeptCrsStdCollection deptCrsStdCollection)
        {
            if (deptCrsStdCollection != null)
            {
                // Student
                if(deptCrsStdCollection.Students!=null && deptCrsStdCollection.Students.Count() > 0)
                {
                    foreach(var student in deptCrsStdCollection.Students)
                    {
                        Console.WriteLine("Student--->" + student.StudentId + " : " + student.FirstName + " : " + student.LastName + " : " + student.EmailAddress);
                        Console.WriteLine("----------------------------------");
                    }
                }
                Console.WriteLine("------------------END OF STUDENTS----------------");
                // Course
                if (deptCrsStdCollection.Courses != null && deptCrsStdCollection.Courses.Count() > 0)
                {
                    foreach (var course in deptCrsStdCollection.Courses)
                    {
                        Console.WriteLine("Course--->" + course.CourseId + " : " + course.CourseName );
                        Console.WriteLine("----------------------------------");
                    }
                }
                Console.WriteLine("------------------END OF COURSES----------------");
                // Department
                if (deptCrsStdCollection.Departments != null && deptCrsStdCollection.Departments.Count() > 0)
                {
                    foreach (var department in deptCrsStdCollection.Departments)
                    {
                        Console.WriteLine("Department--->" + department.DepartmentId + " : " + department.DepartmentName);
                        Console.WriteLine("----------------------------------");
                    }
                }
                Console.WriteLine("------------------END OF DEPARTMENTS----------------");
            }
            else
            {
                Console.WriteLine("Nothing To Display!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Student, Course, Department
            DeptCrsStdCollection deptCrsStdCollection = new DeptCrsStdCollection();
            
            // Student
            List<Student.EFCore.Context.Models.Student> students = new List<Student.EFCore.Context.Models.Student>();
            List<StudentCourse> studentCourse = new List<StudentCourse>();
            studentCourse.Add(new StudentCourse()
            {
                StudentId = 1,
                CourseId = 1
            });
            students.Add(new Student.EFCore.Context.Models.Student()
            {
                 StudentId = 1,
                  LastName = "LastName-1",
                   FirstName = "FirstName-1",
                    DepartmentId = 1,
                     EmailAddress = "Student-1@gmail.com", 
                     StudentCourse = studentCourse                     
            });
            deptCrsStdCollection.Students = students;

            // Course
            List<Course> courses = new List<Course>();
            courses.Add(new Course()
            {
                 CourseId = 1,
                  CourseName ="Math-1",
                   DepartmentId = 1,                    
            });
            courses.Add(new Course()
            {
                CourseId = 2,
                CourseName = "Math-2",
                DepartmentId = 1,
            });
            deptCrsStdCollection.Courses = courses;

            // Department
            List<Department> departments = new List<Department>();
            departments.Add(new Department()
            {
                 DepartmentId =1,
                  DepartmentName="Math-Department"
            });
            deptCrsStdCollection.Departments = departments;

            DisplayStudent_Course_Department_Info(deptCrsStdCollection);
        }
    }
}
