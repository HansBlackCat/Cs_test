namespace CS3
{
	class Program
	{
		static int CalculateSum(int[] scoresArray)
		{
			int sum = 0;
			for (int i = 0, i<scoresArray.Length; i++)
			{
				sum += scoresArray[i];
			}
			return sum;
		}

		public static void Main(string[] args)
		{
			//Jagged Arr
			//Need to write 1st-order arr size
			int[][] A = new int[3][];

			//Can allocate different size array in each 1st array compon
			A[0] = new int [2];
			A[1] = new int [3] {1,2,3};
			A[2] = new int [4] {1,2,3,4};

			A[0][0] = 1;
			A[0][1] = 2;

			//Cs Arr
			int sum = 0;
			int[] scores = {80,70,60,76,56,100};
			for (int i = 0, i<scores.Length; i++)
			{
				sum += scores[i];
			}
			Console.WriteLine(sum);

			int sum2 = CalculateSum(scores);
			Console.WriteLine(sum2);
		}
	}
}