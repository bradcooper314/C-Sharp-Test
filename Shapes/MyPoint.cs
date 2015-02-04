using System;

namespace Shapes
{
	public class MyPoint
	{
		public int x  {get; set;}
		public int y  {get; set;}

		public MyPoint ()
		{
			x = 0;
			y = 0;
		}
		
		public MyPoint (int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}
}

