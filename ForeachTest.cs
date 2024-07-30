using System;
class Trail
{
	public void op()
	{
		int[] arrayInt={11,22,33,44};
		foreach(int m in arrayInt)
		{
			Console.WriteLine(" "+m);
		}	
		Console.WriteLine( );	
	}

}
class ForeachTest
{
	public static void Main()
	{
		Trail obj =new Trail();
		obj.op();
	}
}