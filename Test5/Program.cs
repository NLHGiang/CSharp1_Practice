using System;

namespace MyWorks.CSharp1.Test5
{
    public class Program
    {
        /*
        Bài 1: Nhập 1 mảng số bất kì
            *sử dụng vòng lặp để in ra tất cả phần tử chẵn trong mảng
        Bài 2: Nhập 1 chuỗi bất kì
            *đếm số kí tự trong chuỗi là chữ số
            *Gợi ý: Sử dụng Char.IsNumber() hoặc mã ASCII
        Bài 3: Giải phương trình bậc 2: 
            *ax ^ 2 + bx + c 
            *với a, b, c là các số được nhập từ bàn phím.
        Bài 4: Tính tổng các chữ số lẻ trong một số nguyên. 
            *Nếu không có chữ số lẻ nào thì in ra kết quả - 1.
            *Ví dụ
                1234 => 4
                - 113564 => 10
                2468 => -1
        Mỗi bài viết 1 hàm riêng, sử dụng switch-case trong main
        */
        static void Main(string[] args)
        {
            do
            {
                Menu();

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":   // Bài 1
                        EvenValues();
                        break;
                    case "2":   // Bài 2
                        CountNumber();
                        break;
                    case "3":   // Bài 3
                        PTB2();
                        break;
                    case "4":   // Bài 4
                        SumOddNumber();
                        break;
                    case "0":   // Thoát CT
                        return;
                    default:    // Lựa chọn không hợp lệ => báo lỗi
                        Console.WriteLine("<!> Invalid choice! Please enter your choice again!");
                        break;
                }
            } while (true);
        }

        // Menu CT
        static void Menu()
        {
            Console.WriteLine("\no======MENU======o");
            Console.WriteLine("|   1.  Bai 1    |");
            Console.WriteLine("|   2.  Bai 2    |");
            Console.WriteLine("|   3.  Bai 3    |");
            Console.WriteLine("|   4.  Bai 4    |");
            Console.WriteLine("|   0.  EXIT     |");
            Console.WriteLine("o================o");
            Console.Write("Enter your choice: ");
        }

        // Bài 1
        static void EvenValues()
        {
            Console.WriteLine("Enter number of values in array");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arrayLength];

            Console.WriteLine("Enter your array");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Position {i + 1}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("The even values in your array:");
            for (int i = 0; i < arrayLength; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

        // Bài 2
        static void CountNumber()
        {
            Console.WriteLine("Enter your string");
            string yourString = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < yourString.Length; i++)
            {
                if (Char.IsNumber(yourString[i]))
                {
                    count++;
                }
            }

            Console.WriteLine($"The number of characters in string as number : {count}");
        }

        // Bài 3
        static void PTB2()
        {
            Console.Write("\nEnter a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("\nEnter b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("\nEnter c: ");
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine($"=> \n{a}x^2 + {b}x + {c} = 0");

            // Nếu a = 0, PTB2 => PTB1
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
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
                    double x = (double)-c / b;
                    Console.WriteLine($"\nPHUONG TRINH NGHIEM DUY NHAT: x = {x}");
                }
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
            Console.ReadKey();
        }

        // Bài 4
        static void SumOddNumber()
        {
            Console.WriteLine("Enter your number");
            int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            int sum = 0;
            int temp = num;

            while (temp != 0)
            {
                if (temp % 2 != 0)
                {
                    sum = sum + temp % 10;
                }
                //Console.WriteLine($"Temp = {temp}");
                //Console.WriteLine($"Sum = {sum}");
                temp = temp / 10;
            }

            /*
            string numString = num.ToString();
            int numStringLength = numString.Length;
            for (int i = 0; i< numStringLength; i++)
            {
                if (temp % 2 != 0)
                {
                    sum = sum + temp % 10;
                }
                temp = temp / 10;
            }
            */

            if (sum == 0)
            {
                sum = -1;
            }

            Console.WriteLine($"The summary of odd numbers = {sum}");
        }
    }
}