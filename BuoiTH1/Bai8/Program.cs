namespace Bai8
{
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Sử dụng constructor mặc định
            PTBac2 pt1 = new PTBac2();
            pt1.HienThiKetQua();
            pt1.TinhNghiem();

            Console.WriteLine();

            // Constructor có nghiệm phân biệt
            PTBac2 pt2 = new PTBac2(1, -3, 2);
            pt2.HienThiKetQua();
            pt2.TinhNghiem();

            Console.WriteLine();

            // Constructor có nghiệm phức
            PTBac2 pt3 = new PTBac2(1, 2, 5);
            pt3.HienThiKetQua();
            pt3.TinhNghiem();
        }
    }
}