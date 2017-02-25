using System;

namespace MySimCity
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Town mytown = new Town();
			do
			{
				mytown.PrintState();

				mytown.InputRead();
				Console.Clear();
				mytown.PrintBuildings();
				mytown.Update();
				mytown.PrintState();
			} while (true);
		}
	}
}
