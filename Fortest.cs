using System;

class Ch7
{
	public void op()
	{
		long p;
		int n;
		double q;
		Console.WriteLine("2 to power -n     n     2 to power n");

		p=1L;
		for(n=0;n<10;++n)
		{
			if(n==0)
				p=1L;
			else
				p=p*2;
			q=1.0/(double)p;
			Console.WriteLine("{0:F6}          {1:D}        {2:D}" , q,n,p);
		}	
	}
}
class Fortest
{
	public static void Main()
	{
		Ch7 obj=new Ch7();
		obj.op();
	}
}