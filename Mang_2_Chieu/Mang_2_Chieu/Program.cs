using System;
using System.Text;

namespace Mang_2_Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            #region Khai báo , khởi tạo và cấp phát vùng nhớ cho mảng hai chiều
            /*Khai báo mảng hai chiều có số dòng là 2 và số cột là 3 
             */
            // string[,] SinhVien; // kiểu khai báo ngắn gọn
            string[,] SinhVien1 = new string[2, 3];
            string[,] SinhVien2 = new string[,]
                {
                    {"Khoa","Anh"},
                    {"Dung","Thuy"}
                };
            int[,] IntArray = new int[,]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            for(int i=0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write("{0,4}",IntArray[i, j]);
                    //Console.WriteLine("rank : " + IntArray.Rank); // kiển tra số chiều của mảng
                    //Console.WriteLine("getlength0 : " + IntArray.GetLength(0)); // độ dài của mảng => có thể tạm hiển chiểu thứ 1
                    //Console.WriteLine("getlength1 : " + IntArray.GetLength(1)); // độ dài của mảng => có thể tạm hiển chiểu thứ 2
                }
                Console.WriteLine();
            }
            //vd 
            Console.WriteLine("Mời bạn nhập số dòng của mảng");
            int Rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số cột của mảng");
            int Columns = int.Parse(Console.ReadLine());
            //Tạo 1 mảng 2 chiều với số dòng và số cột vừa nhập
            int[,] Arrays = new int[Rows, Columns];
            /*Duyệt mảng đê nhập giá trị cho các phần tử
             */
            for (int i = 0; i < Arrays.GetLength(0); i++)
            {
                for (int j = 0; j < Arrays.GetLength(1); j++)
                {
                    Console.Write("Mời bạn nhập phần tử Arrays[{0},{1}] =",i,j);
                    Arrays[i, j] = int.Parse(Console.ReadLine());
                }
            }
            // in mảng ra và sau đó tính tổng của các phần tử
            // Để tính tổng các giá trị trong mảng ta chỉ cần duyệt qua các phẩn tử và cộng chúng lại với nhau
            Console.WriteLine("\n Mảng bạn vửa nhập là : ");
            int sum = 0;
            for (int i = 0; i < Arrays.GetLength(0); i++)
            {
                for (int j = 0; j < Arrays.GetLength(1); j++)
                {
                    Console.Write("{0,4}", Arrays[i, j]);
                    sum = sum + Arrays[i, j];
                    //Console.WriteLine("rank : " + IntArray.Rank); // kiển tra số chiều của mảng
                    //Console.WriteLine("getlength0 : " + IntArray.GetLength(0)); // độ dài của mảng => có thể tạm hiển chiểu thứ 1
                    //Console.WriteLine("getlength1 : " + IntArray.GetLength(1)); // độ dài của mảng => có thể tạm hiển chiểu thứ 2
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tổng giá trị cảu mảng là : {0}", sum); ;
            //end-vd
            #endregion
            Console.WriteLine();
        }
    }
}







