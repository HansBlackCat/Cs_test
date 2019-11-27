namespace Intro_Ex1
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Console.writeLine("Hello Worlds...");

			bool b=true;


			short sh=-376;
			int i=21323;
			long l=123l;
			float f=123.56f;
			double d1=123.3;
			double d2=234.45d;
			deciaml d=12.34m;

			int i = int.MaxValue;
			float f = float.MinValue;

			string s;
			s = null;

			//Nullable Type
			int? i=null;
			i=101;
			bool? b = null;

			//Allocate int? to int
			Nullable<int> j=null;
			j=10;
			int k =j.Value;
		}
	}
}

