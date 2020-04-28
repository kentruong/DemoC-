using System;

namespace DemoStruck
{
    class Program
    {
        static void Main(string[] args)
        {
            // struck ko được kế thừa
            // struck <tên struck>
            // tên struck là tên kiểu dữ liệu do mình tự đặt ra
            // Kiểu dữ liệu SinhVien có thể dùng làm kiểu dữ liệu cho biến , parametter cho phương thức .
            // Ngoài ra còn có thể làm kiểu trả về cho phương thức
            //vì struck là kiểu tham trị nên khi truyền vào các phương thức thì giá trị của nó sau khi kết thúc phương thức sẽ ko thay đổi.
            // Do dó cần sử dụng từ khóa out đẻ có thể cập nhật giá trị thay đổi khi kết thúc phương thức .
            SinhVien SV1 = new SinhVien();
            Console.WriteLine("Nhap thong tin sinh vien");
            NhapThongTinSinhVien(out SV1);
            Console.WriteLine("**********");
            Console.WriteLine("Thong Tin Sinh Vien Vua Nhap La :");
            XuatThongTinSinhVien(SV1);
            Console.WriteLine("diem Trung Binh Cua Sinh Vien Co Ma So " + SV1.MaSo + " la :" + DiemTrungBinhMon(SV1));
            Console.WriteLine();
        }
        struct SinhVien
        {
            public int MaSo;
            public string HoTen;
            public double DiemToan;
            public double DiemVan;
            public double DiemAnhVan;
        }
        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.WriteLine("Nhap Ma so Sinh Vien");
            SV.MaSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Ten Sinh Vien");
            SV.HoTen = Console.ReadLine();
            Console.WriteLine("Diem Toan");
            SV.DiemToan = Double.Parse(Console.ReadLine());
            Console.WriteLine("Diem Van");
            SV.DiemVan = Double.Parse(Console.ReadLine());
            Console.WriteLine("Diem Anh Van");
            SV.DiemAnhVan = Double.Parse(Console.ReadLine());
        }
        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine("Ma So Sinh Vien" + SV.MaSo);
            Console.WriteLine("Ho Ten Sinh Vien" + SV.HoTen);
            Console.WriteLine("Diem Toan" + SV.DiemToan);
            Console.WriteLine("Diem Van" + SV.DiemVan);
            Console.WriteLine("Diem AnhVan" + SV.DiemAnhVan);
        }
        static double DiemTrungBinhMon(SinhVien SV)
        {
            return (SV.DiemToan + SV.DiemVan + SV.DiemAnhVan) / 3;
        }
    } 
}
