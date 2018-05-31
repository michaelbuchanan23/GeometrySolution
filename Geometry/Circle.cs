using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Circle {

		public double r { get; set; }

		public double GetArea() {
			return Math.PI * (Math.Pow(r, 2));
		}

		public double GetPerimeter() {
			return 2 * Math.PI * r;
		}

		public void Print() {
			Console.WriteLine($"A circle with radius of {r} has an area of {GetArea()} and a perimeter of {GetPerimeter()}");
		}
	}
}