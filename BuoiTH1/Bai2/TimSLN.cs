using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class TimSLN
    {
        public int NHapSo()
        {
            int so;
            so=Convert.ToInt32(Console.ReadLine());
            return so;
        }
        public int TimMax(int n)
        {
            int max, i, tam;
            max = 0;
            i = 0;
            do
            {
                Console.Write("Nhap so thu {0}: ", i + 1);
                tam =Convert.ToInt32(Console.ReadLine());
                if(max<tam)
                    max = tam;
                i++;
            } while (i < n);
            return max;
        }
    }
}
