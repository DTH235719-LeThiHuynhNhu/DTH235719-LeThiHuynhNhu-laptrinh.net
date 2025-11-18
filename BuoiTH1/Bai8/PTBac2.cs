using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class PTBac2
    {
        // thuoc tinh
        private int Soa;
        private int Sob;
        private int Soc;

        // property
        public int soa
        {
            get { return Soa; }
            set { Soa = value; }
        }
        public int sob
        {
            get { return Sob; }
            set { Sob = value; }
        }
        public int soc
        {
            get { return Soc; }
            set { Soc = value; }
        }

        // phuong thuc khoi tao khong tham so
        public PTBac2()
        {
            Soa = 1;
            Sob = 0;
            Soc = 0;
        }

        public PTBac2(int a, int b, int c)
        {
            Soa = a;
            Sob = b;
            Soc = c;
        }

        // phuong thuc tinh nghiem
        public void TinhNghiem()
        {
            if (Soa == 0)
            {
                if (Sob == 0)
                {
                    if (Soc == 0)
                    {
                        Console.WriteLine("Phương trình có vô số nghiệm.");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình vô nghiệm.");
                    }
                }
                else
                {
                    double nghiem = -((double)Soc / Sob);
                    Console.WriteLine("Phương trình có một nghiệm: x = {0}", nghiem);
                }
            }
            else
            {
                double delta = Sob * Sob - 4 * Soa * Soc;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double nghiemKep = -Sob / (2.0 * Soa);
                    Console.WriteLine("Phương trình có nghiệm kép: x1 = x2 = {0:F2}", nghiemKep);
                }
                else
                {
                    double nghiem1 = (-Sob + Math.Sqrt(delta)) / (2 * Soa);
                    double nghiem2 = (-Sob - Math.Sqrt(delta)) / (2 * Soa);
                    Console.WriteLine("Phương trình có hai nghiệm phân biệt: x1 = {0:F2}, x2 = {1:F2}", nghiem1, nghiem2);
                }
            }
        }

        // phuong thuc hien thi
        public void HienThiKetQua()
        {
            Console.WriteLine("Phương trình: {0}x^2 + {1}x + {2} = 0", Soa, Sob, Soc);
        }

    }
}