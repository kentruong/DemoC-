using System;

namespace KieuDuLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kiểu dữ liệu Object
            object obj = "Truong Anh Khoa";
            /*
            * boxing : chuyển từ kiểu dữ liệu giá trị sang kiểu dữ liệu tham chiếu 
            */
            // vd-boxing
            int val = 109;
            object object1 = val;
            // end vd-boxing

            // vd-unboxing
            int newval = (int)object1;
            //end-vd-unboxxing
            #endregion

            #region var khai báo biến ko cần khai báo kiểu dữ liệu
            // ko được để null khi khai báo, phải gán giá trị luôn khi khởi tạo
            var varString = "khai bao bang bien var";
            string contents = "khai bao chuoi binh thuong";
            Console.WriteLine(varString);
            Console.WriteLine(contents);

            #endregion

            #region Kiểu dữ liệu dynamic
            // Các đối tượng sẽ không xác định được kiểu cho đến khi được thực thi
            // ví dụ kiểu string sẽ ko dùng được toán tử ++ nhưng sẽ ko báo lỗi cho đến khi chương trình dược thục thi
            // vd
            // Khai báo hai biến Name và Mission kiểu string và khỏi tạo giá trị cho nó 
            string Name = "Ken Truong";
            string Status = "Connecting";
            // Thực hiện gán 1 biến kiểu string cho biến  kiểu dynamic bằng cách ép kiểu ngầm định (implicit)
            // Sau phép gán này thi biến dynamicVal sex chuwa giá trị là "Ken Truong" nhưng kiểu dữ liệu của nó vãn chưa được xác định
            dynamic dynamicVal = Name;
            // Thực hiện cộng chuỗi và in ra màng hình bình thường 
            Console.WriteLine("Status of " + dynamicVal + " is " + Status);
            #endregion
            Console.ReadKey();
        }
    }
}
