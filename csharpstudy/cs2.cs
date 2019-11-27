using System;

namespace ConsoleApplication1
{
	class CSVar
	{
		//Field (Global Vari inside Class)
		int gobalVar;
		const int MAX = 1024;


		public void Method1()
		{
			//Local Vri
			int LocalVar;

			//Need Allocate
			LocalVar = 100;

			Console.WriteLine(gobalVar);
			Console.WriteLine(LocalVar);
		}

		//Const
		const int MAX_VALUE = 1024;

		//readonly Field
		readonly int Max;
		public CSVar()
		{
			Max = 1;
		}


	}

	class Program
	{
		// All Program need Main()
		static void Main(string[] args)
		{
			//Test
			CSVar obj = new CSVar();
			obj.Method1();
		}
	}

}