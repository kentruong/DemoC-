using System;

namespace CauTrucHamCoBan
{
    class Program
    {
        static void Main(string[] args)
        {
            /* [Từ khóa 1][Từ khóa 2][Từ khóa n]<Kiểu trả về><Tên hàm>([Paremeter[]])
             * {} => Các lệnh của hàm đề nằm trong cặp dấu này
             * Từ khóa : public , static, read only, private
             * Kiểu trả về : int, long , void ,string , SinhVien (void ko càn return, hoặc nếu có chỉ là return; ko cần trả về gì hết)
             * Tên hàm : tên gọi
             * Paremeter : tham số truyền vào sử dụng nội bộ hàm
             */
            //Demo();
            int a = 0;
            int b = 3;
            // in ra 10 lần tổng của hai số
            for (int i = 0; i < 10; i++)
            {
                // in ra tổng của hai số
                PrintSumNumber(a, b);
                // tính toán đẻ tạo ra 2 số mới - không quan trọng lắm :)
                a += i;
                b += i * 2 % 5;
            }
            SomeThings("Khoa",35);
            SomeThings("Dung",28);
            SomeThings("My Son",1);
            Console.ReadKey();
        }
        static void Demo() // do hàm này viết bên hàm Main mà hàm Main có static nên hàm Demo phải có static mới sử dụng được trong hàm Main
        {
            Console.WriteLine("Day la ham Demo");
            Console.WriteLine(ReturnNumber());
            Console.WriteLine("Tong cua {0} va {1}", Number1, Number2);
            Console.WriteLine(SumNumbers(Number1, Number2));
            Console.WriteLine(SumNumbers(100, 102));
            return; // có cũng được ko có cũng được
        }
        static int ReturnNumber()
        {
            return 5; // trả về kiểu int 
        }
        static int Number1 = 5; // biến toàn cục
        static int Number2 = 15;
        static int SumNumber()
        {
            return Number1 + Number2;
        }
        static void PrintSumNumber(int pa1, int pa2)
        {
            Console.WriteLine("{0} + {1} = {2}", pa1, pa2, SumNumbers(pa1, pa2));
        }
        static int SumNumbers(int pa1, int pa2)
        {
            return pa1 + pa2;
        }
        static void SomeThings(string name, int age)
        {
            if(age <= 1)
            {
                Console.WriteLine("This is {0} , {1} year", name, age);
            }
            else
            {
                Console.WriteLine("This is {0} , {1} years", name, age);
            }
            
        }
    }
}
