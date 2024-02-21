namespace TestTaskMinboxLibrary
{
	public class Circle
	{
		private int _radius { get; }

		public Circle(int radius)
		{
			_radius = radius;
		}

		public double GetCircleArea()
		{
			ThrowIfNotValid();

			var p = 3.14;

			return Math.Pow(_radius, 2) * p;
		}

		private void ThrowIfNotValid()
		{
			if (_radius == 0 || _radius < 0)
			{
				throw new Exception();
			}
		}
	}
}