using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTown
{
	class House
	{
		public int BathRooms;
		public int BedRooms;
		public int Floors;
		public int NumberOfRoom;
		public double Height;
		public double Length;
		public double Width;
		public double SquareFootage = Length * Width;
		public double Volume = SquareFootage * Height;

		public string BuildingType;

		public CurrentOccupants {get;};


		CreateTown()
	{
		BuildingType = "House";
	}

	public int DecreaseOccupants()
	{
		return CurrentOccupants--;
	}

	public int IncreaseOccupants()
	{
		return CurrentOccupants++;
	}
	public override string DisplayName()
	{
		return this.Name;
	}

	public override string ToString()
	{
		return $"{BuildingType} : {Name}";
	}
}

