using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap02.Models
{
    public class Product
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
        public Product()
        {
                
        }
    }
}