using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Program {

		static void Main(string[] args) {

			//creating a new variable of class Square
			Square sqr = new Square ();

			//Obtain the length of one side
			/*
			Console.WriteLine("What is the length of one side of the square? ");
			sqr.LengthOfSides = double.Parse(Console.ReadLine());
			Console.WriteLine();
			*/

			//assign value of 1.5 to variable sqr.LengthofSides to be used to calculate area/perimeter
			sqr.LengthOfSides = 1.5;

			//using the methods to calculate area and perimter from the Square class through the sqr variable via sqr.LengthOfSides property
			double area = sqr.GetArea();
			double perimeter = sqr.GetPerimeter();

			//Outputting the information after it has been calculated
			Console.WriteLine("One side of the square has a length of {0}", sqr.LengthOfSides);
			Console.WriteLine("The area of the square is {0}", area);
			Console.WriteLine("The perimeter of the square is {0}", perimeter);

			//doing the same as above but with sqr2 variable
			Square sqr2 = new Square();
			sqr2.LengthOfSides = 3.3;

			//calls the Square.Print function to work from class Square
			sqr2.Print();   //the print function replaces lines 25-32...it is from the Square class		
							//end sqr2 variable code	


			//Rectangle calculations
			Rectangle rect1 = new Rectangle();
			rect1.height = 1.2;
			rect1.width = 8.2;
			rect1.Print();

			//circle calculations
			Circle circ1 = new Circle();
			circ1.r = 1;
			circ1.Print();

			Circle circ2 = new Circle();
			circ2.r = 2;
			circ2.Print();
		}
	}
}
