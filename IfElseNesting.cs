Class  IfElseNesting
{
   public static void Main()
   { 
      int a = 325, b = 712, c = 478; 

      Console. Write("Largest value is: ");

      if (a > b)
      {
	if (a > c)
	{ 
	  Console. WriteLine(a);
	}

	else
	{ 
	  Console. WriteLine(c);
	}
      }

    else
    {
       if (c > b)
       { 
 	 Console. WriteLine(c);
       }
     
      else
      {
	Console. WriteLine(b);
      }

    }

  }  

}