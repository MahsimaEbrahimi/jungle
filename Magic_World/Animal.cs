using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_World
{
    public abstract class Animal
    {
        public string Type { get; set; }
        public string Name { get; set; }
		public int Age { get; set; }
		public bool AnimalHunger { get; set; }
		public int AmountHunger { get; set; }
		public int AnimalChildCount { get; set; }

	}
}
