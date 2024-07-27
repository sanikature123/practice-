class Trail
{
	public void op()
	{
		float a=20.5F, b=6.4F;
		System.Console.WriteLine("a="+ a);
		System.Console.WriteLine("b="+ b);
		System.Console.WriteLine("a+b="+ (a+b));
		System.Console.WriteLine("a-b="+ (a-b));
		System.Console.WriteLine("a*b="+ (a*b));
		System.Console.WriteLine("a/b="+ (a/b));
		System.Console.WriteLine("a%b="+ (a%b));
	}
}
class Floatpoint
{
	public static void Main()
	{
		Trail obj = new Trail();
		obj.op();	
	}
}


