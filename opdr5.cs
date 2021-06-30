using System;
					
public class Program
{
	public static void Main()
	{
		int number = Int32.Parse(Console.ReadLine());
		int n1 = 0;
		int n2 = 1;
		Console.WriteLine(n1);
		Console.WriteLine(n2);
		for (int i = 0; i < number; i++) 
		{
			int n3=n1+n2;    
			Console.WriteLine(n3);    
			n1=n2;    
			n2=n3;    
		}
	}
}