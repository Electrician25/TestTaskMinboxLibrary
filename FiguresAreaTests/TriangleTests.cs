using FluentAssertions;
using TestTaskMinboxLibrary;

namespace FiguresAreaTests
{
	[TestClass]
	public class TriangleTests
	{
		[TestMethod]
		public void WhenCalculatePerimeter_AndPerimeterIsNegative_ThrowException()
		{
			// Arrange, Act.
			Action perimeter = () =>
			{
				if (new Triangle(-1, -8, -5).GetTrianglePerimeter() < 0)
					throw new Exception();
			};

			// Assert.
			perimeter.Should().Throw<Exception>();
		}

		[TestMethod]
		public void WhenCalculatePerimeter_AndPerimeterIs0_ThrowException()
		{
			// Arrange, Act.
			Action perimeter = () =>
			{
				if (new Triangle(0, 0, 0).GetTrianglePerimeter() == 0)
					throw new Exception();
			};

			// Assert.
			perimeter.Should().Throw<Exception>();
		}

		[TestMethod]
		public void WhenCalculatePerimeter_AndPerimeterIsCorrect_ThenPerimeterShouldBeTrue()
		{
			// Arrange, Act.
			var isCorrectPerimeter = new Triangle(1, 2, 3).GetTrianglePerimeter() == 6;

			// Assert.
			isCorrectPerimeter.Should().BeTrue();
		}

		[TestMethod]
		public void WhenCalculateArea_AndEitherSidesLengthIsNegative_ThrowException()
		{
			// Arrange, Act.
			Action area = () =>
			{
				new Triangle(-4, 5, 8).GetTriangleArea();
			};

			// Assert.
			area.Should().Throw<Exception>();
		}

		[TestMethod]
		public void WhenCalculateArea_AndSumSidesBAndCLessThanSideA_ThrowException()
		{
			// Arrange, Act.
			Action area = () =>
			{
				new Triangle(18, 5, 2).GetTriangleArea();
			};

			// Assert.
			area.Should().Throw<Exception>();
		}

		[TestMethod]
		public void WhenCalculateArea_AndSumPointIsCorrect_ThenAreaShouldBeTrue()
		{
			// Arrange, Act.
			var isCorrectArea = new Triangle(5, 1, 5).GetTriangleArea() == 2.48746859276655;// По специфике задания не понял нужно ли округлять, так что оставил так.

			// Assert.
			isCorrectArea.Should().BeTrue();
		}

		[TestMethod]
		public void WhenCalculateArea_AndSumSidesCAndBEqualsA_ThenAreaShouldBeTrue()
		{
			// Arrange, Act.
			var isCorrectArea = new Triangle(6, 3, 3).GetTriangleArea() == 0;

			// Assert.
			isCorrectArea.Should().BeTrue();
		}
	}
}