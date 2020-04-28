using System;
using System.Text;
namespace Mang_1_Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            #region Cú pháp khai báo, khởi tạo, cú pháp, cấp phát vùng nhớ cho mảng 1 chiều
            //Khai báo mảng
            string[] arrayA;
            /* Khai báo mảng một chiều kiểu string và có tên là SinhVien
             * Sau đó thực hiện cấp phát vùng nhớ với số phần tử tối đa của mảng là 3
             */
            //string[] SinhVien = new string[3];
            /*Khởi tạo giá trị ngay khi cấp phát vùng nhớ
             * Sau câu lệnh này thì mảng SinhVien sẽ có 2 phần tử mang 2 giá trị là "Khoa" và "Dung"
             */
            string[] SinhVien = new string[] { "Khoa", "Dung" , "Ki" };
            // Nhập dữ liệu cho mảng
            Console.WriteLine("Mời bạn nhập mảng");
            for (int i = 0; i < SinhVien.Length; i++)
            {
                SinhVien[i] = Console.ReadLine();
            }
            // Xuất mảng
            for (int i = 0; i < SinhVien.Length; i++)
            {
                Console.WriteLine(SinhVien[i]);
            }
            //string[] SinhVien = new string[2] { "Khoa", "Dung" }; => mình có thể ko cần phải khai báo số phần tử
            // Cách khai báo mảng khác
            int[] IntArray = { 5, 9, 10 };

            //vd kiểm tra năm âm lịch
            int Year;// Biến chứa giá trị năm cần tính
            // Mảng chứa các giá trị tương ứng
            string[] Can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Đinh", "Mau", "Kỵ", };
            string[] Chi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mẹo", "Thìn", "Tỵ", "Ngọ", "Mùi" };

            Console.Write("Mời bạn nhập một năm bất kì : ");
            Year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Năm {0} có năm âm lịch là : {1} {2}",Year,Can[Year % 10],Chi[Year % 12] );
            //end-vd
            #endregion
            Console.WriteLine();
        }
    }
}
