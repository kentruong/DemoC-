using System;

namespace VongLapFor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vòng lặp For
            int i = 0;
            int j = 0;
            // int k = 0;
            //Console.OutputEncoding = Encoding.UTF8; // dùng để hiển thị tiếng Việt
            // for (khởi tạo ; điều kiện lặp ; bước lặp )
            // bắt buộc phải là for ( ; ; ) => có hai dấu ; 
            //for (/*đã khai báo i ở trên*/; i < 5; i++ , k += 3, Console.WriteLine(" Tang len di "))
            //{
                //Console.WriteLine("{0} | {1}", i , k); // vi dụ có thêm bước lặp trong vòng for
            //}
            // Demo vẽ hình chữ nhật
            int N = 10;
            int M = 20;
            char drawChar = '@';
            char insideChar = '*';
            // Vẽ từ trên xuống
            for( /*đã khai báo i ở trên*/; i < N; i++)
            {
                //Vẽ từ trái sang
                for ( /*đã khai báo i ở trên*/; j < M; j++)
                {
                    /* Nếu đang ở tọa độ là cạnh trên hoặc dưới  i % (x - 1) == 0
                     * hoặc đang ở cạnh trái hoặc phải j % (y - ) == 0
                     * mà ko nằm ở cạnh trên hoặc dưới (i % (x - 1) != 0)
                     * (i % (x -1) != 0) && (j % (y -1) == 0)
                     * thì vẽ ra kí tự của hình chữ nhật
                     * ngược lại vẽ ra khoản trắng
                     */
                    if (i % (N - 1) == 0 || ((i % (N - 1) != 0) && (j % (M - 1) == 0)))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;//Thêm màu
                        Console.Write(drawChar);
                        //Console.WriteLine("{0} | {1}", i, j);
                    }
                    else
                    {
                        Console.Write(insideChar);
                    }
                }
                Console.WriteLine();
            }
            //End-Demo
            #endregion

            #region Vòng lặp While
            int countLoop = 0;
            int countLoopTime = 0;
            int valueNum = 15;
            int loopTime = 500;
            int minRandomValue = 0;
            int maxRandomValue = 201;
            Random rand = new Random();
            while (countLoopTime < loopTime)
            {
                // reset lại biến countLoop
                countLoop = 0;
                //vẽ từ trái qua valueNum lần
                while (countLoop < valueNum)
                {
                    // giá trị sinh ngẫu nhiên trong khoản [minRandomValue...maxRandomValue - 1]
                    int showValue = rand.Next(minRandomValue,maxRandomValue); // kết quả hàm này trả về kiểu int !
                    // in ra giá trị của countLoop trong 8 vị trí
                    //Console.Write("{0,8}", countLoop);
                    Console.Write("{0,8}", showValue);
                    // tăng giá trị của countLoop lên 1 đơn vị
                    countLoop++;
                }
                // Mỗi khi hoàn thành một vòng lặp nhỏ thì  lịa xuống dòng chuẩn bị về lần tiếp theo
                Console.WriteLine();
                // tăng giá trị của countLoopTime lên 1 đơn vị
                countLoopTime++;
            }
            Console.WriteLine("Da hack xong may cua chu tich Nam Kun");
            // vd-vẽ hình chữ nhật rổng
            int Vertical = 20;
            int Herizontal = 50;
            char drawChars = '*';
            char insideChars = ' ';
            int countLoopVertical = 0;
            int countLoopHerizontal = 0;
            // vẽ từ trên xuống
            while(countLoopVertical < Vertical)
            {
                // Khởi tạo lại giá trị của countLoopHerizontal = 0 sau mỗi lần lặp lại mới 
                countLoopHerizontal = 0;
                while(countLoopHerizontal < Herizontal)
                {
                    /* Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
                     * hoăc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
                     * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
                     * ((i% (N - 1) != 0) && (j % (M - 1) == 0)
                     * thì vẻ ra ký tự của hình 
                     * ngược lại thì vẽ kí tự ko thuộc hình
                     */
                     if(countLoopVertical % (Vertical - 1) == 0 || ((countLoopHerizontal %(Vertical - 1) != 0) && (countLoopHerizontal % (Herizontal - 1) == 0)))
                    {
                        Console.Write(drawChars);
                    }
                    else
                    {
                        Console.Write(insideChars);
                    }
                    countLoopHerizontal++;
                }
                Console.WriteLine();
                countLoopVertical++;
            }

            // end-vd
            #endregion
            #region Vòng lặp do while
            do
            {
                // reset lại biến countLoop
                countLoop = 0;
                //vẽ từ trái qua valueNum lần
                do
                {
                    // giá trị sinh ngẫu nhiên trong khoản [minRandomValue...maxRandomValue - 1]
                    int showValue = rand.Next(minRandomValue, maxRandomValue); // kết quả hàm này trả về kiểu int !
                    // in ra giá trị của countLoop trong 8 vị trí
                    //Console.Write("{0,8}", countLoop);
                    Console.Write("{0,8}", showValue);
                    // tăng giá trị của countLoop lên 1 đơn vị
                    countLoop++;
                }while (countLoop < valueNum) ;
                // Mỗi khi hoàn thành một vòng lặp nhỏ thì  lịa xuống dòng chuẩn bị về lần tiếp theo
                Console.WriteLine();
                // tăng giá trị của countLoopTime lên 1 đơn vị
                countLoopTime++;
            } while (countLoopTime < loopTime);

            #endregion
            Console.ReadKey();
        }
    }
}
