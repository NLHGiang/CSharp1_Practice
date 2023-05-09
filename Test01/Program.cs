using System;

namespace MyWorks.CSharp1.Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Kiểm tra mảng zigzag: 
            *Nhập 1 mảng
            *Kiểm tra xem nó có phải mảng zigzag hay không            
                *Điều kiệu để mảng là zigzag 
                    *Với 3 phần tử liền nhau bất kì: 
                     phần tử ở giữa luôn nhỏ hơn 
                     hoặc lớn hơn cả 2 phần tử còn lại.                    
                    *Trạng thái lớn hơn, nhỏ hơn này là xen kẽ.
            *VD: 1,5,3,8,6,13 là mảng zigzag.
            */

            // Khai báo mảng gồm các phần tử
            int[] arr = new int[]
                {2,5,4,6,2,8,3,9,7,8};

            Console.WriteLine($"Length of array = {arr.Length}");

            // Xuất mảng
            Console.WriteLine("Output array:");
            for (int count = 0; count < arr.Length; count++)
            {
                Console.WriteLine($"arr[{count}] = {arr[count]}");
            }

            // Kiểm tra zigzag?
            bool zigzag = checkZigzag(arr);


            Console.WriteLine(zigzag);
            Console.ReadKey();
        }

        // Hàm kiểm tra mảng có phải zigzag không
        static bool checkZigzag(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                // Kiểm tra lần xét thứ i
                Console.WriteLine($"Times: {i}");

                int j = i + 1;
                int k = i - 1;

                if (arr[i] > arr[k])
                {
                    if (arr[i] > arr[j])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (arr[i] < arr[k])
                {
                    if (arr[i] < arr[j])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}