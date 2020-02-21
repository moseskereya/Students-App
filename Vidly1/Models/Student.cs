using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace Vidly1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
    public class StudentDBContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}