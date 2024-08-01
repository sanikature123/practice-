using System;
class ch8
{
	public void Square(int x,out int y)
	{
		y=x*x;
	}
}
class output
{
	public static void Main()
	{
		int m;
		ch8 obj=new ch8();
		obj.Square(10,out m);
		Console.WriteLine("m="+m);
	}

}