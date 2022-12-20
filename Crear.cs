using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokePet.Properties;

namespace PokePet
{
    public partial class Crear : Form
    {
        private uint opcionelegida = 25;
        private Pet POKE;
        private Entrenador ent;
        private Form1 form;
        public Crear(Entrenador e,Form1 f)
        {
            ent = e;
            form = f;

            InitializeComponent();
        }
        /*
        private int ID1 = 1;
        private int ID1 = 4;
        private int ID1 = 7;
        */
  
        private void selector(short i)
        {
            if (i == 1)
                this.Poke1.BackgroundImage = Resources.img_Poke2;
            else
                this.Poke1.BackgroundImage = Resources.img_Poke1;

            if (i == 2)
                this.Poke2.BackgroundImage = Resources.img_Poke2;
            else
                this.Poke2.BackgroundImage = Resources.img_Poke1;

            if (i == 3)
                this.Poke3.BackgroundImage = Resources.img_Poke2;
            else
                this.Poke3.BackgroundImage = Resources.img_Poke1;

            if (i == 4)
                this.Poke4.BackgroundImage = Resources.img_Poke2;
            else
                this.Poke4.BackgroundImage = Resources.img_Poke1;
        }

        //empezar
        private void button1_Click(object sender, EventArgs e)
        {
           
            bool sex = false;
           
            if (radioButton1.Checked)
                sex = true;
            if (radioButton.Checked)
                sex = false;
        

            if (this.textBox1.Text.CompareTo("") != 0)
            {
                POKE = new Pet(this.opcionelegida);
                POKE.setNombre(this.textBox1.Text);
                POKE.setSEX(sex);

                ent.Pokemons.getBD()[0] = POKE;

                form.Inicio();

                // if (checkBox1.Checked)
                // Settings.Nuzlocke = true;
                form.Show();
                

                this.Close();
            }
            else
            {
                MessageBox.Show("Ingresa un Nombre");
            }
            
        }

        private void opcion1_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = "Bulbasaur";
            this.selector(1);
            this.opcionelegida = 1;
        }

        private void opcion2_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = "Charmander";
            this.selector(2);
            this.opcionelegida = 4;
        }

        private void opcion3_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = "Squirtle";
            this.selector(3);
            this.opcionelegida = 7;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "Pikachu";
            this.selector(4);
            this.opcionelegida = 25;
        }
    }
}
