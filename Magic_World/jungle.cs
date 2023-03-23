using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Magic_World
{
    class jungle
    {
        public ArrayList Animal_list= new ArrayList();
        public void animal_add(Animal animal_instance)
        {
            Animal_list.Add(animal_instance);
        }

        public int animal_all_count()
        {
            return Animal_list.Count;
        }


    }
}
