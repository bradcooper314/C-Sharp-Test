using System;

namespace Shapes
{
	public class TestShapes
	{
		public static int Main(String[] args)
		{
			Rectangle first = new Rectangle(4,3,new MyPoint(0,0));
			Rectangle second = new Rectangle(2,2,new MyPoint(1,2));
			Rectangle third = new Rectangle(1,1,new MyPoint(0,5));
			
			Console.WriteLine("First:");
			first.Draw();
			
			Console.WriteLine("Second:");
			second.Intersect(second).Draw();
			
			Console.WriteLine("Third:");
			third.Intersect(first).Draw();
			
			return 0;
		}
	}
}
