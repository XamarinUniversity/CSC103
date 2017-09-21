using System;

namespace TipCalculation
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Tipper tipper = new Tipper();

			while (true)
			{
				Console.Write("Please enter check amount: ");
				tipper.TotalBill = double.Parse(Console.ReadLine());

				Console.Write("B)ad tip O)k tip G)ood Tip D)ivvy the bill Q)uit: ");
				char operation = Console.ReadLine().ToUpper()[0];

				if (operation == 'Q')
					break;

				double answer = 0.0;

				switch (operation)
				{
					case 'B':
						answer = tipper.CalculateTip(0.10);
						break;

					case 'O':
						answer = tipper.CalculateTip(); // for 15% you can use the no-parameter version
						break;

					case 'G':
						answer = tipper.CalculateTip(0.20);
						break;

					case 'D':
						Console.Write("Number of people? ");
						int numPeople = int.Parse(Console.ReadLine());
						answer = tipper.Divvy(numPeople);
						break;

					default:
						Console.WriteLine("Please enter B, O, G, D or Q");
						break;
				}

				Console.WriteLine("Answer: {0}", answer);
			}
		}
	}
}