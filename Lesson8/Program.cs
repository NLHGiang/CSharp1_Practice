using System;

namespace MyWorks.CSharp1.Lesson8
{
    class Program
    {
        // Class hình cầu
        public class Sphere
        {
            public double radius;

            public double GetVolumeSphere()
            {
                double volume = (4 / 3) * Math.PI * Math.Pow(this.radius, 3);
                return volume;
            }

            public void OutputSphere()
            {
                Console.WriteLine("The tich hinh cau " +
                    $"(r={this.radius}) = {GetVolumeSphere()}");
            }
        }

        // Class hình hộp
        public class Cuboid
        {
            public double length, width, height;

            public double GetVolumeCuboid()
            {
                double volume = this.length * this.width * this.height;
                return volume;
            }

            public void OutputCuboid()
            {
                Console.WriteLine("The tich hinh hop " +
                    $"({this.length},{this.width},{this.height}) = {GetVolumeCuboid()}");
            }
        }

        static void Main(string[] args)
        {
            // Đối tượng hình cầu 1
            Sphere sphere1 = new Sphere();

            sphere1.radius = 2;

            sphere1.OutputSphere();

            // Đối tượng hình hộp 1
            Cuboid cuboid1 = new Cuboid();

            cuboid1.length = 2;
            cuboid1.width = 3;
            cuboid1.height = 4;

            cuboid1.OutputCuboid();
        }
    }
}