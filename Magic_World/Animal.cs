using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_World
{
     abstract class Animal
    {
        private string Animal_type;
        private string Animal_Name;
        private int Animal_Age;
        private int Animal_Amount_Hunger;
        private int Animal_Number_Child;
        private bool Animal_Hunger;

        public string getAnimal_type()
        {
            return Animal_type;
        }
        public void setAnimal_type(string animal_type)
        {
            Animal_type = animal_type;
        }

        public string getName()
        {
            return Animal_Name;
        }
        public void setName(string name)
        {
            Animal_Name = name;
        }

        public int getage()
        {
            return Animal_Age;
        }
        public void setAge(int animal_age)
        {
            Animal_Age = animal_age;
        }

        public int get_Amount_Hunger()
        {
            return Animal_Amount_Hunger;
        }
        public void setAmount_Hunger(int amount_hunger)
        {
            Animal_Amount_Hunger = amount_hunger;
        }

        public int getNumber_Child()
        {
            return Animal_Number_Child;
        }
        public void setNumber_Child(int number_child)
        {
            Animal_Number_Child = number_child;
        }

        public bool getAnimal_hunger()
        {
            return Animal_Hunger;
        }
        public void setAnimal_hunger(bool animal_hunger)//when true, the animal gets hungry
        {
            Animal_Hunger = animal_hunger;
        }
    }
}
