using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLITHUVIENWINFORM
{
    class Data
    {
        public Data()
        {
            QLTVContext db = new QLTVContext();
            TaiKhoan tk = new TaiKhoan()
            {
                TenDangNhap = "thanhphong",
                MatKhau = "123",
            };
            TaiKhoan tk2 = new TaiKhoan()
            {
                TenDangNhap = "vanminh",
                MatKhau = "123",
            };
            TaiKhoan tk3 = new TaiKhoan()
            {
                TenDangNhap = "ducthanh",
                MatKhau = "123",
            };
            db.TaiKhoans.Add(tk);
            db.TaiKhoans.Add(tk2);
            db.TaiKhoans.Add(tk3);

            DocGia dg = new DocGia()
            {
                TenDG = "thanh phong",
                DiaChi = "HCM",
                SDT = "0987385499",
                Email = "tothanhphong281101@gmail.com",
            };
            DocGia dg2 = new DocGia()
            {
                TenDG = "van minh",
                DiaChi = "HCM",
                SDT = "0987375499",
                Email = "tothanhphong281101@gmail.com",
            };
            DocGia dg3 = new DocGia()
            {
                TenDG = "duc thanh",
                DiaChi = "HCM",
                SDT = "0987385449",
                Email = "tothanhphong281101@gmail.com",
            };
            db.DocGias.Add(dg);
            db.DocGias.Add(dg2);
            db.DocGias.Add(dg3);

            DateTime time = DateTime.Now;
            The t = new The()
            {
                NgayBatDau = time,
                NgayKetThuc = time.AddDays(20),
                GhiChu = "Thẻ có thời hạn",
                MaDG = 1,
            };
            The t2 = new The()
            {
                NgayBatDau = time,
                NgayKetThuc = time.AddDays(20),
                GhiChu = "Thẻ có thời hạn",
                MaDG = 2,
            };
            The t3 = new The()
            {
                NgayBatDau = time,
                NgayKetThuc = time.AddDays(20),
                GhiChu = "Thẻ có thời hạn",
                MaDG = 3,
            };
            db.Thes.Add(t);
            db.Thes.Add(t2);
            db.Thes.Add(t3);




            db.SaveChanges();
        }
        static void main()
        {
            Data init = new Data();
            Console.WriteLine(init);
        }
    }
}
