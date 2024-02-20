using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassPROGRAM_UNIT2
{
	internal class Wizard
	{

		public string name { get; set; }
		public int age { get; set; }
		public string CharacteristicColors { get; set; }
		public Wizard(string name_2, int age_2)
		{
			this.name = name_2;
			this.age = age_2;
		}

		public void castspells()
		{
			Console.WriteLine($"{name} raises their wand and murmurs 'PETRIFICUS TOTALUS'");
		}
		public void LearnSpell()
		{
			Console.WriteLine($"{name} is studying the spellbooks...");
			Console.WriteLine($"{name} has learned the spell: !ALOHOMORA!");
		}
		public override string ToString()
		{
			return $"Name: {name}, Age: {age}, Characteristic Colors: {CharacteristicColors}";
		}


	}
}
