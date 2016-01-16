using System;

namespace fahrenheit
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			const double K= 1.8;
			const double j= 32;

			Console.WriteLine ("Type temperature in celsius:");
			double tC = double.Parse (Console.ReadLine ());
			double tF = K * tC + j;

			Console.WriteLine ( "Temperature in fahranheit:{0}", tF%d);
		}
	}
}