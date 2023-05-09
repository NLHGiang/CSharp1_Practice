using System;
using System.Collections;
using System.Linq;


namespace MyWorks.CSharp1.Test4
{
    public class Program
    {
        /*
        18. Bách khoa toàn thư về bồ cũ(FpolyHN)
            Nhập tên:
            Nhập tuổi:
            Nhập số đo vòng 1:
        => Tuổi TB của tất cả bồ cũ
        => Trung bình số đo vòng 1 của tất cả bồ cũ
        => In ra tên của bồ có tuổi chia hết cho 2
        => In ra tuổi của bồ có vòng 1 lớn nhất
        => In ra vòng 1 của người có tên dài nhất(tìm hiểu)
        */
        public class MyEx
        {
            public string fullName;
            public byte age;
            public int sizeChest;

            public void InputEx(string fullName, byte age, int sizeChest)
            {
                this.fullName = fullName;
                this.age = age;
                this.sizeChest = sizeChest;
            }

            public void OutputEx()
            {
                Console.WriteLine($"{this.fullName} - {this.age} - {this.sizeChest}(cm)");
            }

            public string GetLastName()
            {
                var name = this.fullName.Split(' ');
                string lastName = name[name.Length - 1];
                return lastName;
            }
        }

        static void Main(string[] args)
        {
            ArrayList ExList = new ArrayList();

            Console.WriteLine("Enter number of your ex:");
            int numEx = Convert.ToInt32(Console.ReadLine());

            // Nhập tt ex
            Console.WriteLine("\nINPUT your ex's information:");
            InputExList(ref ExList, numEx);

            // Xuất tt ex
            Console.WriteLine("\nOUTPUT your ex's information:");
            OutputExList(ExList, numEx);

            // Tính tuổi TB, vòng 1 TB
            float avgAge = AverageAge(ExList, numEx);
            float avgSize = AverageSize(ExList, numEx);

            Console.WriteLine($"\nAVERAGE of your exes's age = {avgAge}");
            Console.WriteLine($"AVERAGE of your exes's chest size = {avgSize}");

            // Xuất tên ex có tuổi chia hết cho 2
            Console.WriteLine("\nYour ex having age % 2 == 0:");
            AgeInCondition(ExList, numEx);

            // Xuất tuổi của ex có vòng 1 lớn nhất
            byte ageMaxSize = AgeOfMaxSize(ExList, numEx);
            Console.WriteLine($"\nYour ex's AGE having MaxSize: {ageMaxSize}");

            // Xuất vòng 1 người có tên dài nhất(lastname)
            int sizeMaxName = SizeOfMaxName(ExList, numEx);
            Console.WriteLine($"\nYour ex's SIZE having MaxName: {sizeMaxName}");

            Console.ReadKey();

        }

        static void InputExList(ref ArrayList ExList, int numEx)
        {
            for (int i = 0; i < numEx; i++)
            {
                MyEx ex = new MyEx();
                Console.WriteLine($"\n*Your ex {i + 1}");
                Console.Write("Full name: ");
                ex.fullName = Console.ReadLine();
                Console.Write("Age: ");
                ex.age = Convert.ToByte(Console.ReadLine());
                Console.Write("Chest size(cm): ");
                ex.sizeChest = Convert.ToInt32(Console.ReadLine());
                ex.InputEx(ex.fullName, ex.age, ex.sizeChest);

                ExList.Add(ex);
            }
        }
        static void OutputExList(ArrayList ExList, int numEx)
        {
            for (int i = 0; i < numEx; i++)
            {
                MyEx ex = (MyEx)ExList[i];
                ex.OutputEx();
            }
        }
        static float AverageAge(ArrayList ExList, int numEx)
        {
            float avgAge = 0.0f;
            int sumAge = 0;

            for (int i = 0; i < numEx; i++)
            {
                MyEx ex = (MyEx)ExList[i];
                sumAge += ex.age;
            }
            avgAge = (float)sumAge / numEx;
            return avgAge;
        }
        static float AverageSize(ArrayList ExList, int numEx)
        {
            float avgSize = 0.0f;
            int sumSize = 0;

            for (int i = 0; i < numEx; i++)
            {
                MyEx ex = (MyEx)ExList[i];
                sumSize += ex.sizeChest;
            }
            avgSize = (float)sumSize / numEx;
            return avgSize;
        }
        static void AgeInCondition(ArrayList ExList, int numEx)
        {
            for (int i = 0; i < numEx; i++)
            {
                MyEx ex = (MyEx)ExList[i];
                if (ex.age % 2 == 0)
                {
                    Console.WriteLine(ex.fullName + " ");
                }
            }
        }
        static byte AgeOfMaxSize(ArrayList ExList, int numEx)
        {
            int maxSize = 0;
            byte ageMaxSize = 0;
            for (int i = 0; i < numEx; i++)
            {
                MyEx ex = (MyEx)ExList[i];
                if (maxSize < ex.sizeChest)
                {
                    maxSize = ex.sizeChest;
                    ageMaxSize = ex.age;
                }
            }
            return ageMaxSize;
        }
        static int SizeOfMaxName(ArrayList ExList, int numEx)
        {
            int sizeChest = 0;
            int maxName = 0;
            for (int i = 0; i < numEx; i++)
            {
                MyEx ex = (MyEx)ExList[i];
                if (maxName < ex.GetLastName().Length)
                {
                    maxName = ex.GetLastName().Length;
                    sizeChest = ex.sizeChest;
                }
            }
            return sizeChest;
        }

    }
}