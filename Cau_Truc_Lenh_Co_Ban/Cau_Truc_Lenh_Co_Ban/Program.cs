using System;

namespace Cau_Truc_Lenh_Co_Ban
{
    class Program
    {
        /// <summary>
        /// Hàm chạy đầu tiên khi chương trình được biên dịch
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Console.Write()

            Console.Write("Ken");  // In ra màng hình dòng chữ Ken
            Console.Write(10);     // In ra màng hình số 10  
            Console.Write(10.9f);  // In ra màng hình số 10.9 (f biểu thị cho kiểu dữ liệu float)
            Console.Write(true);   // In ra màng hình chữ true của kiểu dữ liệ bool

            Console.Write("Ken \n"); // Sử dụng ký tự đặc biệt để xuống dòng
            Console.WriteLine(5);    // Sử dụng lệnh in ra màng hình có xuống dòng
            Console.Write("Ken \n"); // In ra giá trị nhưng ko xuống dòng
            Console.Write(Environment.NewLine); // Sử dụng lệnh xuống dòng
            Console.Write("Ken \n"); // Sử dụng ký tự đặc biệt đẻ xuống dòng

            Console.ReadLine(); // Đợi người dùng nhấn phím Enter
            // ctrl + K + C -> cmt 
            // ctrl + k + U -> mở cmt

            #endregion

            int a = 5; // Khai báo biến kiểu nguyên có tên là a và khởi tạo giá trị là 5
            Console.Write("a = "); // In ra màng hình a =
            Console.Write("a = " + a); // In ra màng hình giá trị a = 5
            Console.Write("a = {0}" + a); // In ra màng hình giá trị a = 5
            Console.Write(a); // In ra màng hình giá trị của a là 5
            Console.Write("{0} {1} {2} {3} {4}", 1, 2, 3, 4, 5 + "\n");

            Console.Write(Console.Read()); // đọc 1 ký tự từ bàn phím sau đó in ra ký tự vừa đọc bằng số nguyên
            Console.Write(Console.ReadLine()); // đọc 1 ký tự từ bàn phím cho đến khi gập kí tự xuống dòng(enter) sau đó in ra ký tự vừa đọc bằng số nguyên


            Console.ReadKey(); // Không truyền tham số vào thì mặc định là false
            Console.ReadKey(false); // Hiển thị phím ấn lên màng hình
            Console.ReadKey(true); // Không hiển thị phím ấn lên màng hình

            Console.WriteLine("Ví dụ : ");
            Console.Write("Mời bạn nhập tên của mình :");
            Console.WriteLine("Tên của bạn là : " + Console.ReadLine());
            // Quy tắc chung trong thực hiện lệnh là lệnh bên trong thục hiện trước rồi đến lệnh bên ngoài chứa nó
            // Do đó khi chạy đến đây chương trình sẽ thực hiện lệnh Console.ReadLine()
            // Sau đó thưc hiện lệnh cộng chuỗi cuối cùng in ra màng hình

            Console.WriteLine("Mời bạn nhập ngày sinh : ");
            Console.WriteLine("Ngày sinh của bạn là : " + Console.ReadLine());
            Console.Write("Mời bạn nhập quê quán : ");
            Console.WriteLine("Quê quán của bạn là : " + Console.ReadLine());



            Console.ReadKey(); // Dừng màng hình để xem kết quả
        }
    }
}
