using System;

namespace MyWorks.CSharp1.Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 mức thuế
            const float tax_1 = 0.1f;
            const float tax_2 = 0.15f;
            const float tax_3 = 0.2f;

            // Người dùng nhập lương và thưởng
            Console.WriteLine("Enter your salary (million):");
            float salary = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter your bonus (million):");
            float bonus = Convert.ToSingle(Console.ReadLine());

            // Tính toán thu nhập người dùng
            float income = salary + bonus;

            // Hiển thị lương, thưởng và tổng thu nhập
            Console.WriteLine("Your salary = " + salary + " (million)");
            Console.WriteLine("Your bonus = " + bonus + " (million)");
            Console.WriteLine("Your income = " + income + " (million)");

            // Tính thuế dựa trên thu nhập
            if (income < 9)
            {
                Console.WriteLine("You do not have to pay taxes");
            }
            else
            {
                float tax = 0.00f;
                if (income >= 9 && income < 15)
                {
                    tax = income * tax_1;
                }
                else if (income >= 15 && income < 30)
                {
                    tax = income * tax_2;
                }
                else if (income >= 30)
                {
                    tax = income * tax_3;
                }
                Console.WriteLine("Your tax number is " + tax + " (million)");
            }
            Console.ReadKey();
        }
    }
}