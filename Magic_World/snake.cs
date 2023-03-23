using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_World
{
    class snake:Animal
    {
        private int length;
        public int getLength()
        {
            return length;
        }
        public void set_Snake_length(int snake_length)
        {
            length = snake_length;
        }
        public snake(string snake_type, string snake_name, int snake_age, int snake_amount_hunger, int snake_number_child, bool snake_hunger)
        {
            this.setAnimal_type(snake_type);
            this.setName(snake_name);
            this.setAge(snake_age);
            this.setAmount_Hunger(snake_amount_hunger);
            this.setNumber_Child(snake_number_child);
            this.setAnimal_hunger(snake_hunger);
        }

    }
}
