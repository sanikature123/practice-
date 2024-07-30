using System;
class output
{
	static void Square(int x,out int y)
	{
		y=x*x;
	}
	public static void main()
	{
		int m;
		Square(10,out m);
		Console.WriteLine("m="+m);
	}

}