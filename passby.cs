using System;
class passby
{
	static void Swap(ref int x,ref int y)
	{	
		int temp=x;
		x=y;
		y=temp;
	}
	public static void Main()
	{
		int m=100;
		int n=200;
		Console.WriteLine("before swapping");
		Console.WriteLine("m="+m);
		Console.WriteLine("n="+n);
		Swap(ref m,ref n);
		Console.WriteLine("after swapping");
		Console.WriteLine("m="+m);
		Console.WriteLine("n="+n);

	}
}