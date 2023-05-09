using System;
using System.Collections;
using System.Text;

namespace MyWorks.CSharp1.Assignment
{
    class Student
    {
        private string id;
        private string fullName;
        private float score;
        private string email;

        public Student()
        {
            this.id = "? ? ?";
            this.fullName = "? ? ?";
            this.score = -9999;
            this.email = "? ? ?";
        }

        public Student(string id, string fullName, float score, string email)
        {
            this.id = id;
            this.fullName = fullName;
            this.score = score;
            this.email = email;
        }

        public string GetId()
        {
            return this.id;
        }

        public string GetFullName()
        {
            return this.fullName;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public float GetScore()
        {
            return this.score;
        }

        public string RankStu()
        {
            string rank = "";
            if (this.score < 3)
            {
                rank = "Kém";
            }
            if (this.score >= 3 && this.score < 5)
            {
                rank = "Yếu";
            }
            if (this.score >= 5 && this.score < 6.5)
            {
                rank = "Trung Bình";
            }
            if (this.score >= 6.5 && this.score < 7.5)
            {
                rank = "Khá";
            }
            if (this.score >= 7.5 && this.score < 9)
            {
                rank = "Giỏi";
            }
            if (this.score >= 9)
            {
                rank = "Xuất Sắc";
            }

            return rank;
        }

        public string RankStu(float score)
        {
            string rank = "";
            if (score < 3)
            {
                rank = "Kém";
            }
            if (score >= 3 && score < 5)
            {
                rank = "Yếu";
            }
            if (score >= 5 && score < 6.5)
            {
                rank = "Trung Bình";
            }
            if (score >= 6.5 && score < 7.5)
            {
                rank = "Khá";
            }
            if (score >= 7.5 && score < 9)
            {
                rank = "Giỏi";
            }
            if (score >= 9)
            {
                rank = "Xuất Sắc";
            }

            return rank;
        }
    }

    class StudentManagement
    {
        Student student = new Student();
        ArrayList students = new ArrayList();

        // Hàm xuất học viên
        public void OutputOneStudent(Student student)
        {
            Console.WriteLine($"Họ và tên: {student.GetFullName()}");
            Console.WriteLine($"Điểm: {student.GetScore()}");
            Console.WriteLine($"Email: {student.GetEmail()}");
            Console.WriteLine($"Học lực: {student.RankStu(student.GetScore())}");
        }

        // Hàm nhập danh sách học viên
        public void InputStudents()
        {
            Console.WriteLine("Nhập danh sách học viên");
            int numStudent;
            do
            {
                Console.WriteLine("Số lượng học viên muốn nhập: ");

                numStudent = int.Parse(Console.ReadLine());

                if (numStudent >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("<!> Nhập số lượng học viên không âm !");
                }
            } while (true);

            for (int i = 0; i < numStudent; i++)
            {
                string id;
                do
                {
                    Console.Write("Mã số: ");
                    id = Console.ReadLine();

                    if (id.Length != 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("<!> Nhập mã số !");
                    }
                } while (true);

                string fullName;
                do
                {
                    Console.Write("Họ và tên: ");
                    fullName = Console.ReadLine();

                    var name = fullName.Split(' ');

                    if (fullName.Length != 0)
                    {
                        if (name[0] != name[name.Length - 1])
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("<!> Nhập họ và tên không trùng nhau !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("<!> Nhập họ tên !");
                    }
                } while (true);

                Console.Write("Email: ");
                string email = Console.ReadLine();

                float score;
                do
                {
                    Console.Write("Điểm: ");
                    score = float.Parse(Console.ReadLine());

                    if (score >= 0 && score <= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("<!> Nhập điểm trong khoảng [0;10] !");
                    }
                } while (true);

                Student student = new Student(id, fullName, score, email);

                students.Add(student);
            }
        }

        // Hàm xuất danh sách học viên
        public void OutputStudents()
        {
            Console.WriteLine("Xuất danh sách học viên");

            if (students.Count == 0)
            {
                Console.WriteLine("<!> Không có học viên nào trong danh sách");
            }
            else
            {
                int i = 1;
                foreach (Student student in students)
                {
                    Console.WriteLine($"Học viên thứ {i}");
                    OutputOneStudent(student);
                    i++;
                }
            }
        }

        // Hàm tìm kiếm học viên theo khoảng điểm
        public void SearchByScore()
        {
            Console.WriteLine("Tìm kiếm học viên theo khoảng điểm");

            Console.WriteLine("Khoảng điểm");
            Console.Write("Từ: ");
            float numStart = float.Parse(Console.ReadLine());
            Console.Write("Đến: ");
            float numEnd = float.Parse(Console.ReadLine());

            if (numStart >= numEnd)
            {
                Console.WriteLine("<!> Khoảng điểm nhập không hợp lệ");
            }
            else
            {
                int count = 0;

                foreach (Student student in students)
                {
                    float score = student.GetScore();
                    if (score >= numStart && score <= numEnd)
                    {
                        OutputOneStudent(student);
                        count++;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine($"<!> Không có học viên nào trong khoảng điểm [{numStart};{numEnd}]");
                }
            }
        }

        // Hàm tìm kiếm học viên theo học lực
        public void SearchByAbility()
        {
            Console.WriteLine("Tìm kiếm học viên theo học lực");

            Console.Write("Nhập mức học lực muốn tìm kiếm: ");
            string rankInput = Console.ReadLine();

            int i = 1;
            foreach (Student student in students)
            {
                string rank = student.RankStu();

                if (String.Compare(rankInput.ToUpper(), rank.ToUpper()) == 0)
                {
                    Console.WriteLine($"Học viên thứ {i}");
                    OutputOneStudent(student);
                }

                i++;
            }
        }

        // Hàm cập nhật thông tin học viên theo mã số
        public void UpdateStudentById()
        {
            Console.WriteLine("Cập nhật thông tin học viên theo mã số");

            Console.Write("Nhập mã số học viên muốn cập nhật: ");
            string idInput = Console.ReadLine();

            foreach (Student student in students)
            {
                string id = student.GetId();

                if (String.Compare(idInput.ToUpper(), id.ToUpper()) == 0)
                {
                    string fullName;
                    do
                    {
                        Console.Write("Họ và tên: ");
                        fullName = Console.ReadLine();

                        var name = fullName.Split(' ');

                        if (fullName.Length != 0)
                        {
                            if (name[0] != name[name.Length - 1])
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("<!> Nhập họ và tên không trùng nhau !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("<!> Nhập họ tên !");
                        }
                    } while (true);

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    float score;
                    do
                    {
                        Console.Write("Điểm: ");
                        score = float.Parse(Console.ReadLine());

                        if (score >= 0 && score <= 10)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("<!> Nhập điểm trong khoảng [0;10] !");
                        }
                    } while (true);
                }
                else
                {
                    Console.WriteLine($"<!>Học viên có mã số {idInput} không tồn tại");
                }
            }
        }

        // Hàm sắp xếp học viên theo điểm
        public void RankByScore()
        {
            Console.WriteLine("Sắp xếp học viên theo điểm");

            students.Sort(new SortScoreDESC());
        }

        // Hàm xuất 5 học viên có điểm cao nhất
        public void StudentsHaveMaxScore()
        {
            Console.WriteLine("Xuất 5 học viên có điểm cao nhất");

            students.Sort(new SortScoreDESC());

            if (students.Count < 5)
            {
                Console.WriteLine($"Tổng số học viên: {students.Count}");

                int i = 1;
                foreach (Student student in students)
                {
                    Console.WriteLine($"Học viên thứ {i}");
                    OutputOneStudent(student);
                    i++;
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Student student = (Student)students[i];
                    Console.WriteLine($"Học viên thứ {i + 1}");
                    OutputOneStudent(student);
                }
            }
        }

        // Hàm tính điểm trung bình của lớp
        public float AverageScore()
        {
            Console.WriteLine("Tính điểm trung bình của lớp");

            float sum = 0.0f;

            foreach (Student student in students)
            {
                sum += student.GetScore();
            }
            float average = sum / students.Count;

            Console.WriteLine($"Điểm trung bình = {average}");

            return average;
        }

        // Hàm xuất danh sách học viên có điểm > điểm trung bình của lớp
        public void StudentsHaveGreaterScore()
        {
            Console.WriteLine("Xuất danh sách học viên có điểm > điểm trung bình của lớp");

            int i = 1;
            foreach (Student student in students)
            {
                if (student.GetScore() > AverageScore())
                {
                    Console.WriteLine($"Học viên thứ {i}");
                    OutputOneStudent(student);
                }
                i++;
            }
        }

        // Hàm tổng hợp số học viên theo học lực
        public void GroupStudentsByAbility()
        {
            Console.WriteLine("Tổng hợp số học viên theo học lực");

            ArrayList listKem = new ArrayList();
            ArrayList listYeu = new ArrayList();
            ArrayList listTrungBinh = new ArrayList();
            ArrayList listKha = new ArrayList();
            ArrayList listGioi = new ArrayList();
            ArrayList listXuatSac = new ArrayList();

            foreach (Student student in students)
            {
                string rank = student.RankStu();

                if (rank == "Kém")
                {
                    listKem.Add(student);
                }
                if (rank == "Yếu")
                {
                    listYeu.Add(student);
                }
                if (rank == "Trung Bình")
                {
                    listTrungBinh.Add(student);
                }
                if (rank == "Khá")
                {
                    listKha.Add(student);
                }
                if (rank == "Giỏi")
                {
                    listGioi.Add(student);
                }
                if (rank == "Xuất Sắc")
                {
                    listXuatSac.Add(student);
                }
            }

            Console.WriteLine("Danh sách học viên có học lực Kém");
            foreach (Student stuListed in listKem)
            {
                OutputOneStudent(stuListed);
            }
            Console.WriteLine("Danh sách học viên có học lực Yếu");
            foreach (Student stuListed in listYeu)
            {
                OutputOneStudent(stuListed);
            }
            Console.WriteLine("Danh sách học viên có học lực Trung Bình");
            foreach (Student stuListed in listTrungBinh)
            {
                OutputOneStudent(stuListed);
            }
            Console.WriteLine("Danh sách học viên có học lực Khá");
            foreach (Student stuListed in listKha)
            {
                OutputOneStudent(stuListed);
            }
            Console.WriteLine("Danh sách học viên có học lực Giỏi");
            foreach (Student stuListed in listGioi)
            {
                OutputOneStudent(stuListed);
            }
            Console.WriteLine("Danh sách học viên có học lực Xuất Sắc");
            foreach (Student stuListed in listXuatSac)
            {
                OutputOneStudent(stuListed);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            StudentManagement stuManagement = new StudentManagement();
            do
            {
                Menu();

                // Người dùng nhập lựa chọn
                Console.Write("Chọn chức năng muốn thực hiện: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        stuManagement.InputStudents();
                        break;
                    case "2":
                        stuManagement.OutputStudents();
                        break;
                    case "3":
                        stuManagement.SearchByScore();
                        break;
                    case "4":
                        stuManagement.SearchByAbility();
                        break;
                    case "5":
                        stuManagement.UpdateStudentById();
                        break;
                    case "6":
                        stuManagement.RankByScore();
                        break;
                    case "7":
                        stuManagement.StudentsHaveMaxScore();
                        break;
                    case "8":
                        stuManagement.AverageScore();
                        break;
                    case "9":
                        stuManagement.StudentsHaveGreaterScore();
                        break;
                    case "10":
                        stuManagement.GroupStudentsByAbility();
                        break;
                    default:
                        Console.WriteLine("<!> Lựa chọn chức năng không hợp lệ. Mời chọn lại (1-10)");
                        break;
                }
            } while (true);
        }

        // Hàm hiển thị menu chương trình
        static void Menu()
        {
            Console.WriteLine("\no================================MENU================================o");
            Console.WriteLine("|  1.  Nhập danh sách học viên                                       |");
            Console.WriteLine("|  2.  Xuất danh sách học viên                                       |");
            Console.WriteLine("|  3.  Tìm kiếm học viên theo khoảng điểm                            |");
            Console.WriteLine("|  4.  Tìm kiếm học viên theo học lực                                |");
            Console.WriteLine("|  5.  Cập nhật thông tin học viên theo mã số                        |");
            Console.WriteLine("|  6.  Sắp xếp học viên theo điểm                                    |");
            Console.WriteLine("|  7.  Xuất 5 học viên có điểm cao nhất                              |");
            Console.WriteLine("|  8.  Tính điểm trung bình của lớp                                  |");
            Console.WriteLine("|  9.  Xuất danh sách học viên có điểm trên điểm trung bình của lớp  |");
            Console.WriteLine("| 10.  Tổng hợp số học viên theo học lực                             |");
            Console.WriteLine("o====================================================================o");
        }
    }

    public class SortScoreDESC : IComparer
    {
        public int Compare(object x, object y)
        {
            // Ép kiểu 2 object truyền vào về Person.
            Student ob1 = x as Student;
            Student ob2 = y as Student;

            /*
            * Thực hiện so sánh và 
            * trả về các giá trị 1 0 -1 tương ứng
            * bé hơn, bằng, lớn hơn.
            */
            if (ob1.GetScore() < ob2.GetScore())
            {
                return 1;
            }
            else if (ob1.GetScore() == ob2.GetScore())
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}