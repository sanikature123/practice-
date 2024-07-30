class Ch7
{
	public void op()
	{
		int row, column,y;
		row=1;
		System.Console.WriteLine("multiplication table \n");
		do
		{
			column=1;
			do
			{
				y=row*column;
				System.Console.Write(""+y);
				column=column+1;
			}
			while(column<=3);
			System.Console.WriteLine("\n");
			row=row+1;
		}
		while(row<=3);
	} 

}
class DoWhileTest
{
	public static void Main()
	{
	Ch7 obj = new Ch7();
	obj.op();
	}
}
