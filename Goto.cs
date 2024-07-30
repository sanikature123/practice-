using System;
class Trail
{
	public void op()
	{
		for (int i=1;i<100;i++)
		{
			Console.WriteLine(" ");
			if (i>=10)
			break;
		for (int j=1;j<100;j++)
		{
			Console.WriteLine(" * ");
			if (j==i)
			goto loop1;
		}
		loop1:continue;
		}
		Console.WriteLine("terminate by break");
	}
}
class Gotolabel
{
	public static void Main()
	{
		Trail obj = new Trail();
		obj.op();
	}
} 