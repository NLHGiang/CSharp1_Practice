using System;
using System.Collections;

namespace MyWorks.CSharp1.Lesson11
{
    // Class trừu tượng Staff(nhân viên)
    abstract class Staff
    {
        abstract public void Report();
    }

    // Class nhân viên VP kế thừa class nhân viên
    class OfficeStaff : Staff
    {
        public string name;
        public int age;
        public int yearOfBirth;

        public OfficeStaff()
        {

        }

        public OfficeStaff(string name, int age, int yearOfBirth)
        {
            this.name = name;
            this.age = age;
            this.yearOfBirth = yearOfBirth;
        }

        public override void Report()   // Dùng override
        {
            Console.WriteLine("*Work progress of the staff*");
            Console.WriteLine("Progress: 0%");
        }
    }

    // Class Developer kế thừa class Staff
    sealed class Developer : Staff
    {
        public int workplace;
        public int devLevel;

        public Developer()
        {

        }

        public Developer(int workplace, int devLevel)
        {
            this.workplace = workplace;
            this.devLevel = devLevel;
        }

        public override void Report()   // Dùng override
        {
            Console.WriteLine("*Work progress of the developer*");
            Console.WriteLine("Progress: 80%");
        }

        public void FixCode()
        {
            Console.WriteLine("It is currently under maintenance. Continuous overtime");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            *  BAI TAP : Su dung ArrayList de chua 4 doi tuong ( 2 nhanvienVP , 2 developer )
            *          Luot qua cac phan tu goi ham Report
            */
            ArrayList staffs = new ArrayList();

            int numOffice = 2;
            int numDev = 2;

            // Add staff vào ArrayList staffs
            for (int i = 0; i < numOffice; i++)
            {
                OfficeStaff staff = new OfficeStaff();
                staffs.Add(staff);
            }

            // Add dev vào ArrayList staffs
            for (int i = 0; i < numDev; i++)
            {
                Developer dev = new Developer();
                staffs.Add(dev);
            }

            // Hiển thị tiến độ 
            foreach (Staff staff in staffs)
            {
                staff.Report();
            }
        }
    }
}