using System;

namespace MySimCity
{
	public class Town
	{
		Building build;
		int nbCityHall;
		int nbHouse;
		int nbShop;
		int nbFactory;
		int nbPoliceStation;
		int nbBuilding;
		int money;
		int population;
		int job;

		public Town()
		{
			nbCityHall = 0;
			nbHouse = 0;
			nbShop = 0;
			nbFactory = 0;
			nbPoliceStation = 0;
			nbBuilding = 0;
			money = 2000;
			population = 0;
			job = 0;
		}
		public bool AddBuilding()
		{
			if (build.cost == 200)
			{
				if (nbCityHall == 0)
				{
					nbCityHall++;
					nbBuilding++;
					money -= build.cost;
					return true;
				}
				else
				{
					Console.WriteLine("there is already a city hall");
					return false;
				}
			}
			else if (build.cost == 300 && money - build.cost >= 0)
			{
				if (job >= population + 30)
				{
					nbHouse++;
					nbBuilding++;
					population += 30;
					money -= build.cost;
					return true;
				}
				else
				{
					Console.WriteLine("there is not enough job to bring new people in the city");
					return false;
				}
			}
			else if (build.cost == 400 && money - build.cost >= 0)
			{
				nbBuilding++;
				nbPoliceStation++;
				money -= build.cost;
				return true;
			}
			else if (build.cost == 500 && money - build.cost >= 0)
			{
				nbBuilding++;
				nbShop++;
				money -= build.cost;
				return true;
			}
			else if (build.cost == 1000 && money - build.cost >= 0)
			{
				nbBuilding++;
				nbFactory++;
				job += 100;
				money -= build.cost;
				job += 100;
				return true;
			}
			else
			{
				Console.WriteLine("Not enough money to buy that");
				return false;
			}
		}
		public bool DestroyBuilding()
		{
			if (build.cost == 300 && nbHouse >= 1)
			{
				nbBuilding--;
				nbHouse -= 1;
				money += 150;
				return true;
			}
			else if (build.cost == 400 && nbPoliceStation >= 1)
			{
				nbBuilding--;
				nbPoliceStation -= 1;
				money += 200;
				return true;
			}
			else if (build.cost == 500 && nbPoliceStation >= 1)
			{
				nbBuilding--;
				nbShop -= 1;
				money += 250;
				return true;
			}
			else if (build.cost == 1000 && nbFactory >= 1)
			{
				nbBuilding--;
				nbFactory -= 1;
				money += 500;
				return true;
			}
			else
			{
				Console.WriteLine("The building doesn't exist");
				return false;
			}
		}
		public void PrintBuildings()
		{
			int cursorl = Console.CursorLeft;
			int cursort = Console.CursorTop;
			Console.SetCursorPosition(0, 15);
			for (int i = 0; i < nbCityHall; i++)
			{
				build = new CityHall();
				build.Print();
			}

			for (int i = 0; i < nbHouse; i++)
			{
				build = new House();
				build.Print();
			}
			for (int i = 0; i < nbShop; i++)
			{
				build = new Shop();
				build.Print();
			}
			for (int i = 0; i < nbFactory; i++)
			{
				
				build = new Factory();
				build.Print();
			}
			for (int i = 0; i < nbPoliceStation; i++)
			{
				build = new PoliceStation();
				build.Print();
			}
		}
		public void PrintState()
		{
			Console.SetCursorPosition(0, 0);
			Console.WriteLine("current money: " + money);
			Console.WriteLine("population: " + population);
			Console.WriteLine("Number of building: " + nbBuilding);
			Console.WriteLine("----------------------------");
		}
		public void Update()
		{
			for (int i = 0; i < nbShop; i++)
			{
				money += 20;
			}
			for (int i = 0; i < nbPoliceStation; i++)
			{
				money -= 5;
			}
		}
		public void InputRead()
		{
			Console.WriteLine("write \"wait\" or\nwrite \"add\" or \"destroy\" +\n\"c\" for city hall\n\"h\" for house\n\"s\" for shop\n\"f\" for factory\n\"p\" for police station");
			Console.WriteLine("----------------------------");
			Console.Write("Write your command: ");
			string s = Console.ReadLine();
			if (s == "wait")
			{
				Console.ReadKey();
			}
			else if (s == "add c")
			{
				build = new CityHall();
				AddBuilding();
			}
			else if (s == "add h")
			{
				build = new House();
				AddBuilding();
			}
			else if (s == "add s")
			{
				build = new Shop();
				AddBuilding();
			}
			else if (s == "add f")
			{
				build = new Factory();
				AddBuilding();
			}
			else if (s == "add p")
			{
				build = new PoliceStation();
				AddBuilding();
			}
			else if (s == "destroy c")
			{
				Console.WriteLine("the city hall cannot be destroy");
			}
			else if (s == "destroy h")
			{
				build = new House();
				DestroyBuilding();
			}
			else if (s == "destroy s")
			{
				build = new Shop();
				DestroyBuilding();
			}
			else if (s == "destroy f")
			{
				build = new Factory();
				DestroyBuilding();
			}
			else if (s == "destroy p")
			{
				build = new PoliceStation();
				DestroyBuilding();
			}
		}
	}
}
