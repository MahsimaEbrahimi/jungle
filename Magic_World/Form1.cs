using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Magic_World
{

    public partial class main_jungle : Form
    {
       private jungle jungle_instance = new jungle();

        public main_jungle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void combo_Animal_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Rabit_add_Click(object sender, EventArgs e)
        {
         string txt_Animal_type_get = combo_Animal_type.Text.ToString();
        if (txt_Animal_type_get== "rabit")
         {
         Rabit Rabit_instance = new Rabit(combo_Animal_type.Text, txtanimal_name.Text.ToString(), int.Parse((txtAnimal_Age.Text.ToString())), int.Parse((txtAnimal_Amount_Hunger.Text)), int.Parse((txtAnimal_Number_Child.Text)), Convert.ToBoolean(chk_animal_state.CheckState));
         jungle_instance.animal_add(Rabit_instance);
         }
         if (txt_Animal_type_get == "snake")
         {
                snake Rabit_instance = new snake(combo_Animal_type.Text, txtanimal_name.Text.ToString(), int.Parse((txtAnimal_Age.Text.ToString())), int.Parse((txtAnimal_Amount_Hunger.Text)), int.Parse((txtAnimal_Number_Child.Text)), Convert.ToBoolean(chk_animal_state.CheckState));
                jungle_instance.animal_add(Rabit_instance);
            }

        }

        private void txtAnimal_Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAnimal_Age_Click(object sender, EventArgs e)
        {

        }

        private void btn_show_number_of_all_animals_Click(object sender, EventArgs e)
        {
            lblshow_all_count_animals_2.Text = jungle_instance.animal_all_count().ToString();
        }
    }
}
