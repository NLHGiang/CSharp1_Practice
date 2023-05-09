namespace MyWorks.CSharp1.Lab345678
{
    internal class Table : Furniture
    {
        public Table() : base()
        {
        }

        public Table(float length, float width, float deepth)
            : base(length, width, deepth)
        {
        }
        public override void OutputInformation()
        {
            Console.WriteLine($"The Table's volume : {this.GetVolume()}");
        }
    }
}
