using System;

namespace Shapes
{
	public abstract class Shape
	{
		private const char LINE_DEFAULT = 'O';
		private const char FILL_DEFAULT = 'X';
	
		public char line {get; set;}
		public char fill {get; set;}
		public bool isFilled {get; set;}
		
		public Shape()
		{
			line = LINE_DEFAULT;
			fill = FILL_DEFAULT;
			isFilled = true;
		}
		
		public Shape(char line, char fill, bool isFilled)
		{
			this.line = line;
			this.fill = fill;
			this.isFilled = isFilled;
		}
	}
}
