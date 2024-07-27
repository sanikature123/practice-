using System;
//using Maths;
class Trail
{
	public void op()
	{
		Console.WriteLine("sines of angle from 0 to 90 degree");
		for ( double theta = 0.0; theta <=90.00; theta +=15)
 		{
			double x = Math.Sin(theta * Math.PI/180);
			Console.Write("Sin" +theta);
			Console.WriteLine("={0:F4}" +x);
		}
	}


}
class MathTest
{
	public static void Main()
	{
		Trail obj = new Trail();
		obj.op();	
	}
}

