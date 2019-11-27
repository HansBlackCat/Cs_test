//CS string
using System;

namespace Allication
{
	public static void Main(string[] args)
	{
		//String vari
		string s1 = "C#";
		string s2 = "Programming";

		//Char vari
		char c1 = 'A';
		char c2 = 'B';

		//Combination
		string s3 = s1 + " " + s2;
		Console.WriteLine("String: {0}", s3);

		//Substring combin
		string s3sub = s3.Substring(1,5);
		Console.WriteLine("Substring: {0}", s3sub);

		string s = "C# Studies";

		//Char access
		for (int i = 0, i<s.Length, i++)
		{
			Console.WriteLine("{0}: {1}", i, s[i]);
		}

		//Str arr -> str
		char[] charArr2 = {'A','B','C','D'};
		s = new string(charArr2);

		Console.WriteLine(s);

		//Char calcu
		char c1 = 'A';
		char c2 = (char)(c1+3);
		Console.WriteLine(c2);

	}
}