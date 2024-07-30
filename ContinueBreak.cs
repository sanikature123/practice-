using System;
class Trail
{
	public void op()
	{
		int n=10;
		while(n<200)
		{
			if (n<50)
			{
				Console.WriteLine(" "+n);
				n=n+10;
				continue;
			}
			if (n==50)
			{
				Console.WriteLine( );
				n=n+10;
				continue;
			}
			if (n>90)break;
				Console.WriteLine(" "+n);
				n=n+10;
		}
		Console.WriteLine( );
	}
}
class ContinueBreak
{
	public static void Main()
	{
		Trail obj = new Trail();
		obj.op();
	}
} 