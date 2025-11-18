using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TimSLN sln = new TimSLN();
            int n;
            Console.Write("Nhập n = ");
            n = sln.NHapSo();
            Console.WriteLine("Số lớn nhất vừa nhập là {0} ", sln.TimMax(n));
            Console.ReadLine();
        }

    }
}
