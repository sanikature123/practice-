using System;
class ch8
{
	public void Largest(int m, int n)
	{
		int large=Max(m,n);
		Console.Write(large);
	}
	int Max(int a,int b)
	{
		int x=(a>b)?a:b;
		return(x);
	}

} 
class NestTesting
{

	public static void Main()
	{
		ch8 obj=new ch8();
		obj.Largest( 100,200);
	}
}