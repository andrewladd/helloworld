using System;

public class rps
{
	public static void Main()
	{
		Console.WriteLine("Welcome to: \"Rock Paper Scissors\"!");
		Console.WriteLine("Choose an option:\n1. Rock\n2. Paper\n3. Scissors");
		
		Console.Write("Your choice: ");
		int choice = Int32.Parse(Console.ReadLine());
		
		
		Random rndm = new Random();
		int r = rndm.Next(1,4);
		
		switch (choice)
		{
			case 1:
				if (r == 1)
					Console.WriteLine("Tie!");
				else if (r == 2)
					Console.WriteLine("You lose!");
				else if (r == 3)
					Console.WriteLine("You win!");
				break;
			
			case 2:
				if (r == 2)
					Console.WriteLine("Tie!");
				else if (r == 3)
					Console.WriteLine("You lose!");
				else if (r == 1)
					Console.WriteLine("You win!");
				break;
			
			case 3:
				if (r == 3)
					Console.WriteLine("Tie!");
				else if (r == 1)
					Console.WriteLine("You lose!");
				else if (r == 2)
					Console.WriteLine("You win!");
				break;
			
			default:
				Console.WriteLine("You need to input a 1, 2, or 3.");
				System.Environment.Exit(1);
				break;
		}
		System.Environment.Exit(0);
	}
}
 
