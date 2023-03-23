using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_World
{
    class Rabit:Animal
    {

        private int Rabit_jump_rate;//how far can a rabit jump
        public int getRabit_jump_rate()
        {
            return Rabit_jump_rate;
        }
        public void setRabit_jump_rate(int rabit_jump_rate)
        {
            Rabit_jump_rate = rabit_jump_rate;
        }


        public Rabit(string Rabit_type,string Rabit_name,int Rabit_age,int Rabit_amount_hunger,int Rabit_number_child,bool Rabit_hunger)
        {
            //   this.setRabit_jump_rate(Rabit_jump_rate);
            this.setAnimal_type(Rabit_type);
            this.setName(Rabit_name);
            this.setAge(Rabit_age);
            this.setAmount_Hunger(Rabit_amount_hunger);
            this.setNumber_Child(Rabit_number_child);
            this.setAnimal_hunger(Rabit_hunger);
           // this.setRabit_jump_rate(Rabit_jump_rate);
        }
    }

}
