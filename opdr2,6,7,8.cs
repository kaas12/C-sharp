using System;
using System.Linq;
public class Mobiel{
		public string type;
		public string model;
		public string os;
		public string ceo;
		public float price;
		
		public Mobiel (string ntype, string nmodel, string nos, string nceo , float nprice)
		{
			ceo = nceo;
			type = ntype;
			model = nmodel;
			os = nos;
			price = nprice;
	}
}

public class Program
{
		float[] prijzen = {0.2f, 1f, 2f, 2.4f, 1.2f, 3.0f,3.5F,4.0F,4.5F,5.0F};
		string[] producten = {"snoepje", "appel", "kiwi", "zakje drop", "banaan", "peper","chips","ijsjes","pompoen","meloen",};
	public void Main()
	{
		string product_1 = "";
		string product_2 = "";
		string product_3 = "";
		const float btw_factor = 0.21f;
		Sales();
		
		

		
		
		for (int i = 0; i < 10; i++) 
		{
		  	Console.Write(producten[i] + " "); Console.WriteLine(prijzen[i]);
			
		}
		Console.WriteLine(" ");
		Console.WriteLine("Geef 3 producten (vergeet niet na elk product op enter te druken.)");
		product_1 = Console.ReadLine();
		if (!producten.Contains(product_1))
		{
			Console.WriteLine("Ongeldige input");
			product_1 = "";
		}
				product_2 = Console.ReadLine();
		if (!producten.Contains(product_2))
		{
			Console.WriteLine("Ongeldige input");
			product_2 = "";
		}
				product_3 = Console.ReadLine();
		if (!producten.Contains(product_3))
		{
			Console.WriteLine("Ongeldige input");
			product_3 = "";
		}
		Console.WriteLine(" ");
		Console.WriteLine("Hoe veel keer wil je " + product_1 + " kopen?");
		int factor1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Hoe veel keer wil je " + product_2 + " kopen?");
		int factor2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Hoe veel keer wil je " + product_3 + " kopen?");
		int factor3 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine(" ");
		Console.WriteLine(" ");
		
		Console.WriteLine("Te betalen:");
		Console.WriteLine(factor1 + " keer " + product_1);
		Console.WriteLine(factor1 * prijzen[Array.FindIndex(producten, row=> row.Contains(product_1))]);
		Console.WriteLine(factor2 + " keer " + product_2);
		Console.WriteLine(factor2 * prijzen[Array.FindIndex(producten, row=> row.Contains(product_2))]);
		Console.WriteLine(factor3 + " keer " + product_3);
		Console.WriteLine(factor3 * prijzen[Array.FindIndex(producten, row=> row.Contains(product_3))]);
		Console.WriteLine("");
		float subtotaal = factor1 * prijzen[Array.FindIndex(producten, row=> row.Contains(product_1))] + factor2 * prijzen[Array.FindIndex(producten, row=> row.Contains(product_2))] + factor3 * prijzen[Array.FindIndex(producten, row=> row.Contains(product_3))];
		Console.WriteLine("Subtotaal: " + subtotaal);
		Console.WriteLine("");
		float btw_kosten = BTWberekenen(factor1 * prijzen[Array.FindIndex(producten, row=> row.Contains(product_1))], factor2 * prijzen[Array.FindIndex(producten, row=> row.Contains(product_2))], factor3 * prijzen[Array.FindIndex(producten, row=> row.Contains(product_3))], btw_factor);
		Console.WriteLine("Btw kosten: " + btw_kosten);
		float totaal = btw_kosten+subtotaal;
		Console.WriteLine("Totaal: " + totaal);
		Console.WriteLine("");
		
	}
	public float BTWberekenen(float p1, float p2, float p3, float btwpr)
	{
		float newbtw;
		return newbtw = (p1 + p2 + p3) * btwpr;
	}
	public void Sales(){
		Mobiel mobiel1 = new Mobiel("Iphone", "IphoneXS", "Apple IOS", "Steve Jobs", 230);
		Mobiel mobiel2 = new Mobiel("Samsung", "Galaxy S7", "Android", "Kim Hyun-suk", 110);
		Mobiel mobiel3 = new Mobiel("Google Pixel", "Pixel3", "ChromeOs", "Sundar Pichai", 50);
		float subtotaal = 0;
		
		
		Console.Write(mobiel1.model + " "); Console.Write(mobiel1.ceo+ " "); Console.WriteLine(mobiel1.price);
		Console.Write(mobiel2.model + " "); Console.Write(mobiel2.ceo+ " "); Console.WriteLine(mobiel2.price);
		Console.Write(mobiel3.model + " "); Console.Write(mobiel3.ceo+ " "); Console.WriteLine(mobiel3.price);
		Console.WriteLine("");
		Console.WriteLine("hoeveel mobieltjes wil je kopen?");
		int amount = Convert.ToInt32(Console.ReadLine());
		for(int i = 0; i < amount; i++)
		{
    		Console.WriteLine("Welke telefoon wil je kopen?");
			string cp = Console.ReadLine();
			if (cp == mobiel1.model){
				subtotaal = subtotaal + mobiel1.price;
			}
			else if (cp == mobiel2.model){
				subtotaal = subtotaal + mobiel2.price;
			}
			else if (cp == mobiel3.model){
				subtotaal = subtotaal + mobiel3.price;
			}
			else{
				Console.WriteLine("ongeldige input");
			}
		}
		Console.WriteLine(subtotaal);
		if (subtotaal < 100){
			subtotaal = subtotaal + 20;
			Console.WriteLine("er word 20 euro verzendkosten bij gerekend");
		}
		else {
			Console.WriteLine("Je hoeft geen verzendkosten te betalen");
		}
			Console.WriteLine("Totaal: " + subtotaal*1.21);
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
		}
	}


