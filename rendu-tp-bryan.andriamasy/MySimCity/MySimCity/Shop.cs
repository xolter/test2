using System;

namespace MySimCity
{
	class Shop : Building
	{
		protected int job;

		public Shop()
		{
			cost = 500;
			job = 5;
		}

		public override void Print()
		{
			Console.WriteLine(" ______________");
			Console.WriteLine("|              |");
			Console.WriteLine("|   | SHOP |   |");
			Console.WriteLine("|              |");
			Console.WriteLine("|              |");
			Console.WriteLine("|      __      |");
			Console.WriteLine("|_____|  |_____|\n");

		}
	}
}
