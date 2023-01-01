using System;
namespace hw4point
{
	public class Point
	{
		int x;
		int y;

		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public void printPoint()
		{
			Console.WriteLine("coordinate x = " + this.x + ", coordinate y = " + this.y);
		}
	}
}

