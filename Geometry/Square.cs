using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Square {

		public double LengthOfSides { get; set; } //the get gives the value & the set will set the assignment and that is allowed because of the stuff in the {}

		public double GetArea() {
			return LengthOfSides * LengthOfSides;
			//return Math.Pow(LengthOfSides, 2); //can also use this to get the answer
		}
		public double GetPerimeter() {
			return LengthOfSides * 4;
		}

		public void Print() {
			Console.WriteLine($"A sqaure with length {LengthOfSides} has an area of {GetArea()} and a perimeter of {GetPerimeter()}");
		}
	}
}
