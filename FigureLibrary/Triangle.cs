
using FigureLibrary.Abstractions;

namespace FigureLibrary
{
	public class Triangle : Figure
	{
		public readonly double _sideA;
		public readonly double _sideB;
		public readonly double _sideC;
		public Triangle(double a, double b, double c)
		{
			if (a < 0 || b < 0 || c < 0 || a >= b + c || b >= a + c || c >= a + b)
				throw new Exception("Треугольник с такими сторонами не может существовать!");
			_sideA = a;
			_sideB = b;
			_sideC = c;
		}
		public override double GetArea()
		{
			var p = (_sideA + _sideB + _sideC) / 2;
			return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
		}
		public bool IsRectangular()
		{
			if (_sideA * _sideA == _sideB * _sideB + _sideC * _sideC
				|| Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) == Math.Pow(_sideC, 2)
				|| _sideB * _sideB == _sideA * _sideA + _sideC * _sideC)
				return true;
			else return false;
		}
	}
}
