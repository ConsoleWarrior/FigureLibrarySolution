
using FigureLibrary;

namespace FigureLibraryXUnitTests
{
	public class TriangleTests
	{
		[Fact]
		public void GetAreaReturnArea()
		{
			Triangle triangle = new(10, 10, 10);
			Assert.Equal(43.30127018922193, triangle.GetArea());
		}
		[Fact]
		public void ConstructorThrowsException()
		{
			Assert.Throws<Exception>(() => { Triangle triangle = new(10, 5, 5); });
		}
		[Fact]
		public void IsRectangularReturnTrue()
		{
			Triangle triangle = new(3, 4, 5);
			Assert.True(triangle.IsRectangular());
		}
		[Fact]
		public void IsRectangularReturnFalse()
		{
			Triangle triangle = new(10, 10, 10);
			Assert.False(triangle.IsRectangular());
		}
	}
}
