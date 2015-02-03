using System;

namespace Shapes
{
	public class Point
	{
		private int _x, _y;

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
		
		public int x {
			set { this._x = value; }
			get { return this._x; }
		}
		
		public int y {
			set { this._y = value; }
			get { return this._y; }
		}
	}
}

