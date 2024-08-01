using System;
class ch8
{
	static void change(int m)
	{
		m= m+10;

	}


	public static void Main()
	{
		int x =100;
		change(x);
		Console.WriteLine("x="+ x);
	}
}