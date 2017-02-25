using System;

namespace MySimCity
{
	class CityHall : Building
	{
		public CityHall()
		{
			cost = 200;
		}

		public override void Print()
		{
			Console.WriteLine("/-----------------------\\");
			Console.WriteLine("|     [ CITYHALL ]      |");
			Console.WriteLine("\\-----------------------/");
			Console.WriteLine("   | |  | |   | |  | |");
			Console.WriteLine("   | |  | |   | |  | |");
			Console.WriteLine("   | |  | |   | |  | |");
			Console.WriteLine("   | |  | |   | |  | |");
			Console.WriteLine("   | |  | |   | |  | |");
			Console.WriteLine("   | |  | |   | |  | |");
			Console.WriteLine("|-----------------------|");
			Console.WriteLine("|-----------------------|");
			Console.WriteLine("|_______________________|\n");
		}
	}
}
