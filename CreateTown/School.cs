using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTown
{
	class School
	{
		public string BuildingType { get; set; }
		public string Name { get; set; }
		public string ConstructionMaterial { get; set; }
		//DEBUG still need to make this read-only
		public int CurrentOccupants { get; set; }

		public int BathRooms { get; set; }
		public int ClassRooms { get; set; }
		public int Floors { get; set; }
		public int NumberOfRoom { get; set; }

		public double Height { get; set; }
		public double Length { get; set; }
		public double Width { get; set; }
		public double SquareFootage { get { return (Length * Width); } }
		public double Volume { get { return (SquareFootage * Height); } }

		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public int Zip { get; set; }
		public string FullAddress
		{
			get { return string.Format("{0}, {1}, {2}, {3}, {4}", Address1, Address2, City, State, Zip); }
		}

		public bool InSession { get; set; }
		public int NumberOfStudents { get; set; }
		public int NumberOfTeachers { get; set; }

		public School(string name, string constructionMaterial, int currentOccupants, int bathRooms, int classRooms, int floors, int numberOfRoom, double length, double width, double height, string address1, string address2, string city, string state, int zip, int numberOfStudents, int numberOfTeachers)
		{
			this.BuildingType = "School";
			this.Name = name;
			this.ConstructionMaterial = constructionMaterial;
			this.BathRooms = bathRooms;
			this.ClassRooms = classRooms;
			this.Floors = floors;
			this.NumberOfRoom = numberOfRoom;
			this.Length = length;
			this.Height = height;
			this.Width = width;
			this.Address1 = address1;
			this.Address2 = address2;
			this.City = city;
			this.State = state;
			this.Zip = zip;
			this.NumberOfStudents = numberOfStudents;
			this.NumberOfTeachers = numberOfTeachers;

		}

		public int DecreaseOccupants()
		{
			return CurrentOccupants--;
		}


		public int IncreaseOccupants()
		{
			//return CurrentOccupants++;
			return CurrentOccupants++;
		}

		public string DisplayName()
		{
			return this.Name;
		}

		public override string ToString()
		{
			return $"{BuildingType} : {Name}";
		}

		public string TeacherStudentRatio()
		{
			// Get the greatest common divisor for number of teachers and number of students
			int Remainder;
			int a = NumberOfTeachers;
			int b = NumberOfStudents;

			while (b != 0)
			{
				Remainder = a % b;
				a = b;
				b = Remainder;
			}

			return string.Format("{0}:{1}", NumberOfTeachers / a, NumberOfStudents / a);
		}

	}

}

