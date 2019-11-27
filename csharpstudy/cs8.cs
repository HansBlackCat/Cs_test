//yield

using System

namespace Application
{
	public class MyList
	{
		private int[] data = {1,2,3,4,5};

		public IEnumerable GetEnumerator()
		{
			int i = 0;
			while (i < data.Length)
			{
				yield return data[i];
				i++;
			}
		}
	}

	static IEnumerable<int> GetNumber()
	{
		yield return 10; //1st return
		yield return 20; //2nd return
		yield return 30; //3rd return
	}

	public static void Main(string[] args)
	{
		foreach (int num in GetNumber())
		{
			Console.WriteLine(num);
		}

		//Iteration using foreach
		var list = new MyList();

		foreach (var item in list)
		{
			Console.WriteLine(item);
		}

		//Manual iteration
		IEnumerable it = list.GetEnumerator();
		it.MoveNext();
		Console.WriteLine(it.Current); //1
		it.MoveNext();
		Console.WriteLine(it.Current); //2
	}
}