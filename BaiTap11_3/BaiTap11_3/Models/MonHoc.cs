namespace BaiTap11_3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonHoc")]
    public partial class MonHoc
    {
        
        [Key]
        [StringLength(4)]
        [DisplayName("Mã môn")]
        [Required(ErrorMessage = "Mã môn học không được để trống!")]
        public string MaMon { get; set; }


        [Required(ErrorMessage = "Tên môn học không được để trống!")]
        [DisplayName("Tên môn")]
        [StringLength(50)]
        public string TenMon { get; set; }

        [DisplayName("Số tín chỉ")]
        [Required(ErrorMessage = "Số tín chỉ không được để trống!")]
        public int? SoTinChi { get; set; }

        [DisplayName("Số đăng ký")]
        public int? SoDangKy { get; set; }
    }
}
