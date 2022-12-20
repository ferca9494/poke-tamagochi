using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokePet
{
    public partial class Estado : Form
    {
        Entrenador ENT;
        public int pk;


        Image pi;


        public Estado(Entrenador e, Image pi)
        {
            ENT = e;
      
        
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Estados(pk);

            if (ENT.Pokemons.getBD()[pk] != null)
            {
                this.Barra_salud.MaximumValue = (int)ENT.Pokemons.getBD()[pk].getSaludMAX();
                if ((int)ENT.Pokemons.getBD()[pk].getSalud() > 0)
                {
                    if (ENT.Pokemons.getBD()[pk].getSalud() > ENT.Pokemons.getBD()[pk].getSaludMAX())
                        this.Barra_salud.Value = (int)ENT.Pokemons.getBD()[pk].getSaludMAX();
                    else
                        this.Barra_salud.Value = (int)ENT.Pokemons.getBD()[pk].getSalud();
                }
                else
                    this.Barra_salud.Value = 0;

                this.Nivel.Text = Convert.ToString(ENT.Pokemons.getBD()[pk].getNivel());
                this.Barra_exp.Value = (int)ENT.Pokemons.getBD()[pk].getExp();

                if ((int)ENT.Pokemons.getBD()[pk].getHam() <= 0)
                    this.Barra_hambre.Value = 0;
                else
                    this.Barra_hambre.Value = (int)ENT.Pokemons.getBD()[pk].getHam();

                if ((int)ENT.Pokemons.getBD()[pk].getSue() <= 0)
                    this.Barra_sueño.Value = 0;
                else
                    this.Barra_sueño.Value = (int)ENT.Pokemons.getBD()[pk].getSue();

                if ((int)ENT.Pokemons.getBD()[pk].getHig() <= 0)
                    this.Barra_higiene.Value = 0;
                else
                    this.Barra_higiene.Value = (int)ENT.Pokemons.getBD()[pk].getHig();

                if ((int)ENT.Pokemons.getBD()[pk].getEnt() <= 0)
                    this.Barra_entret.Value = 0;
                else
                    this.Barra_entret.Value = (int)ENT.Pokemons.getBD()[pk].getEnt();

              
                toolTip1.SetToolTip(Barra_salud, ENT.Pokemons.getBD()[pk].getSalud() + "/" + ENT.Pokemons.getBD()[pk].getSaludMAX());
                toolTip1.SetToolTip(Barra_exp, ENT.Pokemons.getBD()[pk].getExp() + "/1000");
                toolTip1.SetToolTip(Barra_hambre, ENT.Pokemons.getBD()[pk].getHam() + "/500");
                toolTip1.SetToolTip(Barra_sueño, ENT.Pokemons.getBD()[pk].getSue() + "/500");
                toolTip1.SetToolTip(Barra_higiene, ENT.Pokemons.getBD()[pk].getHig() + "/500");
                toolTip1.SetToolTip(Barra_entret, ENT.Pokemons.getBD()[pk].getEnt() + "/500");
            }

            
        }

        private void Estados(int i)
        {
            //estados
            string genero;

            if (ENT.Pokemons.getBD()[pk] != null)
            {
                if (ENT.Pokemons.getBD()[pk].getSex() == true)
                    genero = "o";
                else
                    genero = "a";

                if (ENT.Pokemons.getBD()[i].getSalud() > 500 && ENT.Pokemons.getBD()[i].getSalud() <= 1000)
                    Estado_salud.Text = "Saludable";

                if (ENT.Pokemons.getBD()[i].getSalud() > 250 && ENT.Pokemons.getBD()[i].getSalud() <= 500)
                    Estado_salud.Text = "Malestar";

                if (ENT.Pokemons.getBD()[i].getSalud() > 0 && ENT.Pokemons.getBD()[i].getSalud() <= 250)           
                    Estado_salud.Text = "Debil";
                  


                if (ENT.Pokemons.getBD()[i].getHam() > 450)
                    Estado_hambre.Text = "Llen" + genero;

                if (ENT.Pokemons.getBD()[i].getHam() > 250 && ENT.Pokemons.getBD()[i].getHam() <= 450)
                    Estado_hambre.Text = "Satisfech" + genero;

                if (ENT.Pokemons.getBD()[i].getHam() > 125 && ENT.Pokemons.getBD()[i].getHam() <= 250)
                    Estado_hambre.Text = "Hambre";

                if (ENT.Pokemons.getBD()[i].getHam() > 0 && ENT.Pokemons.getBD()[i].getHam() <= 125)
                {            
                    Estado_hambre.Text = "Flaqueza";
                }

                if (ENT.Pokemons.getBD()[i].getSue() > 250 && ENT.Pokemons.getBD()[i].getSue() <= 500)
                    Estado_sueño.Text = "Descansad" + genero;

                if (ENT.Pokemons.getBD()[i].getSue() > 125 && ENT.Pokemons.getBD()[i].getSue() <= 250)
                {
                   
                    Estado_sueño.Text = "Cansad" + genero;
                }

                if ((ENT.Pokemons.getBD()[i].getSue() > 0 && ENT.Pokemons.getBD()[i].getSue() <= 125) || this.ENT.Pokemons.getBD()[i].dormido)
                    Estado_sueño.Text = "Dormid" + genero;

                if (ENT.Pokemons.getBD()[i].getHig() > 250 && ENT.Pokemons.getBD()[i].getHig() <= 500)
                    Estado_higiene.Text = "Mojad" + genero;

                if (ENT.Pokemons.getBD()[i].getHig() > 125 && ENT.Pokemons.getBD()[i].getHig() <= 250)
                    Estado_higiene.Text = "Limpi" + genero;

                if (ENT.Pokemons.getBD()[i].getHig() > 0 && ENT.Pokemons.getBD()[i].getHig() <= 125)
                {                 
                    Estado_higiene.Text = "Mugros" + genero;
                }

                if (ENT.Pokemons.getBD()[i].getEnt() > 250 && ENT.Pokemons.getBD()[i].getEnt() <= 500)
                    Estado_entret.Text = "Entretenid" + genero;

                if (ENT.Pokemons.getBD()[i].getEnt() > 125 && ENT.Pokemons.getBD()[i].getEnt() <= 250)
                    Estado_entret.Text = "Normal";

                if (ENT.Pokemons.getBD()[i].getEnt() > 0 && ENT.Pokemons.getBD()[i].getEnt() <= 125)
                {                
                    Estado_entret.Text = "Aburrid" + genero;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //mochila
            new Mochila(ENT).Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //batalla
            if (ENT.Pokemons.getBD()[pk].getSalud() >= ENT.Pokemons.getBD()[pk].getSaludMAX() / 4)
            {
                new Jugar(ENT, pk).Show();
            }
            else
            {
                MessageBox.Show("Tu pokemon esta debil no puede pelear");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //pc
            new PokePC(ENT).Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //estadisticas
            new Estadisticas(ENT).Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //guarderia
            new Guarderia(ENT,pi).Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //tienda
            new Tienda(ENT).Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //opciones
            new Opciones().Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //abrir
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //guardar
        }
    }
}
