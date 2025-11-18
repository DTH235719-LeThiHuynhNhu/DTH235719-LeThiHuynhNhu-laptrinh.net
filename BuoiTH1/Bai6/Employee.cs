using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Employee
    {
        private int id;
        private string name;
        private int yearofBirth;
        private double salaryLevel;
        public double salaryBasic;
    
    public Employee()
        {
            ID = 0;
            Name = "";
            YearofBirth = 0;
            SalaryLevel = 0;
            SalaryBasic = 0;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int YearofBirth
        {
            get { return yearofBirth; }
            set { yearofBirth = value; }
        }
        public double SalaryLevel
        {
            get { return salaryLevel; }
            set { salaryLevel = value; }
        }
        public double SalaryBasic
        {
            get { return salaryBasic; }
            set { salaryBasic = value; }
        }
        public double Income
        {
            get { return salaryLevel*salaryBasic; }
            set { Income= value; }
        }
        public void Input()
        {
            Console.Write("Nhap id: ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten nhan vien: ");
            Name = Console.ReadLine(); 
            Console.Write("Nhap nam sinh: ");
            YearofBirth = int.Parse(Console.ReadLine());
            Console.Write("Nhap bac luong: ");
            SalaryLevel = int.Parse(Console.ReadLine());
            Console.Write("Nhap luong co ban: ");
            SalaryBasic = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Id: {0} \nName: {1} \nNamsinh: {2} \nLuong co ban: {3} \nThu nhap: {4}", ID, Name, YearofBirth, SalaryBasic, Income);
        }
    }
}
