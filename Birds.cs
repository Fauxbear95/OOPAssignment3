using System;

using A3.Eggs;
namespace A3.Birds
{
	class Bird
	{
		public static Random Rand = new Random(1);
		public virtual Egg[] LayEggs(int numEggs)
		{
			Console.Error.WriteLine("Bird.LayEggs should not be called!");
			return new Egg[0];
		}

		protected Egg GetEgg(double minSize, double maxSize, double brokenChance, Egg.Colors color)
        {
			return Rand.NextDouble() <= brokenChance ? new BrokenEgg(Rand.NextDouble() * (maxSize - minSize) + 
				minSize, color) : new Egg(Rand.NextDouble() * (maxSize - minSize) + minSize, color);
        }
	}

	class Chicken : Bird
	{
		public override Egg[] LayEggs(int numEggs)
        {
			Egg[] eggs = new Egg[numEggs];

			for(int i = 0; i < numEggs; ++i)
            {
				eggs[i] = GetEgg(2, 4, 0.25, Egg.Colors.brown);
            }
			return eggs;
        }
	}

	class Ostrich : Bird 
	{
		public override Egg[] LayEggs(int numEggs)
		{
			Egg[] eggs = new Egg[numEggs];

			for (int i = 0; i < numEggs; ++i)
			{
				eggs[i] = GetEgg(10, 15, 0.45, Egg.Colors.speckled);
			}
			return eggs;
		}
	}
}
