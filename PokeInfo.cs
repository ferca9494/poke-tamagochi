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
    public partial class Pokedex : Form
    {

        Pet pk;

        public Pokedex(Pet p)
        {
            pk = p;
            if(pk!=null)
                InitializeComponent();
        }

        private void PokeInfo_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void refrescar()
        {
            poke_img.Image = pk.PK.getImage();
            poke_name.Text = pk.getNombre();
            textBox1.Text = pk.getNombre();
            poke_type1.Text = pk.PK.getTipo1();
            poke_type2.Text = pk.PK.getTipo2();
            if (pk.getSex()) poke_sx.Text = "Macho"; else poke_sx.Text = "Hembra";
            poke_fue.Text = pk.getFue().ToString();
            poke_agi.Text = pk.getAgi().ToString();
            poke_res.Text = pk.getRes().ToString();
            Vita.Text = (pk.getSaludMAX()/100).ToString();
            Feliz.Text = string.Format("{0:.00}", calcularFelicidad()) + "%";
            felibar.Value = (int)calcularFelicidad();

            nivel.Text = pk.getNivel().ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pk.setNombre(textBox1.Text);
            poke_name.Text = pk.getNombre();
            textBox1.Visible = false;
            button1.Visible = false;
        }

        private float calcularFelicidad()
        {

            float actual = pk.getHam() + pk.getSue() + pk.getHig() + pk.getEnt() + pk.getSalud();
            uint max = 2000 + pk.getSaludMAX();
            
            return (actual/max)*100;
        }

        private void poke_img_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refrescar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                button2.ForeColor = Color.DarkGreen;
                timer1.Enabled = false;
            }
            else
            {
                button2.ForeColor = Color.Lime;
                timer1.Enabled = true;
            }

            
        }
    }
}
