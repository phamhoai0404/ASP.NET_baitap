namespace BaiTap14.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nguoidung")]
    public partial class nguoidung
    {
        [Key]
        public int manguoidung { get; set; }

        [Required(ErrorMessage = "Họ tên người đùng không được để trống!")]
        
        [StringLength(30)]
        [DisplayName("Họ tên ")]
        public string hoten { get; set; }


        [Required(ErrorMessage = "Mật khẩu không được để trống!")]
        [DataType(DataType.Password)]
        [StringLength(50)]
        [DisplayName("Mật khẩu")]
        public string matkhau { get; set; }

        [Required(ErrorMessage = "Địa chỉ email không được để trống!")]
        [StringLength(50)]
        [DisplayName("Địa chỉ Email")]
        public string email { get; set; }

        public bool khoa { get; set; }
    }
}
