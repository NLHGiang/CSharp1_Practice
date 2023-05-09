using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorks.CSharp1.Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            Console.WriteLine("BT1: Viết hàm kiểm tra 1 số có là số nguyên tố hay không?");

            //IsPrime --> là hàm được sử dụng để kiểm tra số nguyên tố 
            Console.Write("\n Hãy nhập vào 1 số: ");
            int n = int.Parse(Console.ReadLine());
            bool IsPrime = true;

            if (n < 2)
            {
                IsPrime = false;
            }
            else
            {
                for (int i = 2; i < n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
            }
            if (IsPrime)
            {
                Console.Write($"{n} : là số nguyên tố");
            }
            else
            {
                Console.Write($"{n} : không phải là số nguyên tố");
            }
            
            Console.WriteLine();
            Console.ReadKey();


            Console.WriteLine("BT2: Không dùng câu lệnh if - else , chỉ dùng vòng lặp," +
                "\n tính tổng của tất cả các số lẻ trong 1 mảng");

            int count = 0;
            Console.Write("\n Nhập vào số ptử n của mảng: ");
            count = Convert.ToInt32(Console.ReadLine());

            //tạo mảng
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Hãy nhập ptử thứ {i+1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //khai báo biến sum = 0 để lưu kết quả phép tính
            int sum = 0;

            //sử dụng vòng lặp for để lặp và tính tổng các số lẻ của mảng
/*            for (int i = 1; i <= count; i += 2)
            {
                Console.Write(arr[i] + " ");
                sum += arr[i];
            }
*/
            foreach(int values in arr)
            {
                string valueOdd = (values % 2 != 0) ? $" {values} ": null;
                Console.Write(valueOdd);
                sum = (values % 2 != 0) ? sum+values : sum;
                continue;
            }

            //hiển thị sum ra màn hình
            Console.Write($"\nTổng các số lẻ của mảng gồm {count} ptử là : {sum}");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("BT3: Nhập các hệ số a, b, c của phương trình bậc 2 dạng:" +
                "\n ax^2 + bx + c = 0, giải phương trình đó.");

            //khai báo biến x1, x2 là nghiệm của phương trình và biến delta
            double x, x1, x2, delta;
            //khai báo và yêu cầu người dùng nhập vào ba số a, b, c
            Console.Write("\n Nhập vào số a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhập vào số b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhập vào số c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            //hiển thị phương trình bậc hai mà người dùng vừa nhập dưới dạng ax^2 + bx + c = 0
            Console.WriteLine("\n Phương trình bậc hai vừa nhập là: {0}x^2 + {1}x + {2} = 0", a, b, c);
            //nếu a = 0 thì phương trình bậc hai trở thành phương trình bậc nhất
            if (a == 0)
            {
                //ta giải phương trình bậc nhất bx + c = 0 ---> x = -c/b
                if (b == 0)
                {
                    //nếu b = 0 và c = 0 thì phương trình vô số nghiệm
                    if (c == 0)
                    {
                        Console.WriteLine("\n Phương trình có vô số nghiệm!");
                    }
                    //nếu b = 0 và c != 0 thì phương trình vô nghiệm
                    else
                    {
                        Console.WriteLine("\n Phương trình vô nghiệm!");
                    }
                }
                else
                {
                    x = (double)-c / b;
                    //Sử dụng phương thứ Math.Round() để làm tròn kết quả lên 2 số thập phân
                    Console.WriteLine("\n Phuong trinh co nghiem duy nhat x = {0}", Math.Round(x, 2));
                }
            }
            //nếu a != 0 thì ta bắt đầu giải phương trình bậc hai
            else
            {
                //tính delta
                delta = Math.Pow(b, 2) - 4 * a * c;
                //kiểm tra nếu delta < 0 thì phương trình vô nghiệm
                if (delta < 0)
                {
                    Console.WriteLine("\n Phương trình vô nghiệm!");
                }
                //nếu delta = 0 thì phương trình có nghiệm kép
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    Console.WriteLine("\n Phương trình có nghiệm kép là: x1 = x2 = {0}", x1);
                }
                //nếu delta > 0 thì phuong trình có hai nghiệm phân biệt
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("\n Phương trình có 2 nghiệm phân biệt là: \n X1 = {0}\n X2 = {1}", x1, x2);
                }
            }


        }
    }
}
