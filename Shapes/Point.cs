using System;

namespace Shapes
{
	public class Point
	{
		public int _x  {get; set;};
		public int _y  {get; set;};

		public Point ()
		{
			x = null;
			y = null;
		}
		
		public Point (int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}
}

