//Enum

using System

//enum only available in class, namespace
namespace Application
{
	public enum Category
	{
		Cake,
		IceCream,
		Bread
	}

	class Program
	{
		enum City
		{
			Seoul, //0
			Daejun, //1
			Busan = 5, //5
			Jeju = 10 //10
		}

		[Flags]
		enum Border
		{
			None = 0,
			Top = 1,
			Right = 2,
			Bottom = 4,
			Left = 8
		}

		static void Main(string[] args)
		{
			City myCity;

			//Substit value in enum type
			myCity = City.Seoul;

			//Casting int
			int cityValue = (int) myCity;

			if (myCity == City.Seoul) //Compare
			{
				Console.WriteLine("Welcome to Seoul");
			}

			//Use OR Multi Flag Assign
			Border b = Border.Top | Border.Bottom;

			//Use AND to Flags check
			if ((b & Border.Top) != 0)
			{
				//Use HasFlag() to Flags check
				if (b.HasFlag(Border.Bottom))
				{
					Console.WriteLine(b.ToString());
				}
			}
		}
	}
}