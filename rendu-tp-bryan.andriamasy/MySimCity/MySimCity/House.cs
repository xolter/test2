using System;

namespace MySimCity
{
	class House : Building
	{
		//private bool occupied;
		//private int inhabitants;

		public House()
		{
			cost = 300;
		}

		public override void Print()
		{
			Console.WriteLine("/----------\\");
			Console.WriteLine("|          |");
			Console.WriteLine("| [ ]  [ ] |");
			Console.WriteLine("|          |");
			Console.WriteLine("|__________|\n");
		}
	}
}
