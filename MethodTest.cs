using System;
class ch8
{
	public int Cube(int x)
	{
		return(x*x*x);
	}	

}
 
class MethodTest
{
	public static void Main()
	{
		ch8 M = new ch8();
		int y = M.Cube(5);
		Console.WriteLine(y);
	}
}