namespace TestTaskMinboxLibrary
{
	public class Triangle
	{
		private int _a { get; }
		private int _b { get; }
		private int _c { get; }

		public Triangle(int a, int b, int c)
		{
			_a = a;
			_b = b;
			_c = c;
		}

		public double GetTriangleArea()//if area is 0 then triangle is right triangle
		{
			ThrowIfNotValid(_a, _b, _c);

			var perimeter = GetTrianglePerimeter() / 2;

			return Math.Sqrt(perimeter * (perimeter - _a) * (perimeter - _b) * (perimeter - _c));
		}

		public double GetTrianglePerimeter()
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