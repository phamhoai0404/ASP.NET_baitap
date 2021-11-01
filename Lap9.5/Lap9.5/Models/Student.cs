using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lap9._5.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        //Thêm Address vào class Student
        public string Address { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}