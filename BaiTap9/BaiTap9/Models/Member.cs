using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiTap9.Models
{
    public class Member
    {
        [DisplayName("Ảnh")]
        public string ImagePath { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Không được để trống")]
        [MinLength(3, ErrorMessage = "Tên phải có ít nhất 3 kí tự")]
        public string UserName { get; set; }

        [DisplayName("Mật khẩu"), DataType(DataType.Password)]
        [Required(ErrorMessage = "Không được để trống")]
        [MinLength(3, ErrorMessage = "Mật khẩu phải có độ dài từ 3 đến 8 kí tự")]
        [MaxLength(8, ErrorMessage = "Mật khẩu phải có độ dài từ 3 đến 8 kí tự")]
        public string Password { get; set; }

        [DisplayName("Họ tên")]
        [Required(ErrorMessage = "Không được để trống")]
        public string FullName { get; set; }

        [DisplayName("Ngày sinh"), DataType(DataType.Date)]
        [Required(ErrorMessage = "Không được để trống")]
        public DateTime Birthday { get; set; }

        [DisplayName("Giới tính")]
        [Required(ErrorMessage ="Giới tính không được để trống")]
        [UIHint("GioiTinh")]//Cái này cần chú ý đấy 
        public bool Gender { get; set; }

        [DisplayName("Địa chỉ")]
        public string Address { get; set; }

        [DisplayName("Địa chỉ email")]
        //Cách 1
        //Cái này đúng này khi xóa đi nó rỗng thì nó sẽ không báo lỗi 
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Phải đúng định dạng email")]

        //Cách 2
        [EmailAddress(ErrorMessage = "Phải đúng định dạng email nhá")]

        //Hai cách trên của email đều đúng
        public string Email { get; set; }
    }
}