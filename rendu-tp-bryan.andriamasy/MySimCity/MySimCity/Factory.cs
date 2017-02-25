using System;

namespace MySimCity
{
	class Factory : Building
	{
		public Factory()
		{
			cost = 1000;
		}
		public override void Print()
		{
			Console.WriteLine(" ||");
			Console.WriteLine(" ||");
			Console.WriteLine(" || |\\ |\\ |\\");
			Console.WriteLine(" ||_| \\| \\| \\");
			Console.WriteLine("|            |");
			Console.WriteLine("|            |");
			Console.WriteLine("|            |");
			Console.WriteLine("|____________|\n");
		}
	}
}
