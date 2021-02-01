using System;
using System.Collections.Generic;
using System.Text;

namespace oop_fundamentals.Models
{
    internal class Rectangle
    {
		private double firstSide;

		public double FirstSide
		{
			get { return firstSide; }
			private set 
			{
				if (value <= 0) throw new ArgumentOutOfRangeException(nameof(FirstSide));
			
				firstSide = value;
			}
		}


		private double secondSide;

		public double SecondSide
		{
			get { return secondSide; }
			private set 
			{

				if (value <= 0) throw new ArgumentOutOfRangeException(nameof(SecondSide));

				secondSide = value; 
			}
		}


		public double Area { get => this.AreaCalculator(); }

		public double Perimeter { get => this.PerimeterCalculator(); }


		public Rectangle(double firstSide, double secondSide)
		{
			FirstSide = firstSide;
			SecondSide = secondSide;
		}


		double AreaCalculator() => this.FirstSide * this.SecondSide;


		double PerimeterCalculator() => 2 * (this.FirstSide + this.SecondSide);

	}
}
