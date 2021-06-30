using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Geef het geheime woord en 2 hints");
		string GH_woord = Console.ReadLine();
		string hint1 = Console.ReadLine();
		string hint2 = Console.ReadLine();
		
		Console.WriteLine("Raad het woord");
			string gok1 = Console.ReadLine();
			if (gok1 ==  GH_woord){
				Console.WriteLine("Goedzo! dat was het woord.");	
			}
			else{
				Console.WriteLine("");
				Console.WriteLine("Hint: " + hint1);
				Console.WriteLine("Raad opnieuw");
				string gok2 = Console.ReadLine();
				if (gok2 == GH_woord){
					Console.WriteLine("Goedzo! dat was het woord.");	
				}
				else{
					Console.WriteLine("");
					Console.WriteLine("Hint: " + hint2);
					Console.WriteLine("Raad opnieuw");
					string gok3 = Console.ReadLine();
					if (gok3 == GH_woord){
						Console.WriteLine("Goedzo! dat was het woord");
					}
					else{
					Console.WriteLine("Je hebt het woord niet geraden. het woord was: " + GH_woord);
					} 
				}
			}
	}
}