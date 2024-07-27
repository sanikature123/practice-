class Trail
{
	public void op()
	{
		int m= 10, n=20;
		System.Console.WriteLine("m="+m);
		System.Console.WriteLine("n="+n);
		System.Console.WriteLine("++m="+ ++m);
		System.Console.WriteLine("n++="+ n++);
		System.Console.WriteLine("m="+m);
		System.Console.WriteLine("n="+n);
	}
}
class IncrementOP
{
	public static void Main()
	{
		Trail obj = new Trail();
		obj.op();	
	}
}