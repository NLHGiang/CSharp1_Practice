namespace MyWorks.CSharp1.Lab345678
{
    internal class Wardrobe : Furniture
    {
        public Wardrobe() : base()
        {
        }

        public Wardrobe(float length, float width, float deepth)
            : base(length, width, deepth)
        {
        }
        public override void OutputInformation()
        {
            Console.WriteLine($"The Wardrobe's volume : {this.GetVolume()}");
        }
    }
}
