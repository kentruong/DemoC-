using System;
using System.Text;
namespace VongLapForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            #region Vòng lặp foreach
            int[] IntArrays = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            foreach (int temp in IntArrays)
            {
                Console.WriteLine(temp);
                sum += temp;
            }
            #endregion
            Console.WriteLine("Tổng của mảng là : {0}", sum);

            int[][] MangHaiChieu =
            {
                new int[]{1,2,3},
                new int[]{4,5,6,7},
                new int[]{8,9,10,11,12,13}
            };

            foreach (int[] Element in MangHaiChieu)
            {
                foreach (int item in Element)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            #region Ứng dụng String vào xử lý chuỗi trong C#
            /* Khai báo 1 biến kiểu chuỗi là FullName
             * Khai báo 1 biến Result chứa kết quả chuẩn hóa chuỗi 
             * Giá trị FullName được nhập từ bàn phím 
             */
            string FullName = "";
            string Result = "";

            Console.Write("Mời bạn nhâp chuỗi cần xử lý : ");
            Console.ReadLine();

            // Cắt khaonr trằn dư ở đầu và cuối chuỗi 
            FullName = FullName.Trim();

            /* Tìm thấy khoảng trắng có nhiều hơn 2 thì bỏ bớt thành 1
             */
            while (FullName.IndexOf("  ") != -1)
            {
                FullName = FullName.Replace("  ", " ");
            }
            /* Cắt chuỗi họ tên ra thành mảng các từ
             * Sau đó duyệt mảng để chuyển hóa từng từ 1
             * Khi duyệt mỗi từ ta thực hiện cắt ra chữ cái đầu trên và lưu trong biến FirstChar
             * Cắt các chữ cái còn lại và lưu trong biến OtherChar
             * Thự hiện viết hoa các chữ cái đầu và viết thường các chữ cái còn lại
             * Cuối cùng là lưu chứ vừa chuẩn hóa vào biến Resullt
             */
            string[] SubName = FullName.Split(' ');
            for (int i = 0; i < SubName.Length; i++)
            {
                string FirstChar = SubName[i].Substring(0, 1);
                string OtherChar = SubName[i].Substring(1);
                SubName[i] = FirstChar.ToUpper() + OtherChar.ToLower();
                Result += SubName[i] + " ";
            }
            Console.WriteLine("Có phải bạn muốn nhập chuỗi : {0}" , Result);
            #endregion
            Console.ReadLine();
        }
    }
}
