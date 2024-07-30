class Ch7
{
	public void op()
	{
		int n=1;
		while(n<=10)
		{
			if(n%2==0)
			{
				n++;
			}
			else
			{
				System.Console.WriteLine(""+n);
				n++;
			}
		}
	}
}
class WhileTest
{
	public static void Main()
	{
		Ch7 obj=new Ch7();
		obj.op();
	}

}