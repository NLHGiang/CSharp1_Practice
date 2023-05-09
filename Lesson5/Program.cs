using System;

namespace MyWorks.CSharp1.Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = 0, step = 1;
            int i = startNum;
            int value = 3, count = 0;

            // Khai báo mảng số nguyên
            int[] intArray = new int[] { 1, 4, 3, 6, 5, 8, 9, 0, 2 };
            int lengthOfArray = intArray.Length;

            // Hiển thị mảng
            for (; i < lengthOfArray; i += step)
            {
                Console.WriteLine("The value at position {0} = {1}", i + 1, intArray[i]);
            }

            Console.WriteLine("-----------------------------");

            // Xét mảng
            for (; i < lengthOfArray; i += step)
            {
                int temp = intArray[i];

                // Hiển thị vị trí số chẵn trong mảng
                if (temp % 2 == 0)
                {
                    Console.WriteLine("The even value at position: {0}", i + 1);
                }

                // Đếm số lượng phần tử >= 3
                if (temp >= value)
                {
                    count++;
                }
            }

            Console.WriteLine("-----------------------------");

            // Hiển thị số lượng phần tử >=3 trong mảng
            Console.WriteLine("The number of values greater than or equal to 3: {0}", count);

            Console.ReadKey();
        }
    }
}