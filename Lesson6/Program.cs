using System;

namespace MyWorks.CSharp1.Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numberOfContainer = 5;
            uint[] Container = new uint[numberOfContainer];
            string unit = "Ton";

            //Nhập số lượng hàng trong từng container
            Console.WriteLine("\n*Enter amount of load in each container:");
            InputArray(ref Container, ref numberOfContainer);

            // Hiển thị số lượng hàng trong từng container
            OutputArray(Container, numberOfContainer, unit);

            // Hiển thị maxLoad và container có maxLoad
            MaxLoad(Container, numberOfContainer);

            // Hiển thị tổng lượng hàng tất cả container
            uint sumLoad = SumLoad(Container, numberOfContainer);
            Console.WriteLine($"\n*The total load in {numberOfContainer} containers is {sumLoad}");

            // Thay thế giá trị trong khoảng (10;20) = 1 (dùng foreach)
            int minNum = 10;
            int maxNum = 20;
            uint valueChange = 1;
            ChangeArray(ref Container, ref numberOfContainer, minNum, maxNum, valueChange);

            // Hiển thị số lượng hàng trong từng container sau thay đổi
            Console.WriteLine("\n*The amount of load in containers after changing:");
            OutputArray(Container, numberOfContainer, unit);

            // In toàn bộ giá trị != 1 (dùng foreach)
            int valueCompare = 1;

            Console.WriteLine($"*The amount of load != {valueCompare}:");
            OutputAfterCompare(Container, valueCompare);

            Console.ReadKey();
        }

        // Hàm nhập array
        static void InputArray(ref uint[] Container, ref uint numberOfContainer)
        {
            for (int i = 0; i < numberOfContainer; i++)
            {
                Console.Write($"Container {i + 1}  :  ");
                Container[i] = Convert.ToUInt32(Console.ReadLine());
            }
        }

        // Hàm xuất array
        static void OutputArray(uint[] Container, uint numberOfContainer, string unit)
        {
            Console.WriteLine("\no-----------------------------------------o");
            Console.WriteLine($"|   Container   | Amount of Load |  Unit  |");
            Console.WriteLine("o-----------------------------------------o");

            for (int i = 0; i < numberOfContainer; i++)
            {
                Console.WriteLine($"|\t{i + 1}\t|\t{Container[i]}\t |   {unit}  |");
                Console.WriteLine("+-----------------------------------------+");
            }
        }

        // Hàm tìm maxLoad và maxLoadPosition
        static void MaxLoad(uint[] Container, uint numberOfContainer)
        {
            uint maxLoad = Container[0];
            uint maxLoadPosition = 1;

            for (int i = 0; i < numberOfContainer; i++)
            {
                if (Container[i] > maxLoad)
                {
                    maxLoad = Container[i];
                    maxLoadPosition = (uint)i + 1;
                }
            }

            Console.WriteLine($"\n*The maximum load is {maxLoad}");
            Console.WriteLine($"*The container having the maximum load is Container {maxLoadPosition}");
        }

        // Hàm tính tổng Load
        static uint SumLoad(uint[] Container, uint numberOfContainer)
        {
            uint sumLoad = 0;

            for (int i = 0; i < numberOfContainer; i++)
            {
                sumLoad += Container[i];
            }
            return sumLoad;
        }

        // Hàm thay đổi giá trị  
        static void ChangeArray(ref uint[] Container, ref uint numberOfContainer, int minNum, int maxNum, uint valueChange)
        {
            for (int i = 0; i < numberOfContainer; i++)
            {
                if (minNum < Container[i] && Container[i] < maxNum)
                {
                    Container[i] = valueChange;
                }
            }
        }

        // Hàm xuất giá trị != valueCompare
        static void OutputAfterCompare(uint[] Container, int valueCompare)
        {
            foreach (var item in Container)
            {
                if (item != valueCompare)
                {
                    Console.Write($" {item} ");
                }
            }
        }
    }
}