using System;

namespace Shapes
{
	public class Rectangle : Shape
	{
		public int width {get; set;}
		public int length {get; set;}
		public MyPoint origin {get; set;}
	
		public Rectangle() : base()
		{
			width = 0;
			length = 0;
			origin = new MyPoint(0,0);
		}
		
		public Rectangle(int width, int length, MyPoint origin) : base()
		{
			this.width = width;
			this.length = length;
			this.origin = origin;
		}
		
		public Rectangle(char line, char fill, bool isFilled, int width, int length, MyPoint origin) : base(line, fill, isFilled)
		{
			this.width = width;
			this.length = length;
			this.origin = origin;
		}
		
		public void Translate(MyPoint origin)
		{
			this.origin = origin;
		}
		
		public bool ContainsPoint(MyPoint other)
		{
			bool withinX = (other.x >= origin.x && other.x <= (origin.x + width));
			bool withinY = (other.y >= origin.y && other.y <= (origin.y + length));
			return (withinX && withinY);
		}
		
		public Rectangle Intersect(Rectangle other)
		{
			//create default triangle to return if no instersect found
			Rectangle intersect = new Rectangle();
			
			//find origin of intersect rectangle
			MyPoint newOrigin = new MyPoint(Math.Max(origin.x,other.origin.x), Math.Max(origin.y,other.origin.y));
				
			if(this.ContainsPoint(newOrigin) && other.ContainsPoint(newOrigin))
			{
				//if origin of intersect is found in both rectangles, find the width and length
				int newWidth = Math.Min(origin.x + width,other.origin.x + other.width);
				int newLength = Math.Min(origin.y + length,other.origin.y + other.length);
				
				if(newWidth != 0 && newLength != 0)
				{
					//if both width and height are not zero, set properties of intersect rectangle
					intersect.Translate(newOrigin);
					intersect.width = newWidth;
					intersect.length = newLength;
				}
			}
			return intersect;
		}
		
		public void Draw()
		{
			//skip down the lines until the y-coordinate of the rectangle is reached
			for(int i = 0; i < origin.y; i++)
			{
				Console.WriteLine();
			}
			
			//for each line (length) of the rectangle
			for(int i = 0; i < length; i++)
			{
				//put the spaces in until the x-ccordinate of rectangle is reached, followed by line char for border
				for(int j = 0; j < origin.x; j++)
				{
					Console.Write(' ');
				}
				Console.Write(line);
				
				//determine what to fill the body 'fill' space with
				if(i == 0 || i == length - 1)
				{
					for(int j = 0; j < width-2; j++)
					{
						Console.Write(line);
					}
				}
				else if (isFilled)
				{
					for(int j = 0; j < width-2; j++)
					{
						Console.Write(fill);
					}
				}
				else
				{
					for(int j = 0; j < width-2; j++)
					{
						Console.Write(' ');
					}
				}
				
				//end line with other side border, and skip to next line
				Console.WriteLine(line);
			}
			Console.WriteLine();
		}
	}
}
