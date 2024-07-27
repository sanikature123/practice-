using System;
class Trail
{
	public void op()
	{
		float sum;
		int i;
		sum = 0.0F;
		for(i = 1; i<= 10; i++)
		{
			sum = sum + 1/(float)i;
			Console.WriteLine("i="+i);
			Console.WriteLine("sum ="+sum);
		
		}
	}
}
class Casting
{
	public static void Main()
	{
		Trail obj = new Trail();
		obj.op();	
	}
}
		