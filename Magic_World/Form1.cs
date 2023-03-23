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


			var assembly_types = typeof(Animal).Assembly.GetTypes()
				.Where(type => type.IsSubclassOf(typeof(Animal)) && !type.IsAbstract).Select(x=>new AnimalTypeWrapper { Name = x.Name, Type = x}).ToArray();

            combo_Animal_type.Items.AddRange(assembly_types);
		}

        public class AnimalTypeWrapper
        {
            public string Name { get; set; }
            public Type Type { get; set; }

            public override string ToString() => Name;
		}

		private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void combo_Animal_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Rabit_add_Click(object sender, EventArgs e)
        {
			var animal = (Animal) Activator.CreateInstance(((AnimalTypeWrapper)combo_Animal_type.SelectedItem).Type);

            animal.Name = txtanimal_name.Text;
            animal.Age = int.Parse((txtAnimal_Age.Text.ToString()));
            animal.AmountHunger = int.Parse((txtAnimal_Amount_Hunger.Text));
            animal.AnimalChildCount = int.Parse((txtAnimal_Number_Child.Text));
            animal.AnimalHunger = Convert.ToBoolean(chk_animal_state.CheckState);
            jungle_instance.Animals.Add(animal);

		}

        private void txtAnimal_Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAnimal_Age_Click(object sender, EventArgs e)
        {

        }

        private void btn_show_number_of_all_animals_Click(object sender, EventArgs e)
        {
            lblshow_all_count_animals_2.Text = jungle_instance.Animals.Count.ToString();
        }
    }
}
