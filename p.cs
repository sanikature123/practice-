using System;
class ch8
{
	 public static void Parray(params int[] arr)
	{
		Console.Write("Array elementa are:");
		foreach (int i in arr)
			Console.Write(" "+i);
		Console.WriteLine();
	}
}
class p
{
	public static void Main()
	{
		int[]x={11,22,33};
	ch8 obj=new ch8();

		obj.Parray(x);
		obj.Parray();
		obj.Parray(100,200);
	}
}
