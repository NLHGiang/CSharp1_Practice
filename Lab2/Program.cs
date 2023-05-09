using System;
using System.Text;

namespace MyWorks.CSharp1.Lab2
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

                float a, b, c;

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Giải phương trình bậc nhất");
                        Console.Write("Nhập a: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("Nhập b: ");
                        b = float.Parse(Console.ReadLine());
                        Bai1(a, b);
                        break;
                    case "2":
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine("Giải phương trình bậc hai");
                            Console.Write("Nhập a: ");
                            a = float.Parse(Console.ReadLine());
                            Console.Write("Nhập b: ");
                            b = float.Parse(Console.ReadLine());
                            Console.Write("Nhập c: ");
                            c = float.Parse(Console.ReadLine());
                            Bai2(a, b, c);
                        }
                        break;
                    case "3":
                        Bai3();
                        break;
                    case "4":
                        Console.WriteLine("Kiểm tra số nguyên tố");
                        Bai4();
                        break;
                    case "5":
                        Console.WriteLine("Bảng cửu chương");
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

        static void Bai1(float a, float b)
        {
            Console.WriteLine($"\n=> PTB1: {a}x + {b} = 0");

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("\nPHUONG TRINH VO SO NGHIEM!");
                }
                else
                {
                    Console.WriteLine("\nPHUONG TRINH VO NGHIEM!");
                }
            }
            else
            {
                double x = (double)-b / a;
                Console.WriteLine($"\nPHUONG TRINH CO MOT NGHIEM: x = {x}");
            }
        }

        static void Bai2(float a, float b, float c)
        {
            Console.WriteLine($"\n=> PTB2: {a}x^2 + {b}x + {c} = 0");

            // Nếu a = 0, PTB2 => PTB1
            if (a == 0)
            {
                Bai1(b, c);
            }
            // Nếu a != 0, giải PTB2
            else
            {
                //Tính delta
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("\nPhương trình vô nghiệm!");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"\nPhương trình có nghiệm kép là: x = {x}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"\nPhương trình có 2 nghiệm phân biệt là: x1 = {x1}; x2 = {x2}");
                }
            }

        }

        static void Bai3()
        {
            int year = 0;
            int month = 1, day = 1;

            DateTime now = DateTime.Now;
            year = now.Year;

            Console.Write("Nhập tháng: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập ngày: ");
            day = Convert.ToInt32(Console.ReadLine());

            int validDay = checkDay(year, month);
            bool isValidDate = true;
            if (month < 1 || month > 12)
            {
                isValidDate = false;
            }
            if (day < 1 || day > validDay)
            {
                isValidDate = false;
            }
            else
            {
                isValidDate = true;
            }
            Console.WriteLine();

            if (!isValidDate)
            {
                Console.WriteLine($"{day} / {month} / {year} không hợp lệ!");
                Console.WriteLine($"=> Tháng {month} có {validDay} ngày");
            }
            else
            {
                Console.WriteLine($"=> Tháng {month} có {validDay} ngày");
                Console.WriteLine($"{day} / {month} / {year} hợp lệ!");
                NextDay(year, month, day);
                PreDay(year, month, day);
            }
        }

        static int checkDay(int year, int month)
        {
            int day = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;

                case 2:
                    if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                        day = 29;
                    else
                        day = 28;
                    break;
            }
            return day;
        }

        static void NextDay(int year, int month, int day)
        {
            int minDay = 1, minMonth = 1;
            int maxDay = checkDay(year, month), maxMonth = 12;

            if (day == maxDay)
            {
                day = minDay;
                if (month == maxMonth)
                {
                    month = minMonth;
                    year++;
                }
                else
                {
                    month++;
                }
            }
            else
            {
                day++;
            }

            Console.WriteLine($"Ngày kế tiếp là {day} / {month} / {year}");
        }

        static void PreDay(int year, int month, int day)
        {
            int minDay = 1, minMonth = 1;
            int maxMonth = 12;

            if (day == minDay)
            {
                if (month == minMonth)
                {
                    year--;
                    month = maxMonth;
                    day = checkDay(year, month);
                }
                else
                {
                    month--;
                    day = checkDay(year, month);
                }
            }
            else
            {
                day--;
            }
            Console.WriteLine($"Ngày trước đó là {day} / {month} / {year}");
        }

        static void Bai4()
        {
            Console.Write("Nhập n = ");
            int N = Convert.ToInt32(Console.ReadLine());

            bool isPrimeNumber = true;

            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    isPrimeNumber = false;
                    break;
                }
            }
            if (!isPrimeNumber)
            {
                Console.WriteLine($"{N} không phải số nguyên tố");
            }
            else
            {
                Console.WriteLine($"{N} là số nguyên tố");
            }
        }

        static void Bai5()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\n-----BANG CUU CHUONG {i}-----\n", i);
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"\t{i} x {j} = {i * j}");
                }
            }
        }
    }
}