using FluentAssertions;
using TestTaskMinboxLibrary;

namespace FiguresAreaTests
{
	[TestClass]
	public class CircleTests
	{
		[TestMethod]
		public void WhenCalculateCircleArea_AndRadiusIs0_ThrowException()
		{
			// Arrange, Act.
			Action area = () =>
			{
				if (new Circle(0).GetArea() == 0)
				{
					throw new Exception();
				}
			};

			// Assert.
			area.Should().Throw<Exception>();
		}

		[TestMethod]
		public void WhenCalculateCircleArea_AndRadiusIsNegative_ThrowException()
		{
			// Arrange, Act.
			Action area = () =>
			{
				if (new Circle(-7).GetArea() < 0)
				{
					throw new Exception();
				}
			};

			// Assert.
			area.Should().Throw<Exception>();
		}

		[TestMethod]
		public void WhenCalculateCircleArea_AndRadiusCorrect_AreaShouldBeTrue()
		{
			// Arrange, Act.
			var isCorrectArea = new Circle(6).GetArea() == 113.04;

			// Assert.
			isCorrectArea.Should().BeTrue();
		}
	}
}