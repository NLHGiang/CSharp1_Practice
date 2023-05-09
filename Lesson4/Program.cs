using System;

namespace MyWorks.CSharp1.Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Người dùng nhập hệ số a,b,c
                Console.Write("Nhap he so a = ");
                float a = Convert.ToSingle(Console.ReadLine());
                Console.Write("Nhap he so b = ");
                float b = Convert.ToSingle(Console.ReadLine());
                Console.Write("Nhap he so c = ");
                float c = Convert.ToSingle(Console.ReadLine());

                // Kiểm tra điều kiện của hệ số a
                if (a == 0)
                {
                    Console.WriteLine("PHUONG TRINH TRO VE PHUONG TRINH BAC NHAT");
                    float x = -c / b;
                    Console.WriteLine("PHUONG TRINH CO MOT NGHIEM : x = " + x);
                }
                else
                {
                    // Tính delta
                    float delta = (float)Math.Pow(b, 2) - 4 * a * c;
                    Console.WriteLine("delta = " + delta);

                    // Kiểm tra điều kiện delta
                    if (delta < 0)
                    {
                        Console.WriteLine("PHUONG TRINH VO NGHIEM");
                    }
                    else if (delta == 0)
                    {
                        float x = -b / (2 * a);
                        Console.WriteLine("PHUONG TRINH CO MOT NGHIEM KEP: x = " + x);
                    }
                    else
                    {
                        float x1 = (float)(-b + Math.Sqrt(delta)) / (2 * a);
                        float x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("PHUONG TRINH CO 2 NGHIEM PHAN BIET: x1 = {0}; x2 = {1}", x1, x2);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}