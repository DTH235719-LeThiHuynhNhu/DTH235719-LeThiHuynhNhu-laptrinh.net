using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class TamGiac
    {
        private int canh1;
        private int canh2;
        private int canh3;
        private int chuvi;
        private string loaiTG;
        private float dientich;
        /*
        public TamGiac(int n)
        {
            Canh1 = 0;
            Canh2 = 0;
            Canh3 = 0;
            Chuvi = 0;
            LoaiTG = "";
            Dientich = 0;
        }
        */
        public int Canh1
        { 
            get { return canh1; } 
            set { canh1 = value; }
        }
        public int Canh2
        { 
            get { return canh2; } 
            set { canh2 = value;} 
        }
        public int Canh3
        {
            get { return canh3; }
            set { canh3 = value;}
        }
        public int Chuvi
        {
            get { return chuvi; } 
        }
        public string LoaiTG
        {
            get { return loaiTG; }
        }
        public float Dientich
        {
            get { return dientich; }
        }
         
        public TamGiac()
        {
            canh1 = 2;
            canh2 = 3;
            canh3 = -5;
            TinhChuVi();
            TinhDienTich();
            XDTamGiac();
        }
        public TamGiac(int a, int b, int c)
        {
            canh1 = a;
            canh2 = b;
            canh3 = c;
            TinhChuVi();
            TinhDienTich();
            XDTamGiac();
        }
        public bool TamGiacHopLe()
        {
            return (canh1 + canh2 > canh3) && (canh1 + canh3 > canh2) && (canh2 + canh3 > canh1);
        }
        public void TinhChuVi()
        {
            if (TamGiacHopLe()) chuvi = canh1 + canh2 + canh3;
            else chuvi = 0;
        }
        public void TinhDienTich()
        {
            if (TamGiacHopLe())
            {
                float p = chuvi / 2.0f;
                dientich = (float)Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
            }
            else
            {
                dientich = 0;
            }
        }
        public void XDTamGiac()
        {
            if(!TamGiacHopLe())
            {
                loaiTG = "Ko la Tam Giac!!!";
            }
            else if(canh1==canh2 || canh2==canh3 || canh1==canh3)
            {
                loaiTG = "Day la Tam GIac Can";
            }
            else if(canh1==canh2 && canh2==canh3 && canh1==canh3)
            {
                loaiTG = "Day la TAm Giac Deu";
            }
            else if(canh1*canh1+canh2*canh2==canh3*canh3 || canh2*canh2+canh3*canh3==canh1*canh1 || canh1*canh1+canh3*canh3==canh2*canh2)
            {
                loaiTG = " Day la Tam Giac Vuong";
            }
            else
            {
                loaiTG = "Day la Tam Giac Thuong";
            }
        }
        public void HienThiThongTin()
        {
            Console.Write("\n=== Thông tin tam giác ===\n");
            Console.WriteLine("Canh 1: {0}", canh1);
            Console.WriteLine("Canh 2: {0}", canh2);
            Console.WriteLine("Canh 3: {0}", canh3);

            if (TamGiacHopLe())
            {
                Console.WriteLine("Chu vi: {0}", chuvi);
                Console.WriteLine("Dien tich: {0}", dientich);
                Console.WriteLine("Loai tam giac: {0}", loaiTG);
            }
            else
            {
                Console.WriteLine("Loai tam giac: {0}", loaiTG);
            }
            Console.WriteLine("--------------------------");
        }
    }
}
