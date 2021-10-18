using BaiTap7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //Có tổng cộng 4 kiểu lấy dữ liệu 
        //Kiểu đầu tiên
        //Chú ý trong những cái request phải trùng với name ở trong cái view index ấy
        /*public ActionResult Register()
        {
            int Ma = Convert.ToInt32(Request["Id"]);
            string HoTen = Request["Name"];
            decimal Diem = Convert.ToDecimal(Request["Mark"]);

            ViewBag.ThongTin = "Mã SV: " + Ma + " - Tên SV: " + HoTen + " - Diem SV: " + Diem;
            return View();
        }*/

        //Kiểu thứ 2
        //Qua tham số là FormCollection
        //Đối với kiểu lấy dữ liệu này thì không được dùng query string , query string sẽ không thực hiện lấy được nó chỉ lấy được trong form thôi
        /*public ActionResult Register( FormCollection fn)
        {
            int Ma = Convert.ToInt32(fn["Id"]);
            string HoTen = fn["Name"];
            decimal Diem = Convert.ToDecimal(fn["Mark"]);

            ViewBag.ThongTin = "Mã SV: " + Ma + " - Tên SV: " + HoTen + " - Diem SV: " + Diem;
            return View();
        }*/

        //Kiểu thứ 3
        //là kiểu truyền trực tiếp vào ấy
        /*public ActionResult Register(int Id, string Name, decimal Mark)
        {
            ViewBag.ThongTin = "Mã SV: " + Id + " - Tên SV: " + Name + " - Diem SV: " + Mark;
            return View();
        }*/

        //Kiểu thứ 4
        //Là kiểu tạo đối tượng Model ấy
        public ActionResult Register(Student sv)
        {
            ViewBag.ThongTin = "Mã SV: " + sv.Id + " - Tên SV: " + sv.Name + " - Diem SV: " + sv.Mark;
            return View();
        }


        //Đọc ghi file dữ liệu
        public ActionResult Save(Student sv)
        {
            //Đường dẫn đến file lưu dữ liệu
            string path = Server.MapPath("~/StudentInfo.txt");

            //Khai báo một mảng kiểu xâu ký tự
            string[] lines = { sv.Id.ToString(), sv.Name, sv.Mark.ToString() };

            //Ghi thông tin vào file
            System.IO.File.WriteAllLines(path, lines);

            ViewBag.HanhDong = "Đã ghi vào file !";
            ViewBag.ThongTin = "Rỗng nhá !";

            //Trả về view Index
            return View("Index");
        }


        public ActionResult Open(Student sv)
        {
            //Đường dẫn đến file lưu dữ liệu
            string path = Server.MapPath("~/StudentInfo.txt");

            //Đọc file vào một mảng kiểu xâu ký tự
            string[] lines = System.IO.File.ReadAllLines(path);

            //Gán giá trị vào Model
            sv.Id = Convert.ToInt32(lines[0]);
            sv.Name = lines[1];
            sv.Mark = Convert.ToDecimal(lines[2]);


            //Thông tin đọc được
            ViewBag.ThongTin = "Mã sinh viên: " + sv.Id + " - Tên SV: " + sv.Name + " - Điểm: " + sv.Mark;
            ViewBag.HanhDong = "Đã đọc từ file!";


            return View("Index", sv);
        }

    }
}