using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Square : Rectangle {

		//this constrcutor reuses the constructor method from rectangle to create the square
		public Square(int sides) : base (sides,sides){

		}

		public Square() { }
	}
}
