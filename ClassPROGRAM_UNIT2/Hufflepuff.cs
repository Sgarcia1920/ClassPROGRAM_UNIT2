﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPROGRAM_UNIT2
{
	internal class Hufflepuff: Wizard
	{
		private const string DefaultColors = "Yellow and Black";

		public Hufflepuff(string name_2, int age_2) : base(name_2, age_2)
		{
			this.name = name_2;
			this.age = age_2;
			this.CharacteristicColors = DefaultColors;
		}



	}
}
