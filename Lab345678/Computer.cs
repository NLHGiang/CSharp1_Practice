namespace MyWorks.CSharp1.Lab345678
{
    internal class Computer : Furniture
    {
        public Computer() : base()
        {
        }

        public Computer(float length, float width, float deepth)
            : base(length, width, deepth)
        {
        }

        public override void OutputInformation()
        {
            Console.WriteLine($"The Computer's volume : {this.GetVolume()}");
        }
    }
}
