using Bai6;

class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.Write("Nhap so luong nhan vien: ");
        n = int.Parse(Console.ReadLine());

        Employee[] arrEp = new Employee[n]; 
        for(int i=0;i<n;i++)
        {
            Console.WriteLine("Nhap nhan vien thu {0}: ",(i+1).ToString());
            arrEp[i] = new Employee();
            arrEp[i].Input();
        }
        Console.WriteLine("Danh sach nhan vien: ");
        //Console.WriteLine("Id: {0} \nName: {1} \nNamsinh: {2} \nLuong co ban: {3} \nThu nhap: {4}", ID, Name, YearofBirth, SalaryBasic, Income);

        for (int i=0;i<n;i++)
        {
            Console.WriteLine("Nhan vien thu {0} ", i + 1);
            arrEp[i].Display();
        }
        Console.ReadLine();
    }
}