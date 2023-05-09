using System;
using System.Collections;

namespace MyWorks.CSharp1.Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Viết hàm tính tổng các chữ số của 1 số nguyên bất kì(kể cả số âm).
             * Input: số nguyên numInteger (VD: abcd)
             * Do: abcd => a;b;c;d (numInteger<0 => a<0 và ngược lại)
             * Output: a+b+c+d
             */
            Console.WriteLine("Nhập số nguyên");
            string numInteger = Console.ReadLine();
            int arrlength = numInteger.Length;
            int sum = 0;
            int startNum = 0;
            int value = 1;

            // Kiểm tra dấu của số nguyên
            if (numInteger[0] == '-')
            {
                startNum = 1;
                value = -1;
                sum = Sum(numInteger, startNum, sum, arrlength, value);
            }
            else
            {
                sum = Sum(numInteger, startNum, sum, arrlength, value);
            }

            // In tổng các chữ số của số nguyên đã nhập ra màn hình
            Console.WriteLine($"Tong = {sum}");
            Console.ReadKey();
        }

        // Hàm tính tổng các chữ số của số nguyên đã nhập
        static int Sum(string numInteger, int startNum, int sum, int arrlength, int value)
        {
            // Khai báo mảng chứa các phần tử là các chữ số của số nguyên đã nhập
            ArrayList arrInteger = new ArrayList();

            // Nhập dữ liệu vào mảng và tính tổng các phần tử
            for (int i = startNum; i < arrlength; i++)
            {
                int num = int.Parse($"{numInteger[i]}");

                // Dấu của chữ số đầu tiên = dấu của số nguyên
                if (i == startNum)
                {
                    num = num * value;
                }

                sum += num;
                arrInteger.Add(num);
            }

            // Kiểm tra kiểu dữ liệu các phần tử trong mảng arrInteger
            for (int i = 0; i < arrInteger.Count; i++)
            {
                Console.WriteLine(arrInteger[i] + " => " + arrInteger[i].GetType());
            }

            return sum;
        }
    }
}