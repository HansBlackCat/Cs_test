//StringBuilder

using System;
using System.Text;

namespace MySystem
{
	class Program
	{
		static void Main(string[] args)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 1; i <= 26, i++)
			{
				sb.Append(i.ToString());
				sb.Append(System.Environment.NewLine);
			}
			string s = sb.ToString();

			Console.WriteLine(s);
		}
	}
}