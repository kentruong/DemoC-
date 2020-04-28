using System;

namespace CauTrucLap
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Các kiểu vòng lặp
             * Goto
             * While
             * Do While
             * For
             * Foreach
             */

            #region Vòng lặp Goto nó ko phải là 1 vòng lặp nhưng cấu trúc của nó tạo ra vòng lặp (Vòng lặp không chính quy)
            //vd-1
            int a = 2;
            switch (a)
            {

                case 1: // label case 1 
                    Console.WriteLine("Case 1");
                    break;
                case 2: // label case 2 
                    Console.WriteLine("Case 2");
                    goto case 1;// di chuyển đến label case 1
                    break; // đoạn code nà thừa vì sẽ ko bao giờ thực thi
                case 3: // label case 3
                    Console.WriteLine("Case 3");
                    break;
            }
            //end-vd-1

            //vd-2
            if (a == 2)
            {
                goto a_Is_2;
            }
            Console.WriteLine("a == 1");
        a_Is_2:
            Console.WriteLine("a == 2");
            //end-vd-2

            //vd-3
            //firtPoint:
            //    Console.WriteLine("firtPoint");
            //    goto secondPoint;
            //secondPoint:
            //    Console.WriteLine("secondPoint");
            //    goto firtPoint;
            //vòng lặp sẽ chạy vĩnh viến nếu ko có đk dừng
            //end-vd-3

            //vd-4
            //    int b = 2;
            //infinityLoop:
            //    if (b == 2)
            //    {
            //        goto b_Is_3;
            //    }
            //    Console.WriteLine("b khong bang 3");
            //b_Is_3:
            //    Console.WriteLine("b bang 3");
            //    goto infinityLoop; int b = 2;
            //infinityLoop:
            //    if (b == 2)
            //    {
            //        goto b_Is_3;
            //    }
            //    Console.WriteLine("b khong bang 3");
            //b_Is_3:
            //    Console.WriteLine("b bang 3");
            //    goto infinityLoop;
            //end-vd-4

            //vd-5
            int count = 0;
            string s = "Connecting";
        do_it:
            count++;
            Console.WriteLine(s);
            Console.WriteLine(count);
            if (count < 10)
            {
                goto do_it;
            }
            //end-vd-5
            #endregion

            Console.ReadLine();
        }
    }
}
