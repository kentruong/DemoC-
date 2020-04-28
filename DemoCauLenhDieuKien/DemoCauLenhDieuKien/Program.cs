using System;

namespace DemoCauLenhDieuKien
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Câu điề kiện dạng thiếu
            string K = "Ken Truong";
            if (K == "Anh Truong")
                Console.WriteLine("K");
            #endregion

            #region Câu điều kiện dạng đủ
            if (K == "Anh Truong")
                {
                    Console.WriteLine("K");
                    Console.WriteLine("KKKK");
            }  
            else if (K == "Ken Truong")
            {
                Console.WriteLine("Connecting Ken Truong ...");
            }
            else
                Console.WriteLine("Khong thoa dieu kien !");
            #endregion

            #region Taosn tử ba ngôi
            string s = "test";
            bool loginSuccess = s == "test" ? true : false;
            if (loginSuccess)
            {
                Console.WriteLine("Login Success !");
            }
            else
            {
                Console.WriteLine("Login Failed !");
            }
            #endregion

            #region Demo câu điều kiện
            int A, B;
            double nghiem;
            String strA, strB;
            Console.WriteLine("   ************************************");
            Console.WriteLine("   *                                  *");
            Console.WriteLine("   *   Giai Phuong Trinh Ax + B = 0   *");
            Console.WriteLine("   *                                  *");
            Console.WriteLine("   ************************************");

            Console.WriteLine("Mơi Nhap So A : ");
            strA = Console.ReadLine();
            Console.WriteLine("Mơi Nhap So B : ");
            strB = Console.ReadLine();

            if(int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false)
            {
                Console.WriteLine("Du lieu nhap sai");
            }
            else
            {
                Console.WriteLine("Phuong trinh vua nhap cua ban là : {0}x + {1} = 0", A, B );
                if(A == 0)
                {
                    Console.WriteLine("\n Phuong trinh co vo so nghiem");
                }
                else if (B == 0)
                {
                    Console.WriteLine("\n Phuong Trinh co nghiem la x = 0");
                }
                else
                {
                    nghiem = (double)-B / A;
                    Console.WriteLine("\n Nghiem là x = {0}", nghiem);
                }
            }    
            #endregion
            Console.ReadLine();
        }
    }
}
