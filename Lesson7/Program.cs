using System;

namespace MyWorks.CSharp1.Lesson7
{
    class Program
    {
        public class Student
        {
            public string fullName;
            public byte score;
            public void IncreaseScore(byte value)
            {
                this.score += value;
            }

            public void DecreaseScore(byte value)
            {
                this.score -= value;
            }
        }

        static void OutputStudent(Student stu)
        {
            Console.WriteLine(stu.fullName + ": " + stu.score);
        }

        static void Main(string[] args)
        {
            Student stu1 = new Student();
            Student stu2 = new Student();

            stu1.fullName = "Nguyen Le Hong Giang";
            stu1.score = 9;

            stu2.fullName = "Nguyen Van A";
            stu2.score = 9;

            stu1.IncreaseScore(1);
            stu2.DecreaseScore(1);

            OutputStudent(stu1);
            OutputStudent(stu2);

            Console.ReadKey();
        }
    }
}