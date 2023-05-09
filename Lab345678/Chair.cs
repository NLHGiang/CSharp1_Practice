namespace MyWorks.CSharp1.Lab345678
{
    internal class Chair : Furniture
    {
        public Chair() : base()
        {
        }

        public Chair(float length, float width, float deepth)
            : base(length, width, deepth)
        {
        }
        public override void OutputInformation()
        {
            Console.WriteLine($"The Chair's volume : {this.GetVolume()}");
        }
    }
}
