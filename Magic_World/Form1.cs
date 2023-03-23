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
         Rabit Rabit_instance = new Rabit(combo_Animal_type.Text, txtanimal_name.Text.ToString(), int.Parse((txtAnimal_Age.Text.ToString())), int.Parse((txtAnimal_Amount_Hunger.Text)), int.Parse((txtAnimal_Number_Child.Text)), Convert.ToBoolean(chk_animal_state.CheckState));
         Rabit_instance.Rabit_add(Rabit_instance);
         
        }

        private void txtAnimal_Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAnimal_Age_Click(object sender, EventArgs e)
        {

        }
    }
}
