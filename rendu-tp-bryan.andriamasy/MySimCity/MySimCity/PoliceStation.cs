using System;

namespace MySimCity
{
	class PoliceStation : Building
	{
		protected int job;

		public PoliceStation()
		{
			cost = 400;
			job = 20;
		}
		public override void Print()
		{
			Console.WriteLine("/------------\\");
			Console.WriteLine("|            |");
			Console.WriteLine("| [ POLICE ] |----------\\");
			Console.WriteLine("|            |  ______  |");
			Console.WriteLine("|            | |------| |");
			Console.WriteLine("|____________|_|______|_|\n");
		}
	}
}
