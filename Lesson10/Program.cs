using System;
using System.Collections;

namespace MyWorks.CSharp1.Lesson10
{
    /*
     * Tạo class QLSV
     * 1. Max number of students in class
     * 2. Tạo ArrayList lưu SV
     * 3. Tạo method tính toán SV Đạt / Không Đạt (dựa vào điểm và hạnh kiểm)
     *  - điểm các môn > 5 , HK = Tốt --> Đạt
     *  - điểm các môn > 5 , HK = Kém --> Xem xét
     *  - điểm các môn < 5 , HK = Kém --> Không Đạt
     * 4. Tạo 1 property trạng thái(đã xét / chưa xét)
     * 
     * Tạo class Phòng ĐT
     * 1. Tạo ArrayList lưu tt class QLSV
     * 2. Method kiểm tra QLSV.trạng thái đã xét => output
     *  - Họ tên
     *  - Điểm 
     *  - Điểm ý thức
     */
    class StudentManagement
    {
        internal string id;
        private string fullName;
        private float score;
        private byte conduct;   //conduct: 1 => Tốt, 0 => Kém
        internal byte check;      //check: 1 => Passed, 0 => Failed, 2 => Unchecked
        internal bool checkDone = false;  //checkDone: true => Done, false => Not done

        internal StudentManagement()
        {
            this.id = "--";
            this.fullName = "--";
            this.score = 0.0f;
            this.conduct = 0;
        }

        internal StudentManagement(string id, string fullName, float score, byte conduct)
        {
            this.id = id;
            this.fullName = fullName;
            this.score = score;
            this.conduct = conduct;
        }

        internal byte isPassed()
        {
            if (this.score >= 5)
            {
                if (this.conduct == 1)
                {
                    check = 1;
                }
                else
                {
                    check = 2;
                }
            }
            if (this.score < 5)
            {
                if (this.conduct == 0)
                {
                    check = 0;
                }
                else
                {
                    check = 2;
                }
            }
            return check;
        }

        internal void OutputStudent()
        {
            Console.WriteLine($"{this.fullName} - {this.score} - {Convert.ToString(this.conduct == 1 ? "Tot" : "Kem")} => " +
                $"{Convert.ToString(this.check == 1 ? "Passed" : (this.check == 0) ? "Failed" : "Unchecked")}");
        }
    }

    class TrainingDepartment
    {
        private StudentManagement stu;
        ArrayList students = new ArrayList();

        internal void InputArr()
        {
            this.students.Add(this.stu);
        }

        internal TrainingDepartment()
        {
            this.stu = new StudentManagement();
        }

        internal TrainingDepartment(StudentManagement student)
        {
            this.stu = student;
        }

        internal void OutputCheckedStudent()
        {
            if (this.stu.check == 1 || this.stu.check == 0)
            {
                this.stu.checkDone = true;
                this.stu.OutputStudent();
            }
        }

        internal void SearchById(string idSearch)
        {
            foreach (StudentManagement student in this.students)
            {
                if (student.id == idSearch)
                {
                    student.OutputStudent();
                }
                else
                {
                    continue;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int numberMax = 3;
            int numberStu = 0;
            ArrayList listStudent = new ArrayList();

            // Add đt SV -> listStudent
            while (numberStu < numberMax)
            {
                Console.WriteLine($"\nEnter student {numberStu}");
                Console.Write("ID: ");
                string id = Console.ReadLine();
                Console.Write("Fullname: ");
                string fullName = Console.ReadLine();
                Console.Write("Score: ");
                float score = Convert.ToSingle(Console.ReadLine());
                Console.Write("Conduct: ");
                byte conduct = Convert.ToByte(Console.ReadLine());

                // Tạo đt SV
                StudentManagement student = new StudentManagement(id, fullName, score, conduct);

                // Check sinhvien
                student.isPassed();

                listStudent.Add(student);
                numberStu++;
            }

            Console.WriteLine("\nSTUDENT INFORMATION");
            for (int i = 0; i < numberStu; i++)
            {
                StudentManagement infor = (StudentManagement)listStudent[i];
                infor.OutputStudent();
            }

            // Tạo đt PĐT (protected)
            // In ttsv checked
            Console.WriteLine("\nSTUDENT INFORMATION CHECKED");
            for (int i = 0; i < numberStu; i++)
            {
                TrainingDepartment training = new TrainingDepartment((StudentManagement)listStudent[i]);
                training.OutputCheckedStudent();
                string searchValue = "b";
                training.SearchById(searchValue);
            }

            Console.WriteLine("\nSEARCH STUDENT");
            Console.Write("ID of student you want to search: ");
            string idSearch = Console.ReadLine();

            for (int i = 0; i < numberStu; i++)
            {
                TrainingDepartment training = new TrainingDepartment((StudentManagement)listStudent[i]);
                training.InputArr();
                training.SearchById(idSearch);
            }
        }
    }
}