namespace MyWorks.CSharp1.Lab345678
{
    internal abstract class Furniture
    {
        protected float length;
        protected float width;
        protected float deepth;
        private float volume;
        public Furniture()
        {
            this.length = 0.0f;
            this.width = 0.0f;
            this.deepth = 0.0f;
            this.volume = 0.0f;
        }

        public Furniture(float length, float width, float deepth)
        {
            this.length = length;
            this.width = width;
            this.deepth = deepth;
        }

        public float GetVolume()
        {
            this.volume = this.length * this.width * this.deepth;
            return this.volume;
        }

        public float GetVolume(float volume)
        {
            this.volume = volume;
            return this.volume;
        }

        abstract public void OutputInformation();
    }
}
