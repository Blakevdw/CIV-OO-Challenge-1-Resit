﻿using System;

namespace ShapeMaker
{
	class Program
	{
		static ShapesList myShapeList = new ShapesList();
		static void Main(string[] args)
		{
			Console.WriteLine("Shape Generator");

			while (true)
			{
				Console.Clear();
				Console.WriteLine("Select an option from the following::");

				Console.WriteLine(" (1) -> Create Square");

				Console.WriteLine(" (2) -> Create Rectangle");

				Console.WriteLine(" (3) -> Display All Shapes");

				Console.WriteLine(" (4) -> Display Squares");

				Console.WriteLine(" (5) -> Display Rectangles");

				Console.WriteLine(" (6) -> Exit");

				var key = Console.ReadKey(true);

				if (key.Key == ConsoleKey.D1)
				{
					myShapeList.AddSquare();
				}

				else if (key.Key == ConsoleKey.D2)
				{
					myShapeList.AddRectangle();
				}

				else if (key.Key == ConsoleKey.D3)
				{
					myShapeList.DisplayAInput();
				}

				else if (key.Key == ConsoleKey.D4)
				{
					myShapeList.DisplaySInput();
				}

				else if (key.Key == ConsoleKey.D5)
				{
					myShapeList.DisplayRInput();
				}

				else if (key.Key == ConsoleKey.D6)
				{
					break;
				}

				else
				{
					Console.WriteLine("Invalid Input");
					Console.ReadKey(true);
				}

			}

		}
	}
}
