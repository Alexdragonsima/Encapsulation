//#define DISTANCE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if DISTANCE
			Point A = new Point();
			//Console.WriteLine($"X = {A.GetX()}\tY = {A.GetY()}");
			//A.SetX(2000);
			//A.SetY(3000);
			//A.Print();
			A.X = 22;
			A.Y = 33;
			A.Print();

			//Point A = new Point { X = 22, Y = 33 };
			//Point B = new Point { X = 10, Y = 20 };
			//
			//A.Print();
			//B.Print();
			//
			//double distanceToB = A.distance(B);
			//Console.WriteLine($"Расстояние от точки А до точки Б: {distanceToB}");
			//
			//double distanceBetween=Point.distance(A,B);
			//Console.WriteLine($"Расстояние между точками: {distanceBetween}");

			//Point B = new Point();
			Point B = new Point(A); //CopyConstructor
			B.Print();

			Point C;    //Это необьект это ссылка на обьект
			C = new Point(B);   //Обьект можно создать только при помощи оператора new
			C.Print(); 
#endif

			Point A = new Point(2, 3);
			Point B = new Point(7, 8);
			Point C = new Point(A + B);
			C.Print();
			Console.WriteLine($"-----------------------------------------");
			Point D = new Point(A - B);
			D.Print();
			Console.WriteLine($"-----------------------------------------");

			for (Point i = new Point(); i.X < 10; i++)
			{
				i.Print();
			}
		}
	}
}
/*
private
public
protected
internal
protected iternal

properties
 */