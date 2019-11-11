using System;

namespace ExercisesFunctions
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Skriv in ett datum på formatet: YYYY-MM-DD:");
			string input = Console.ReadLine();
			try
			{
				int year = Year(input);
				int month = Month(input);
				Console.WriteLine("Du skrev in året: " + year);
				Console.WriteLine("Du skrev in månaden: " + month);
			}
			catch (Exception)
			{
				Console.WriteLine("Ogiltigt värde! Skriv in datumet på formatet YYYY-MM-DD.");
			}

		}
		/*
			 2a Skriv en funktion add som lägger ihop två tal av datatypen double och returnerar resultatet.
			2b Skriv en funktion multi som multiplicerar tre tal och returnerar resultatet.
			2c Skriv en funktion som tar fyra tal som parametrar. Den ska multiplicera de tre första och lägga ihop resultatet med den fjärde och sedan returnera resultatet. Använd funktionerna add och multi.
			*/
		static double Add(double a, double b)
		{
			return a + b;
		}
		static double Multi(double x, double y, double z)
		{
			return x * y * z;
		}
		static double Calculate(double m1, double m2, double m3, double x)
		{
			return Add(Multi(m1, m2, m3), x);
		}


		/*
		 * 5 Skriv en funktion som avrundar ett tal till två decimaler. Tips: använd Math.Round med en parameter för att avrunda ett tal till närmast heltal. (Man kan anropa Math.Round med en parameter till, som är antalet decimaler man vill ha. Gör inte så för den här övningen.)
			Extra utmaning: skriv funktionen utan att använda Math.Round. Fundera på vilka andra sätt det finns att ta bort decimaler från ett tal.
				*/
		static double Round2(double x)
		{
			return Math.Round(x * 100.0) / 100.0;
		}

		/* 9 Skriv en funktion som du kallar year som returnerar året som ett heltal från en sträng i datumformat: "YYYY-MM-DD". Funktionen ska ta en parameter, som ska vara en sträng. Strängen ska alltid ha 10 tecken och använda datumformatet. Till exempel så är
		Year("2016-11-02") == 2016.
		*/
		static int Year(string date)
		{
			// "YYYY-MM-DD"
			string yearPart = date.Substring(0, 4);
			int year = int.Parse(yearPart);
			return year;
		}
		static int Month(string date)
		{
			string monthPart = date.Substring(5, 2);
			int month = int.Parse(monthPart);
			return month;
		}
		// "MM/DD YYYY"
		// 1970-01-01
	}
}
