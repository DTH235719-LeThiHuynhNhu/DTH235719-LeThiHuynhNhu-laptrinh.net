using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TimSoLonNhat sln = new TimSoLonNhat();
            int a, b, c, max;
            Console.Write("Nhap a: ");
            a = sln.NhapSo();
            Console.Write("Nhap b: ");
            b = sln.NhapSo();
            Console.Write("Nhap c: ");
            c = sln.NhapSo();

            max = sln.TimMax(a, b, c);
            Console.WriteLine("So lon nhat trong 3 so la {0}", max);
            Console.ReadLine();
        }
    }
}
