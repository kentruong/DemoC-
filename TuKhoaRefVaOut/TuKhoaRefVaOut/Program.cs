using System;
using System.Text;
namespace TuKhoaRefVaOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int value = 5;
            int value2;

            Console.WriteLine("Ko có ref - Giá trị trước khi tăng là : {0}" , value);
            KoCoRef(value);
            Console.WriteLine("Ko có ref - Giá trị sau khi tăng là : {0}", value);
            Console.WriteLine("Có ref - Giá trị trước khi tăng là : {0}", value);
            CoRef(ref value);
            Console.WriteLine("Có ref  - Giá trị sau khi tăng là : {0}", value);
            demoOut(out value2);
            Console.WriteLine("Out  - Giá trị value2 là : {0}", value2);
            Console.ReadLine();
        }
        static void KoCoRef(int value)
        {
            value++;
        }
        static void CoRef(ref int value)
        {
            value++;
        }
        static void demoOut(out int value2)
        {
            value2 = 0;
            value2++;
        }
    }
}
