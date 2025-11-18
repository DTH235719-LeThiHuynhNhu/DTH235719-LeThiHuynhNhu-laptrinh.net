using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class MangSoNguyen
    {
        public int NhapSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        }
        public void NhapMang(int[] a)
        {
            for(int i=0;i<a.Length; i++)
            {
                Console.Write("a[{0}]: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0}  ", a[i]);
        }
        public int TimSoLonNhat(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
        public int TimSoNhoNhat(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max > a[i])
                    max = a[i];
            return max;
        }
        public int Tong(int[] a)
        {
            int t = 0;

            for (int i = 0; i < a.Length; i++)
                t += a[i];
            return t;
        }
        public void SapXep(int[] a)
        {
            int t = 0;
            for (int i = 0; i < a.Length; i++)
                for (int j = i + 1; j < a.Length; j++)
                    if (a[i] > a[j])
                        {
                            t = a[i];
                            a[i] = a[j];
                            a[j] = t;
                        }
        }
    }
}
