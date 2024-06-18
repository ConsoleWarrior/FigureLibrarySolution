
using FigureLibrary;

namespace FigureLibraryXUnitTests
{
	public class CircleTests
	{
		[Fact]
		public void СonstructorThrowException()
		{
			Assert.Throws<Exception>(() =>{ Circle circle = new(-5); });
		}
		[Fact]
		public void GetAreaReturnArea()
		{
			Circle circle = new(5.55);
			Assert.Equal(96.76890771219959, circle.GetArea());
		}
	}
}
