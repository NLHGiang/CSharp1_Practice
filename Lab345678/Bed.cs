namespace MyWorks.CSharp1.Lab345678
{
    internal class Bed : Furniture
    {
        public Bed() : base()
        {
        }

        public Bed(float length, float width, float deepth)
            : base(length, width, deepth)
        {
        }
        public override void OutputInformation()
        {
            Console.WriteLine($"The Bed's volume : {this.GetVolume()}");
        }
    }
}
