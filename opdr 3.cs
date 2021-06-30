using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("geef 2 getallen en een operator");
		float getal1 = Convert.ToInt32(Console.ReadLine());
		float getal2 = Convert.ToInt32(Console.ReadLine());
		string operatorr = Console.ReadLine();
		
		if (operatorr == "+"){
			Console.WriteLine(getal1 + getal2);
		}
		else if (operatorr == "-"){
			Console.WriteLine(getal1 + getal2);
		}
		else if (operatorr == "*"){
			Console.WriteLine(getal1 * getal2);
		}
		else if (operatorr == "/"){
			Console.WriteLine(getal1 / getal2);
		}
		else{
			Console.WriteLine("operator moet +, -, * of / zijn");
		}
	}
}