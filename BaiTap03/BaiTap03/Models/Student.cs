using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiTap03.Models
{
    public class Student
    {
        [Display(Name = "Mã sinh viên")]
        public int ID { get; set; }

        [Display(Name = "Tên sinh viên")]
        public string   Name { get; set; }

        [Display(Name = "Điện thoại")]
        public string Phone { get; set; }

        [Display(Name = "Ngày bắt đầu ")]
        public DateTime StartDate { get; set; }

        public Student()
        {
            ID = 12345;
            Name = "Phạm Thị Hoài";
            Phone = "037 331 7715";
            StartDate = DateTime.Now;
        }
    }
}