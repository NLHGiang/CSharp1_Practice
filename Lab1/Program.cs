using System;
using System.Text;
using System.Linq;

namespace MyWorks.CSharp1.Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            do
            {
                Menu();
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Bai1();
                        break;
                    case "2":
                        Bai2();
                        break;
                    case "3":
                        Bai3();
                        break;
                    case "4":
                        Bai4();
                        break;
                    case "5":
                        Bai5();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("<!> Invalid choice. Enter your choice again (0-5) !");
                        break;
                }
            } while (true);

            Console.ReadKey();
        }

        static void Menu()
        {
            Console.WriteLine("\no=====MENU=====o");
            Console.WriteLine("|   1. Bài 1   |");
            Console.WriteLine("|   2. Bài 2   |");
            Console.WriteLine("|   3. Bài 3   |");
            Console.WriteLine("|   4. Bài 4   |");
            Console.WriteLine("|   5. Bài 5   |");
            Console.WriteLine("|   0. Exit    |");
            Console.WriteLine("o==============o");
        }

        static void Bai1()
        {
            Console.WriteLine("Fpoly chào mừng bạn đến với môn C#");
        }

        static void Bai2()
        {
            Console.WriteLine("Nhập cạnh thứ nhất của hình chữ nhật");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập cạnh thứ hai của hình chữ nhật");
            int side2 = Convert.ToInt32(Console.ReadLine());

            int perimeter = (side1 + side2) * 2;
            int area = side1 * side2;
            int minSide = Math.Min(side1, side2);

            Console.WriteLine($"Chu vi hình chữ nhật({side1};{side2}) = {perimeter}");
            Console.WriteLine($"Diện tích hình chữ nhật({side1};{side2}) = {area}");
            Console.WriteLine($"Cạnh nhỏ nhất hình chữ nhật: {minSide}");
        }

        static void Bai3()
        {
            Console.WriteLine("Nhập cạnh của khối lập phương");
            int side = Convert.ToInt32(Console.ReadLine());
            float side2 = Convert.ToSingle(Console.ReadLine());
            float side3 = Convert.ToSingle(Console.ReadLine());


            float volume = (float)Math.Pow(side, 3);
            Console.WriteLine($"Thể tích khối lập phương({side};{side};{side}) = {volume}");
        }

        static void Bai4()
        {
            Console.WriteLine("Nhập chiều dài của ống dây (m)");
            float l = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhập số vòng dây của ống dây (vòng)");
            float N = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhập đường kính của mỗi vòng dây (m)");
            float d = Convert.ToSingle(Console.ReadLine());

            double S = Math.PI * Math.Pow((d / 2), 2);
            double L = 4 * Math.PI * Math.Pow(10, -7)
                * Math.Pow(N, 2) * S / l;

            Console.WriteLine("Cuộn dây " +
                $"l={l}(m); N={N}(vòng); d={d}(m) có độ tự cảm = {L}(H)");
        }

        static void Bai5()
        {
            /* 2 cách tính S hình thoi
             * C1(2 đường chéo): S = (d1*d2)/2
             * C2(cạnh,chiều cao): S = a*h
             */
            Console.WriteLine("Nhập đường chéo thứ nhất của hình thoi");
            int diagonal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập đường chéo thứ hai của hình thoi");
            int diagonal2 = Convert.ToInt32(Console.ReadLine());

            int area = (diagonal1 * diagonal2) / 2;

            Console.WriteLine($"Hình thoi có 2 đường chéo ({diagonal1};{diagonal2})" +
                $"có diện tích = {area}");
        }
    }
}