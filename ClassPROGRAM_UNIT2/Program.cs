
namespace ClassPROGRAM_UNIT2
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			try
			{
			Console.WriteLine("Enter name:  ");
			string player = Console.ReadLine();
			Console.WriteLine("Enter age:  ");
			int ageplayer =Convert.ToInt32( Console.ReadLine());

			Console.WriteLine("WELCOME TO HOGWARTS\n Choose a house: ");
			Console.WriteLine("1) Gryffindor\n2)Slytherin\n3)Ravenclaw\n4)Hufflepuff ");
			int option = Convert.ToInt16(Console.ReadLine());
			
				switch (option)
				{
					case 1:
						Gryffindor wizard_new = new Gryffindor(player, ageplayer);
						Console.WriteLine(wizard_new.ToString());
						wizard_new.castspells();
						break;
					case 2:
						Slytherin wizardSly_new = new Slytherin(player, ageplayer);
						Console.WriteLine(wizardSly_new.ToString());
						wizardSly_new.LearnSpell();
						break;
					case 3:
						Ravenclaw wizardRa_new = new Ravenclaw(player, ageplayer);
						Console.WriteLine(wizardRa_new.ToString());
						wizardRa_new.castspells();
						break;
					case 4:
						Hufflepuff wizardH_new = new Hufflepuff(player, ageplayer);
						Console.WriteLine(wizardH_new.ToString());
						wizardH_new.LearnSpell();
						break;

					default:
						Console.WriteLine("You were not selected");
						break;
				}
			}
			catch (Exception)

			{
				Console.WriteLine("A value was added incorrectly");

			}

			Console.ReadKey();
		}

	}
}