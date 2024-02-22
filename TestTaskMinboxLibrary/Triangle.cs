namespace TestTaskMinboxLibrary
{
	public class Triangle : IArea, IPerimeter
	{
		private int _a;
		private int _b;
		private int _c;

		public Triangle(int a, int b, int c)
		{
			_a = a;
			_b = b;
			_c = c;
		}

		public double GetArea()
		{
			ThrowIfNotValid(_a, _b, _c);

			var perimeter = GetPerimeter() / 2;

			return Math.Sqrt(perimeter * (perimeter - _a) * (perimeter - _b) * (perimeter - _c));
		}

		public double GetPerimeter()
		{
			ThrowIfNotValid(_a, _b, _c);

			return _a + _b + _c;
		}

		private void ThrowIfNotValid(int a, int b, int c)
		{
			if ((a < 0 || b < 0 || c < 0)
				|| ((a > (c + b) && c + b != a)
				|| ((c > (a + b) && a + b != c))
				|| ((b > (a + c) && a + c != b)))
				|| (a + b + c) < 0 || (a + b + c) == 0)
			{
				throw new Exception("Perimeter or area is not valid");
			}
		}
	}
}