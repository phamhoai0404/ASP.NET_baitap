using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lap9._5.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //Sử dụng anotation để tự sinh các mã tự động trong database
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}