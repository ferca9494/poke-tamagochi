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
    public partial class Guarderia : Form
    {
        Pet hijo;
        Huevo Hue;
        Image pi;
        private Entrenador ENT;

        public Guarderia(Entrenador e, Image pi)
        {
            ENT = e;
            Hue = null;
            InitializeComponent();
        }

        private void Guarderia_Load(object sender, EventArgs e)
        {

            if (ENT.EmpesoGuarderia)
            { 
                progressBar1l.Value = ENT.TiempoEnGuarderia;
                button1.Text = "Cancelar";
                Slot1.Enabled = false;
                Slot2.Enabled = false;

                timer1.Enabled = true;
                ENT.EmpesoGuarderia = true;

                Poke_slot1.Enabled = false;
                Poke_slot2.Enabled = false;
                Poke_slot3.Enabled = false;
                Poke_slot4.Enabled = false;
                Poke_slot5.Enabled = false;
                Poke_slot6.Enabled = false;
            }
            Refrescar();

        }

        void Refrescar()
        {
            Poke_slot1.Image = null;
            Poke_slot2.Image = null;
            Poke_slot3.Image = null;
            Poke_slot4.Image = null;
            Poke_slot5.Image = null;
            Poke_slot6.Image = null;

            Slot1.Image = null;
            Slot2.Image = null;

            label1.Text = "";
            label2.Text = "";

            if (ENT.Pokemons.getBD()[0]!=null)
                Poke_slot1.Image = ENT.Pokemons.getBD()[0].PK.getminiImage();
            if (ENT.Pokemons.getBD()[1] != null)
                Poke_slot2.Image = ENT.Pokemons.getBD()[1].PK.getminiImage();
            if (ENT.Pokemons.getBD()[2] != null)
                Poke_slot3.Image = ENT.Pokemons.getBD()[2].PK.getminiImage();
            if (ENT.Pokemons.getBD()[3] != null)
                Poke_slot4.Image = ENT.Pokemons.getBD()[3].PK.getminiImage();
            if (ENT.Pokemons.getBD()[4] != null)
                Poke_slot5.Image = ENT.Pokemons.getBD()[4].PK.getminiImage();
            if (ENT.Pokemons.getBD()[5] != null)
                Poke_slot6.Image = ENT.Pokemons.getBD()[5].PK.getminiImage();

            if (ENT.Guarderia.getBD()[0] != null)
            {
                Slot1.Image = ENT.Guarderia.getBD()[0].PK.getminiImage();
                label1.Text = "["+ ENT.Guarderia.getBD()[0].getNivel().ToString() + "] " + ENT.Guarderia.getBD()[0].getNombre();
                button1.Enabled = true;
            }
            else         
                button1.Enabled = false;

            if (ENT.Guarderia.getBD()[1] != null)
            {
                Slot2.Image = ENT.Guarderia.getBD()[1].PK.getminiImage();
                label2.Text = "[" + ENT.Guarderia.getBD()[1].getNivel().ToString() + "] " + ENT.Guarderia.getBD()[1].getNombre();
            }
            
        }

        void RefrescarBarra()
        {

            if (ENT.TiempoEnGuarderia <= progressBar1l.MaximumValue)
                progressBar1l.Value = ENT.TiempoEnGuarderia;
        }


        private void Transferir(int x)
        {

            if (ENT.Pokemons.getBD()[x] != null && !ENT.Pokemons.getBD()[x].dormido)
            {
                if (ENT.Guarderia.getBD()[0] == null)
                {
                    ENT.Guarderia.Agregar(ENT.Pokemons.getBD()[x]);
                    ENT.Pokemons.getBD()[x] = null;
                }
                else
                if (ENT.Guarderia.getBD()[1] == null)
                {
                    ENT.Guarderia.Agregar(ENT.Pokemons.getBD()[x]);
                    ENT.Pokemons.getBD()[x] = null;
                }
            }


            //eliminar la imagen del poke si se ve en el form principal
            /*
            if (this.ENT.Pokemons.getBD()[pk] != null)
            {
                pi = this.ENT.Pokemons.getBD()[pk].PK.getImage();
            }
            else
            {
                pi = null;
            }
            */


            Refrescar();
        }

        private void Poke_slot1_Click(object sender, EventArgs e)
        {
            Transferir(0);
        }

        private void Poke_slot2_Click(object sender, EventArgs e)
        {
            Transferir(1);
        }

        private void Poke_slot3_Click(object sender, EventArgs e)
        {
            Transferir(2);
        }

        private void Poke_slot4_Click(object sender, EventArgs e)
        {
            Transferir(3);
        }

        private void Poke_slot5_Click(object sender, EventArgs e)
        {
            Transferir(4);
        }

        private void Poke_slot6_Click(object sender, EventArgs e)
        {
            Transferir(5);
        }

        Pet CrearHijo(Pet p1,Pet p2)
        {
            Pet aux;
            if (p1.PK.getID()==132)//ditto haciendo de las suyas
                aux = new Pet(p2.PK.getID(),5);
            else
                aux = new Pet(p1.PK.getID(), 5);

            aux.setSaludMAX(p1.getSaludMAX() + p2.getSaludMAX()/2+500);
            aux.setSEX(Convert.ToBoolean(new Random().Next(0, 1)));
            aux.setVario(Convert.ToBoolean(new Random().Next(0, 1)));
            aux.setFue(p1.getFue() + p2.getFue() / 2 + 5);
            aux.setRes(p1.getRes() + p2.getRes() / 2 + 5);
            aux.setAgi(p1.getAgi() + p2.getAgi() / 2 + 5);

            return aux;

        }

        private void Slot2_Click(object sender, EventArgs e)
        {

            ENT.Pokemons.Agregar(ENT.Guarderia.getBD()[1]);
            ENT.Guarderia.getBD()[1] = null;
            Refrescar();
        }

        private void Slot1_Click(object sender, EventArgs e)
        {
            ENT.Pokemons.Agregar(ENT.Guarderia.getBD()[0]);
            ENT.Guarderia.getBD()[0] = null;

            Refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ENT.EmpesoGuarderia == false)
            {
                if (ENT.Guarderia.getBD()[0] != null)
                {


                    button1.Text = "Canselar";
                    Slot1.Enabled = false;
                    Slot2.Enabled = false;

                    timer1.Enabled = true;
                    ENT.EmpesoGuarderia = true;

                    Poke_slot1.Enabled = false;
                    Poke_slot2.Enabled = false;
                    Poke_slot3.Enabled = false;
                    Poke_slot4.Enabled = false;
                    Poke_slot5.Enabled = false;
                    Poke_slot6.Enabled = false;
                }
            }
            else
            {
                    Poke_slot1.Enabled = true;
                    Poke_slot2.Enabled = true;
                    Poke_slot3.Enabled = true;
                    Poke_slot4.Enabled = true;
                    Poke_slot5.Enabled = true;
                    Poke_slot6.Enabled = true;

                    Slot1.Enabled = true;
                    Slot2.Enabled = true;
                    timer1.Enabled = false;
                    button1.Text = "Ingresar";
                    progressBar1l.Value = 0;
                    ENT.EmpesoGuarderia = false;
                    ENT.TiempoEnGuarderia = 0;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Huevo Hue;

            RefrescarBarra();

            if (progressBar1l.Value == progressBar1l.MaximumValue)
            {
                Random r = new Random();
                if (                   
                    //verif si estan en guarderia
                    ENT.Guarderia.getBD()[0] != null && ENT.Guarderia.getBD()[1] != null &&
                    //verif tipos
                    (
                    (ENT.Guarderia.getBD()[0].PK.getID() == ENT.Guarderia.getBD()[1].PK.getID())||
                    ENT.Guarderia.getBD()[0|1].PK.getID() == 132//ditto :)
                    ) &&
                    //verif sexos
                    (                   
                    (ENT.Guarderia.getBD()[0].getSex() && !ENT.Guarderia.getBD()[1].getSex())||
                    (!ENT.Guarderia.getBD()[0].getSex() && ENT.Guarderia.getBD()[1].getSex())
                    )//&&
                    //valor random
                     //new Random().Next(0,3)==0
                )
                {

                    //ya nacio :)
                    hijo = CrearHijo(ENT.Guarderia.getBD()[0], ENT.Guarderia.getBD()[1]);
                    Hue = new Huevo(hijo);
                    pictureBox1.Image = Resources.Huevo;

                }
                

                ENT.Guarderia.getBD()[0].AumExp(r.Next(0, 5501));
                if(ENT.Guarderia.getBD()[1]!=null)
                    ENT.Guarderia.getBD()[1].AumExp(r.Next(0, 5501));

                label1.Text = "[" + ENT.Guarderia.getBD()[0].getNivel().ToString() + "] " + ENT.Guarderia.getBD()[0].getNombre();
                label1.Text = "[" + ENT.Guarderia.getBD()[1].getNivel().ToString() + "] " + ENT.Guarderia.getBD()[1].getNombre();
                Poke_slot1.Enabled = true;
                Poke_slot2.Enabled = true;
                Poke_slot3.Enabled = true;
                Poke_slot4.Enabled = true;
                Poke_slot5.Enabled = true;
                Poke_slot6.Enabled = true;

                Slot1.Enabled = true;
                Slot2.Enabled = true;
                timer1.Enabled = false;
                button1.Text = "Ingresar";
                progressBar1l.Value = 0;
                ENT.TiempoEnGuarderia = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (hijo != null)
            {

                //ENT.AGREGAR_poke(hijo);
                pictureBox1.Image = null;
                ENT.AGREGAR_item(Hue);

                Refrescar();
                button1.Enabled = true;
                ENT.EmpesoGuarderia = false;
                
            }
        }

        private void Guarderia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            //esto es por si queres que devuelva los pokes al cerrar
            if(ENT.Guarderia.getBD()[0] != null  )
            {
                ENT.Pokemons.Agregar(ENT.Guarderia.getBD()[0]);
                ENT.Guarderia.getBD()[0] = null;
            }

            if ( ENT.Guarderia.getBD()[1] != null)
            {
                ENT.Pokemons.Agregar(ENT.Guarderia.getBD()[1]);
                ENT.Guarderia.getBD()[1] = null;
            }
            */
            Close();
        }
    }
}
