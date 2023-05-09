using System;
using System.Collections;

namespace MyWorks.CSharp1.Lesson9
{
    class Program
    {
        /* 
         * tạo class sinh viên chứa các thông tin : 
         *mã sv, tên sv, điểm : điểm C#, điểm javasc, 
         *Tạo các phương thức tăng , giảm điểm và in ra thông tin sv
         *Trong hàm main : tạo ra 1 mảng khoảng 10 sv và cho chứa nó trong 1 mảng
         *Nhập vào từ bàn phím các thông tin của sv và nhập xong in ra dưới dạng bảng
         *Bonus: Sử dụng ArrayList
	    *Bonus: Cho phép người dùng nhập liên tục, nhấn ESC để thoát nhập
        */

        public class Student
        {
            // Property
            public string id, fullName;
            public float scoreCsharp, scoreJS;

            // Constructor không chứa tham số
            public Student()
            {
                this.id = "null";
                this.fullName = "null";
                this.scoreCsharp = 0.0f;
                this.scoreJS = 0.0f;
            }

            // Constructor chứa tham số
            public Student(string id, string fullName, float scoreCsharp, float scoreJS)
            {
                this.id = id;
                this.fullName = fullName;
                this.scoreCsharp = scoreCsharp;
                this.scoreJS = scoreJS;
            }

            // Method tăng điểm
            public void IncreaseScore()
            {
                this.scoreCsharp++;
                this.scoreJS++;
            }

            // Method giảm điểm
            public void DecreaseScore()
            {
                this.scoreCsharp--;
                this.scoreJS--;
            }

            // Method xuất TTSV
            public void OutputStudent()
            {
                Console.WriteLine($"|\t{this.id}\t|\t    {this.fullName}    \t|\t{this.scoreCsharp}\t| \t{this.scoreJS}\t |");
                Console.WriteLine("+------------------------------------------------------------------------+");
            }
        }

        static void Main(string[] args)
        {
            // Khai báo mảng SV chứa numberStu phần tử
            int numberStu = 0;
            //Khai báo ArrayList stuList
            ArrayList stuList = new ArrayList();

            // Nhập TTSV
            Console.Write("* INPUT STUDENT *");
            InputStudent(ref stuList, numberStu);

            do
            {
                PrintMenu();
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":     // Thêm TTSV
                        Console.Write("* INSERT STUDENT *");
                        InsertStudent(ref stuList);
                        break;
                    case "2":     // Xuất TTSV
                        Console.Write("* OUTPUT STUDENT *");
                        numberStu = stuList.Count;
                        OutputStudent(stuList, numberStu);
                        break;
                    case "0":     // Thoát chương trình
                        return;
                    default:    // Báo lỗi khi người dùng nhập lựa chọn không hợp lệ
                        Console.WriteLine("<!> Invalid choice. Enter your choice again (0-2)!");
                        break;
                }

            } while (true);

            Console.ReadKey();
        }

        // Hàm hiển thị menu
        static void PrintMenu()
        {
            Console.WriteLine("\n+========MENU========+");
            Console.WriteLine("+ 1. Insert Student  +");
            Console.WriteLine("+ 2. Output Student  +");
            Console.WriteLine("+ 0. Exit            +");
            Console.WriteLine("+====================+");
            Console.Write("Enter your choice: ");
        }

        // Hàm nhập TTSV
        static void InputStudent(ref ArrayList stuList, int numberStu)
        {
            do
            {
                numberStu++;
                Console.WriteLine($"\nEnter student {numberStu}");
                Console.Write("ID: ");

                // Kiểm tra người dùng có nhấn ESC không
                var checkESC = Console.ReadKey().Key;

                if (checkESC == ConsoleKey.Escape)
                {
                    Console.WriteLine("0null");
                    break;
                }
                else
                {
                    string id = (checkESC + Console.ReadLine()).ToUpper();
                    Console.Write("Fullname: ");
                    string fullName = Console.ReadLine();
                    Console.Write("Score C#: ");
                    float scoreCsharp = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Score JavaScript: ");
                    float scoreJS = Convert.ToSingle(Console.ReadLine());

                    Student stuInput = new Student(id, fullName, scoreCsharp, scoreJS);

                    stuList.Add(stuInput);
                }
            } while (true);
        }

        // Hàm xuất TTSV
        static void OutputStudent(ArrayList stuList, int numberStu)
        {
            Console.WriteLine("\n0------------------------------------------------------------------------0");
            Console.WriteLine("|\tID\t|\tFULLNAME\t|\tC#\t|   JAVASCRIPT   |");
            Console.WriteLine("0------------------------------------------------------------------------0");

            for (int i = 0; i < numberStu; i++)
            {
                Student stuOutput = (Student)stuList[i];
                stuOutput.OutputStudent();
            }
        }

        // Hàm thêm TTSV
        static void InsertStudent(ref ArrayList stuList)
        {
            Student stuInsert = new Student();
            Console.Write("\nID: ");
            string id = Console.ReadLine().ToUpper();
            Console.Write("Fullname: ");
            string fullName = Console.ReadLine();
            Console.Write("Score C#: ");
            float scoreCsharp = Convert.ToSingle(Console.ReadLine());
            Console.Write("Score JavaScript: ");
            float scoreJS = Convert.ToSingle(Console.ReadLine());

            Student stuInput = new Student(id, fullName, scoreCsharp, scoreJS);

            stuList.Add(stuInput);
        }
    }
}