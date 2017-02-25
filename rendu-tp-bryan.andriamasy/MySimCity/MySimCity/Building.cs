using System;

namespace MySimCity
{
	abstract class Building
	{
		public int cost { get; set; }

		enum BuildingType { House, CityHall, policeStation, Factory, Shop };

		public Building()
		{
		}

		public abstract void Print();
	}
}
