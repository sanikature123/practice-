using System;
class Trail
{
	public void op()
	{
		int a=10, b=5,c=8,d=2;
		float x=6.4F, y=3.0F;
		
		int answer1=a*b+c/d;
		int answer2=a*(b+c)/d;
	
		int answer3=a%c;
		float answer4=x%y;
		bool bool1=a>b && c>d;
		bool bool2=a<b && c>d;
		bool bool3=a<b || c>d;
		bool bool4= !(a-b ==c);

     		Console.WriteLine("order of evalution");
		Console.WriteLine("a*b+c/d="+ answer1);
		Console.WriteLine("a*(b+c)/d="+answer2);

		Console.WriteLine("module operators");
		Console.WriteLine("a%c="+ answer3);
		Console.WriteLine("x%y="+answer4);

		Console.WriteLine("logical  operators");
		Console.WriteLine("a>b && c>d ="+ bool1);
		Console.WriteLine("a<b && c>d ="+ bool2);
		Console.WriteLine("a>b || c>d ="+ bool3);
		Console.WriteLine("!(a-b)== c ="+ bool4);
		}


}
class Expresssion
{
	public static void Main()
	{
		Trail obj = new Trail();
		obj.op();	
	}
}