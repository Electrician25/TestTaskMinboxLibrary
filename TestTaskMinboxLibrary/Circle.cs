namespace TestTaskMinboxLibrary
{
	public class Circle : IArea
	{
		private int _radius;

		public Circle(int radius)
		{
			_radius = radius;
		}

		public double GetArea()
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