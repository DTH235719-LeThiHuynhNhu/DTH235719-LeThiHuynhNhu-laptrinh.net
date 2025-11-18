using System.Text;

namespace Bai7
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Sử dụng constructor mặc định
            TamGiac tg1 = new TamGiac();
            tg1.HienThiThongTin();

            Console.WriteLine();

            // Sử dụng constructor có tham số
            //TamGiac tg2 = new TamGiac(3, 4, 5);
            //tg2.HienThiThongTin();
        }
    }
}