using System;

namespace DemoC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ctrl + K + C -> command tất cả vùng chọn
            // Ctrl + K + U -> mở command tất cả vùng chọn
            // Ctrl + K + D : Format tất cả
            // Ctrl + K + F: Format vùng bạn chọn
            // Ctrl + K + \ : Xóa tất cả khoảng trống trong dòng code được ta bôi đen ! :))
            // Ctrl + Shift + L : Xóa dòng hiện tại (tại điểm con trỏ chuột). Xóa cả dòng rất nhanh không cần
            // Shift + End: để bôi đen từ vị trí con trỏ chuột đến cuối dòng
            // Shift + Home: để bôi đen vị trí con trỏ chuột ngược lại đầu dòng
            // Ctrl + K + K : Tạo một bookmark tại điểm con trỏ chuột
            // Ctrl + K +N : Nhảy tới bookmark tiếp
            // Ctrl + K +P : Nhảy tới bookmark sau
            // Ctrl + Space : VS sẽ hiển thị lại lần nữa các gợi ý cú pháp liên quan tại vị trí con trỏ chuột nếu có
            // Shift + Alt + T : Đổi chỗ dòng tại vị trí chuột với dòng dưới nó
            // Ctrl + U : Biến các ký tự được bôi đen thanh chữ thường.
            // Ctrl + Shift + U : Biến các ký tự thường thành chữ in HOA.
            // PageUp      : Cuộn trang code lên
            // PageDown  : Cuộn trang code xuống
            // Shift + F12 : Tìm reference của mã tại vị trí con trỏ  (Nếu có). Bạn mà để con trỏ tại mã thường thì không hiện gì đâu nhé
            #region  Ví dụ về biến
            const int hangso = 10; // Đây là hằng số nó là 1 biến và ko được thay đổi giá trị
            int a = 5;
            int b = 6;
            int c = a + b;
            Console.WriteLine("a + b = c : {0} + {1} = {2}", a, b, c);
            // Demo về biến
            int kieuSoNguyen = 5;
            float KieuSoThuc = 9.6f; // Giá trị của float phải có hậu tố f hoặc F
            
            decimal KieuDecimal = 10m; // Giá trị của float phải có hậu tố m
            bool kieuLuanLy = true;
            char KieuKiTu = 'K'; // Giá trị của char nằm trong nháy đơn
            string Kieuchuoi = "My name is Truong Anh Khoa"; // Giá trị của string nằm trong nháy kép
            Console.WriteLine(kieuSoNguyen);
            Console.WriteLine(KieuSoThuc);
            Console.WriteLine(kieuLuanLy);
            Console.WriteLine(KieuKiTu);
            Console.WriteLine(Kieuchuoi);
            #endregion

            #region Ví dụ về toán tử
            int a1 = 10;
            int a2 = 20;

            Console.WriteLine(a1++);
            Console.WriteLine(++a2);

            // Toán tử khởi tạo và gán

            int h, k, t;
            h = k = t = 10;
            Console.WriteLine("h = {0} , k = {1} , t = {2}", h, k, t);
            h += k = t = 5;
            Console.WriteLine("h = {0} , k = {1} , t = {2}", h, k, t);
            Console.WriteLine(a + b);

            #endregion

            #region Chuyển đổi kiểu dữ liệu
            // Chuyển đổi ngầm định
            long KieuLongs = kieuSoNguyen; // Chuyển đổi kiểu ngầm định vì kiểu long có miền giá trị lớn hơn kiểu int
            double KieuDouble = KieuSoThuc; // Tương tự kiểu double có miền giá trị lớn hơn kiểu float nên mình mới có thể ép kiểu được

            // Chuyển đổi kiểu tường minh 
            double d1 = 2 / 3;
            double k1 = (double)2 / 3;

            // Chuyển đổi sử dụng phương thức , lớp hổ trợ sẵn => Parse(), TryParse ; Convert 
            
            // Parse()
            string s = "10";
            int a3 = int.Parse(s);
            double e = double.Parse("10.9");

            // TryParse()
            int Result; // Biến chứa giá trị kết quả khi ép kiểu thành công.
            bool isSuccess; // Biến kiểm tra ép kiếu có thành công hay ko .
            String data1 = "10", data2 = "Ken Truong"; // Dữ liệu cần ép kiểu.
            isSuccess = int.TryParse(data1, out Result);// Thử ép kiểu data1 về int nếu thành công thì biến Result sẽ 
            Console.WriteLine(isSuccess == true ? "Success !" : "Failed !");
            Console.WriteLine("Result = " + Result); // In giá trị Result ra màng hình.

            isSuccess = int.TryParse(data2, out Result);
            Console.WriteLine(isSuccess == true ? "Success !" : "Failed !");
            Console.WriteLine("Result = " + Result); // In giá trị Result ra màng hình.

            // Convert (Lớp được C# viết hổ trợ sẵn)
            int val = Convert.ToInt32("9");

            #endregion

            #region Ví dụ Demo

            int A;
            int B;
            int Tong, Hieu, Tich;
            double Thuong;
            String strA, strB;
            Console.WriteLine("   *****************************************************");
            Console.WriteLine("   *                                                   *");
            Console.WriteLine("   *   Chương Trình Tính Tổng - Hiệu - Tích - Thương   *");
            Console.WriteLine("   *                                                   *");
            Console.WriteLine("   *****************************************************");

            Console.Write("\n Mời bạn nhập số A : ");
            strA = Console.ReadLine();
            Console.Write("Mời bạn nhập số B : ");
            strB = Console.ReadLine();
            A = int.Parse(strA);
            B = int.Parse(strB);
            Tong = A + B;
            Hieu = A - B;
            Tich = A * B;
            Thuong = (double)A / B;
            Console.WriteLine("Tong : " + Tong);
            Console.WriteLine("Hieu : " + Hieu);
            Console.WriteLine("Tich : " + Tich);
            Console.WriteLine("Thuong : " + Thuong);

            #endregion
            Console.ReadKey();
        }
    }
}
