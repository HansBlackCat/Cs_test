//Operator, foreach, do while

using System

namespace Application
{
	public static void Main(string[] args)
	{
		//?? operator
		int? i = null;
		i = i ?? 0;

		string s = null;
		s = s ?? string.Empty;

		//Foreach
		string[] array = new string [] {"AB","CD","EF"};

		foreach (string s in array)
		{
			Console.WriteLine(s);
		}

		//do while
		int i = 1;

		do
		{
			Console.WriteLine(i);
			i++;
		} while	(i < 10);

	}
}