using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Point
	{
		#region MyRegion
		//double x;
		//double y;
		//public double X //Property
		//{
		//	get
		//	{
		//		return x;
		//	}
		//	set
		//	{
		//		if (value > 200) value = 200;
		//		x = value;
		//	}
		//}
		//public double Y
		//{
		//	get
		//	{
		//		return y;
		//	}
		//	set
		//	{
		//		if (value > 150) value = 150;
		//		y = value;
		//	}
		//}
		//public double GetX() { return x; }
		//public double GetY() { return y; }
		//public void SetX(double x)
		//{
		//	if (x > 200) x = 200;
		//	this.x = x;
		//}
		//public void SetY(double y)
		//{
		//	if (y > 150) y = 150;
		//	this.y = y;
		//} 
		#endregion

		public double X { get; set; }   //auto
		public double Y { get; set; }

		public Point(double x = 0, double y = 0)
		{
			this.X = x;
			this.Y = y;
			Console.WriteLine($"Constructor: {this.GetHashCode()}");
		}
		public Point(Point other)
		{
			this.X = other.X;
			this.Y = other.Y;
			Console.WriteLine($"CopyConstructor: {GetHashCode()}");
		}
		~Point()
		{
			Console.WriteLine($"Destructor: {this.GetHashCode()}");
		}

		public static Point operator +(Point left, Point right)
		{
			Point res = new Point();
			res.X = left.X + right.X;
			res.Y = left.Y + right.Y;
			return res;
		}
		public static Point operator -(Point left, Point right)
		{
			return new Point
			(
				left.X - right.X
				, left.Y - right.Y
			);
		}

		public static Point operator ++(Point obj)
		{
			obj.X++;
			obj.Y++;
			return obj;
		}

		public static bool operator ==(Point left, Point right)
		{
			return left.X == right.X && left.Y == right.Y;
		}
		public static bool operator !=(Point left, Point right)
		{
			return !(left == right);
		}

		public void Print()
		{
			//Console.WriteLine($"X = {X}\tY = {Y}");
			Console.WriteLine($"{GetHashCode()}X = {X}\tY = {Y}");
		}
		public double distance(Point other)
		{
			double x_distance = this.X - other.X;
			double y_distance = this.Y - other.Y;
			double distance = Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
			return distance;
		}
		public static double distance(Point A, Point B)
		{
			double distance_x = A.X - B.X;
			double distance_y = A.Y - B.Y;
			double distance = Math.Sqrt(distance_x * distance_x + distance_y * distance_y);
			return distance;
		}
	}
}
