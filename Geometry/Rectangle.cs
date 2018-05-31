using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Rectangle {
		public double height { get; set; }
		public double width { get; set; }

		public double GetArea() {
			return height * width;
		}

		public double GetPerimeter() {
			//return (height * 2) + (width * 2);
			return 2 * (height + width); //Greg used this calculation because he said it is simpler and "simpler is better"
		}

		public void Print () {
			Console.WriteLine($"A rectangle with height of {height} and width of {width} has an area of {GetArea()} and a perimeter of {GetPerimeter()}");
		}
	}
}
