using System;
class  Overloading
{	public static void Main()
	{	
		Console.WriteLine(volume(10));
		Console.WriteLine(volume(2.5F,8));
		Console.WriteLine(volume(100L,75,15));
	}
	
	static int volume(int x)
	{
		return(x*x*x);
	}
	static double volume(float r, int h)
	{
		return(3.14519*r*r*h);
	}
	static long volume(long l,int b,int h)
	{
		return(l*b*h);
	}
}
