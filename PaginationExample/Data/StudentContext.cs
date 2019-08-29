using PaginationExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaginationExample.Data
{
    public class StudentContext
    {
        public static List<Student> StudentList { get; set; }

        public static void InitData(int studentCount)
        {
            StudentList = CreateDemoStudentList(studentCount);
        }

        private static List<Student> CreateDemoStudentList(int studentCount)
        {
            List<Student> studentList = new List<Student>();
            for (int i = 1; i < studentCount + 1; i++)
            {
                studentList.Add(
                    new Student()
                    {
                        Id = i,
                        Firstname = "Firstname" + i,
                        Lastname = "Lastname" + i,
                        CreatedDate = DateTime.Now
                    }
                );
            }
            return studentList;
        }
    }
}
