namespace BaiTap11_3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [StringLength(15)]
        [Required(ErrorMessage = "Mã sv không được để trống!")]
        [DisplayName("Mã sinh viên")]
        public string MaSV { get; set; }


        [Required(ErrorMessage = "Tên sv không được để trống!")]
        [DisplayName("Tên sinh viên")]
        [StringLength(30)]
        public string TenSV { get; set; }


        [Required(ErrorMessage = "Địa chỉ không được để trống!")]
        [DisplayName("Địa chỉ")]
        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(20, ErrorMessage = "Số điện thoại không đúng định dạng")]
        [MaxLength(20, ErrorMessage = "Số điện thoại không đúng định dạng")]
        [Required(ErrorMessage = "Số điện thoại không được để trống!")]
        [DisplayName("Điện thoại")]
        public string DienThoai { get; set; }


        [StringLength(50)]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng!")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Ảnh")]
        [StringLength(50)]
        public string Anh { get; set; }

        [Required(ErrorMessage = "Tên đăng nhập không được để trống!")]
        [StringLength(40)]
        [DisplayName("Tên đăng nhập")]
        public string TenDN { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống!")]
        [StringLength(50)]
        [DisplayName("Mật khẩu")]
        public string MatKhau { get; set; }

        
        [DisplayName("Khoá")]
        public bool? Khoa { get; set; }

    }
}
