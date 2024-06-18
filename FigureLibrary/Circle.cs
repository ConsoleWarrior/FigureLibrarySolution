using FigureLibrary.Abstractions;

namespace FigureLibrary
{
	public class Circle : Figure
	{
		public readonly double _radius;
		public Circle(double radius)
		{
			if (radius <= 0) throw new Exception("Радиус круга не может быть меньше или равен 0!");
			_radius = radius;
		}

		public override double GetArea()
		{
			return Math.PI * _radius * _radius;
		}
	}
}
