using System;

namespace Travel
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			RoadTrip chores   = new RoadTrip();
			RoadTrip vacation = new RoadTrip();

			chores.Miles = 50.00;
			chores.HoursElapsed = 2.00;
			chores.GallonsUsed = 1.50;

			vacation.Miles = 400.00;
			vacation.HoursElapsed = 12.00;
			vacation.GallonsUsed = 9.00;

			Console.WriteLine(chores.Miles);
			Console.WriteLine(chores.HoursElapsed);
			Console.WriteLine(chores.GallonsUsed);

			Console.WriteLine(); // add a blank line to the output

			Console.WriteLine(vacation.Miles);
			Console.WriteLine(vacation.HoursElapsed);
			Console.WriteLine(vacation.GallonsUsed);
		}
	}
}
