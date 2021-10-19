namespace A3.Eggs
{
	class Egg
	{
		public enum Colors
		{
			speckled,
			brown
		}
		public double Size { get; private set; }
		public Colors Color { get; private set; }
		public Egg(double size, Colors color)
		{
			Size = size;
			Color = color;
		}
		public override string ToString()
		{
			return $"A {Size:0.0}cm {Color} egg";
		}
	}

	
	class BrokenEgg : Egg
	{
		public BrokenEgg(double size, Colors color) : base(size, color) { }
        public override string ToString()
        {
			return $"A {Size}cm {Color} egg that is broken";

        }
    }
	
}
