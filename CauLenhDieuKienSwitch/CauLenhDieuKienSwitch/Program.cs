using System;

namespace CauLenhDieuKienSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Câu lệnh điều kiện switch case dạng thiếu
            // Phải là biểu thức trả về kết quả kiểu : 
            // * Số nguyên (int, long, byte)
            // * Ký tự hoặc chuỗi (char , string)
            // * Kiểu liệt kê (enum)
            int k = 10;
            switch (k)
            {
                case 1 : //Trường hợp ko có câu lệnh thì nó sẽ chạy tiếp
                case 3 :
                    Console.WriteLine("3 chua dung");
                    break;
                case 8:
                    Console.WriteLine("case nay ko co lenh break");
                    break;
                case 10:
                    Console.WriteLine("k la 10");
                    break;
                default:
                    Console.WriteLine("Neu ko thoa cac dieu kien tren thi nos se chay vao day");
                    break;
            }

            #endregion

            #region Demo
            int year;
            string can = "", chi = "";
            Console.WriteLine("   ************************************");
            Console.WriteLine("   *                                  *");
            Console.WriteLine("   *   Chương Trinh Tinh Nam Am Lich *");
            Console.WriteLine("   *                                  *");
            Console.WriteLine("   ************************************");
            Console.WriteLine("Moi ban nhap 1 nam bat ki : ");
            year = Int32.Parse(Console.ReadLine());

            switch (year % 10)
            {
                case 0 :
                    can = "Canh";
                    break;
                case 1:
                    can = "Tan";
                    break;
                case 2:
                    can = "Nham";
                    break;
                case 3:
                    can = "Quy";
                    break;
                case 4:
                    can = "Giap";
                    break;
                case 5:
                    can = "At";
                    break;
                case 6:
                    can = "Binh";
                    break;
                case 7:
                    can = "Dinh";
                    break;
                case 8:
                    can = "Mau";
                    break;
                case 9:
                    can = "Ky";
                    break;
            }

            switch (year % 12)
            {
                case 0:
                    chi = "Than";
                    break;
                case 1:
                    chi = "Dau";
                    break;
                case 2:
                    chi = "Tuat";
                    break;
                case 3:
                    chi = "Hoi";
                    break;
                case 4:
                    chi = "Ty";
                    break;
                case 5:
                    chi = "Suu";
                    break;
                case 6:
                    chi = "Dan";
                    break;
                case 7:
                    chi = "Meo";
                    break;
                case 8:
                    chi = "Thin";
                    break;
                case 9:
                    chi = "Ti";
                    break;
                case 10:
                    chi = "Ngo";
                    break;
                case 11:
                    chi = "Mui";
                    break;
            }
            Console.WriteLine("\n Nam {0} co nam am lich: {1} {2}", year, can , chi);

            #endregion
            Console.ReadKey();
            Console.ReadLine();

        }
    }
}
