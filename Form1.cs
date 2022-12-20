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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace PokePet
{
    public partial class Form1 : Form
    {
        /*
        * Propiedades
        */
        public int pk;
        public Entrenador ENT;

        Pet PokemonSelect;

        Crear CrearPet;
        Mochila Mochila;
        Tienda AbrirTienda;
        Jugar Jugar;
        Estadisticas verEstad;
        PokePC PPC;
        Opciones Opcio;
        Pokedex pd;
        Estado est;
        Guarderia Gua;

        const int WM_SYSCOMMAND = 0x112;
        const int MOUSE_MOVE = 0xF012;

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
     
        private bool caca = false;
        private uint notitime = 0;


        /*
         * Constructores
         */

        public Form1(Entrenador e)
        {
            ENT = e;

            string carpeta = Application.StartupPath + @"\save";
            Directory.CreateDirectory(carpeta);
            
            InitializeComponent();

            saveFileDialog1.InitialDirectory = carpeta;
            openFileDialog1.InitialDirectory = carpeta;

          this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
           
            //this.PokemonIMG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            //this.Boton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            if (PokemonSelect == null)
            {
                CrearPet = new Crear(ENT, this);
                CrearPet.Show();
            }
        }

        public void Inicio()
        {
            PokemonSelect = ENT.Pokemons.getBD()[pk];

            if (PokemonSelect.PK.getTipo().CompareTo("Bulbasaur") == 0)
                this.PokemonIMG.Image = Resources.Bulbasaur;
            if (PokemonSelect.PK.getTipo().CompareTo("Charmander") == 0)
                this.PokemonIMG.Image = Resources.Charmander;
            if (PokemonSelect.PK.getTipo().CompareTo("Squirtle") == 0)
                this.PokemonIMG.Image = Resources.Squirtle;
            if (PokemonSelect.PK.getTipo().CompareTo("Pikachu") == 0)
                this.PokemonIMG.Image = Resources.Pikachu;

            selector(1);
        }

        /*
         * Metodos de arrastre de form
         */
        
        private void moverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }
       
       
        /*
         * Menu
         */

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach( Pet pok in ENT.Pokemons.getBD())           
                if (pok != null)
                    flag = true;

            foreach (Pet pok in ENT.PC.getBD())
                if (pok != null)
                    flag = true;

            if (!flag)
            {
                CrearPet = new Crear(ENT,this);
                CrearPet.Show();
            }
        }

      

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PokemonIMG.Image = null;
            Poke_slot1.Image = null;
            Poke_slot2.Image = null;
            Poke_slot3.Image = null;
            Poke_slot5.Image = null;
            Poke_slot4.Image = null;
            Poke_slot6.Image = null;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
   
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                "Pokegochi v1.2\n\nCreado por Fernando Cañete (Faizen)\n\nContacto: fernando6294@yahoo.com\n\nPagina: https://faizenblog.blogspot.com.ar"
                );
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Ayuda:\n\n-Para restaurar la salud dale comida a tu pokemon y dejalo dormir o dale una pocion.\n\n-Para restaurar el hambre compra comida en la tienda.\n\n-Para restaurar el sueño apaga las luces.\n\n-Para restaurar el entretenimiento mandalo a pelear con otros pokemons.\n\n-Para restaurar la higiene desliza el cursor sobre el pokemon varias veces.\n\n-Para subir de nivel un pokemon mandalo a pelear y cuando llegue a cierto nivel evolucionara , a exepcion de otros que necesitan una piedra.\n\n-Para obtener mas pokemons capturalos con las pokebolas y si no hay espacio se guardaran en tu pc.\n\n-Es posible que te encuentres con los pokemons que allas liberado en la pc.\n\n-Para obtener mas lugares donde capturar pokemons debes comprar pases en la tienda."
                );
        }
        /*
         * Botones
         */

       

        //: ON/OFF Luz
        private void button2_Click(object sender, EventArgs e)
        {

            if (this.PokemonSelect.dormido)///error
            {
                this.PokemonSelect.dormido = false;
            }
            else
            {
                this.PokemonSelect.dormido = true;
            }
        }
        //: Bañar
        private void button3_Click(object sender, EventArgs e)
        {
            if (PokemonSelect!= null && !this.PokemonSelect.dormido)
                PokemonSelect.Bañar(40);           
        }
       

        /*
         * Timers
         */
        private void Evento(int i)
        {
            Random r = new Random();

            Pet Poke = ENT.Pokemons.getBD()[i];

            //LEVELUP!  
            if (Poke.getExp() > 1000)
                Poke.LevelUp();

            if (Poke.getNivel() == poke_bd.Evolucion_lvl[Poke.PK.getID()])
                PokemonIMG.Image = Poke.PK.getImage();

            //dormir o no
            if (!Poke.dormido)
            {
                if (Poke.getSue() > 0)
                {
                    if (!Convert.ToBoolean(r.Next(10)))
                        Poke.Dormir(-1);
                }
            }
            else
            {
                if (Poke.getSue() <= 495)
                    Poke.Dormir(5);
            }
            //aburrirse
            if (Poke.getEnt() >= 0)
            {
                if (!Convert.ToBoolean(r.Next(10)))
                    Poke.Jugar(-1);
            }
            //Digestion
            if (Poke.getHam() > 0)
            {
                if (!Convert.ToBoolean(r.Next(20)))
                    Poke.Alimentar(-1);
            }
            //sanar si comio
            if (Poke.getHam() >= 500 && Poke.getSalud() < Poke.getSaludMAX()-4)
            {
                if (!Convert.ToBoolean(r.Next(20)))
                    Poke.Sanar(10);
            }
            //debilitar sino comio
            if (Poke.getHam() <= 25 && Poke.getSalud() >= 0)
            {
                if (!Convert.ToBoolean(r.Next(10)))
                    Poke.Sanar(-3);
            }
            //dormir si esta aburrido
            if (Poke.getEnt() <= 0)
            {
                if (!Convert.ToBoolean(r.Next(5)))
                    Poke.Dormir(-1);
            }
            //apagar luz si esta durmiendo
            if (Poke.getSue() <= 0)
                Poke.dormido = true;

            //enfermar si no se baña
            if (Poke.getHig() <= 0)
            {
                if (!Convert.ToBoolean(r.Next(10)))
                    Poke.Sanar(-1);
            }
            //ensuciar
            if (Poke.getHig() >= 250 && Poke.getHam() >= 400 && caca == false)
            {
                if (!Convert.ToBoolean(r.Next(100)))
                {
                    Poke.Alimentar(-100);
                    Poke.Bañar(-250);
                    
                    caca = true;
                }
            }
            //curar si duerme
            if (Poke.dormido)
            {
                if (Poke.getSue() <= 497)
                    Poke.Sanar(3);
            }

            //muerte
            if (Poke.getSalud() <= 0)
            {
                //MessageBox.Show("RIP " + Poke.getNombre());
                notificacion(Poke.getNombre() + " esta muerto!", "R.i.p.");
                ENT.Agregar_a_Cementerio(Poke);

                //eliminar la imagen del poke si se ve en el form principal            
                this.PokemonIMG.Image = null;
            
                ENT.Pokemons.getBD()[i] = null;              
            }                   
                    
            //itemusado
            if(Mochila!=null&&Mochila.itemusado)
            {
                PokemonIMG.Image = Poke.PK.getImage();
                Mochila.itemusado = false;
            }
        }


        //Eventos
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (notitime > 0)
                notitime--;

            for(int i=0;i<6;i++)
            {
                if (ENT.Pokemons.getBD()[i] != null)
                {
                    Evento(i);
                    Felicidad();
                }
            }

            Refresh();
             
        }


        //Refrescar
        private void timer2_Tick(object sender, EventArgs e)
        {
            PokemonSelect = ENT.Pokemons.getBD()[pk];



            if (est!=null)
                est.pk = pk;
            if (Mochila != null)
                Mochila.pk = pk;

            if (PokemonSelect != null)
            {
                if (PokemonSelect.dormido)
                    pictureBox3.Image = Resources.icon_lightoff;
                else
                    pictureBox3.Image = Resources.icon_light;


                this.Text = "Pokegochi (" + PokemonSelect.getNombre() + ")";
                this.Nombre.Text = PokemonSelect.getNombre();

                if (ENT.Pokemons.getBD()[0] != null) t.SetToolTip(Poke_slot1, "[" + ENT.Pokemons.getBD()[0].getNivel() + "]" + ENT.Pokemons.getBD()[0].getNombre());
                if (ENT.Pokemons.getBD()[1] != null) t.SetToolTip(Poke_slot2, "[" + ENT.Pokemons.getBD()[1].getNivel() + "]" + ENT.Pokemons.getBD()[1].getNombre());
                if (ENT.Pokemons.getBD()[2] != null) t.SetToolTip(Poke_slot3, "[" + ENT.Pokemons.getBD()[2].getNivel() + "]" + ENT.Pokemons.getBD()[2].getNombre());
                if (ENT.Pokemons.getBD()[3] != null) t.SetToolTip(Poke_slot4, "[" + ENT.Pokemons.getBD()[3].getNivel() + "]" + ENT.Pokemons.getBD()[3].getNombre());
                if (ENT.Pokemons.getBD()[4] != null) t.SetToolTip(Poke_slot5, "[" + ENT.Pokemons.getBD()[4].getNivel() + "]" + ENT.Pokemons.getBD()[4].getNombre());
                if (ENT.Pokemons.getBD()[5] != null) t.SetToolTip(Poke_slot6, "[" + ENT.Pokemons.getBD()[5].getNivel() + "]" + ENT.Pokemons.getBD()[5].getNombre());
            }

            if (Control.ModifierKeys == Keys.NumPad1)         
                selector(1);
            if (Control.ModifierKeys == Keys.NumPad2)
                selector(2);
            if (Control.ModifierKeys == Keys.NumPad3)
                selector(3);
            if (Control.ModifierKeys == Keys.NumPad4)
                selector(4);
            if (Control.ModifierKeys == Keys.NumPad5)
                selector(5);
            if (Control.ModifierKeys == Keys.NumPad6)
                selector(6);

           
            if (Mochila!=null&&PokemonSelect!=null)
            Mochila.setpk(pk);

            Refreshimg();
            
          
        }

        private void notificacion(string titulo, string texto)
        {
            if (Opciones.Notificaciones)
            {
                if (notitime == 0)
                {
                    notifyIcon1.BalloonTipTitle = titulo;
                    notifyIcon1.BalloonTipText = texto;
                    notifyIcon1.ShowBalloonTip(120);
                    notitime = 1000;
                }
            }

        }

        private void selector(short i)
        {
            if (ENT.Pokemons.getBD()[i - 1] != null)
            {
                pk = i - 1;
                PokemonIMG.Image = ENT.Pokemons.getBD()[i - 1].PK.getImage();

                if (i == 1)
                    this.Poke_slot1.BackgroundImage = Resources.img_Poke2;
                else
                    this.Poke_slot1.BackgroundImage = Resources.img_Poke1;

                if (i == 2)
                    this.Poke_slot2.BackgroundImage = Resources.img_Poke2;
                else
                    this.Poke_slot2.BackgroundImage = Resources.img_Poke1;

                if (i == 3)
                    this.Poke_slot3.BackgroundImage = Resources.img_Poke2;
                else
                    this.Poke_slot3.BackgroundImage = Resources.img_Poke1;

                if (i == 4)
                    this.Poke_slot5.BackgroundImage = Resources.img_Poke2;
                else
                    this.Poke_slot5.BackgroundImage = Resources.img_Poke1;

                if (i == 5)
                    this.Poke_slot4.BackgroundImage = Resources.img_Poke2;
                else
                    this.Poke_slot4.BackgroundImage = Resources.img_Poke1;

                if (i == 6)
                    this.Poke_slot6.BackgroundImage = Resources.img_Poke2;
                else
                    this.Poke_slot6.BackgroundImage = Resources.img_Poke1;
            }     
        }

        
        private void Felicidad()
        {
            if (PokemonSelect != null)
            {
                uint max = 2000 + PokemonSelect.getSaludMAX();
                float actual = PokemonSelect.getSalud() + PokemonSelect.getHam() + PokemonSelect.getSue() + PokemonSelect.getEnt() + PokemonSelect.getHig();

                if (!PokemonSelect.dormido)
                {
                    this.z.Text = "";
                    if (actual <= max / 2)
                    {
                        t.SetToolTip(EstadoIMG, "Enfermo");
                        EstadoIMG.Image = Resources.face_enfermo;
                        notificacion(PokemonSelect.getNombre() + " esta enfermo!", PokemonSelect.getNombre() + ": me siento mal :(");
                    }
                    if (actual >= max / 2)
                    {
                        t.SetToolTip(EstadoIMG, "Normal");
                        EstadoIMG.Image = Resources.face_normal;
                    }
                    if (actual > (3 * max) / 4)
                    {
                        t.SetToolTip(EstadoIMG, "Feliz");
                        EstadoIMG.Image = Resources.face_feliz;
                    }

                }
                else
                {
                    this.z.Text = "Zzz";
                    t.SetToolTip(EstadoIMG, "Zzz");
                    EstadoIMG.Image = Resources.face_dormido;
                }

            }
            else
            {
                EstadoIMG.Image = null;
            }
        }
        private void Refresh()
        {
            PokemonSelect = ENT.Pokemons.getBD()[pk];



            if (est != null)
                est.pk = pk;
            if (Mochila != null)
                Mochila.pk = pk;

            if (PokemonSelect != null)
            {
                if (PokemonSelect.dormido)
                    pictureBox3.Image = Resources.icon_lightoff;
                else
                    pictureBox3.Image = Resources.icon_light;


                this.Text = "Pokegochi (" + PokemonSelect.getNombre() + ")";
                this.Nombre.Text = PokemonSelect.getNombre();

                if (ENT.Pokemons.getBD()[0] != null) t.SetToolTip(Poke_slot1, "[" + ENT.Pokemons.getBD()[0].getNivel() + "]" + ENT.Pokemons.getBD()[0].getNombre());
                if (ENT.Pokemons.getBD()[1] != null) t.SetToolTip(Poke_slot2, "[" + ENT.Pokemons.getBD()[1].getNivel() + "]" + ENT.Pokemons.getBD()[1].getNombre());
                if (ENT.Pokemons.getBD()[2] != null) t.SetToolTip(Poke_slot3, "[" + ENT.Pokemons.getBD()[2].getNivel() + "]" + ENT.Pokemons.getBD()[2].getNombre());
                if (ENT.Pokemons.getBD()[3] != null) t.SetToolTip(Poke_slot4, "[" + ENT.Pokemons.getBD()[3].getNivel() + "]" + ENT.Pokemons.getBD()[3].getNombre());
                if (ENT.Pokemons.getBD()[4] != null) t.SetToolTip(Poke_slot5, "[" + ENT.Pokemons.getBD()[4].getNivel() + "]" + ENT.Pokemons.getBD()[4].getNombre());
                if (ENT.Pokemons.getBD()[5] != null) t.SetToolTip(Poke_slot6, "[" + ENT.Pokemons.getBD()[5].getNivel() + "]" + ENT.Pokemons.getBD()[5].getNombre());
            }

            if (Control.ModifierKeys == Keys.NumPad1)
                selector(1);
            if (Control.ModifierKeys == Keys.NumPad2)
                selector(2);
            if (Control.ModifierKeys == Keys.NumPad3)
                selector(3);
            if (Control.ModifierKeys == Keys.NumPad4)
                selector(4);
            if (Control.ModifierKeys == Keys.NumPad5)
                selector(5);
            if (Control.ModifierKeys == Keys.NumPad6)
                selector(6);


            if (Mochila != null && PokemonSelect != null)
                Mochila.setpk(pk);

            Refreshimg();

        }
        private void Refreshimg()
        {
            

            if (this.ENT.Pokemons.getBD()[0] != null)
            {
                this.Poke_slot1.Image = this.ENT.Pokemons.getBD()[0].PK.getminiImage();
                if (!this.ENT.Pokemons.getBD()[0].dormido || this.ENT.Pokemons.getBD()[0] == null) this.z1.Text = ""; else this.z1.Text = "Zzz";
            }
            else
                this.Poke_slot1.Image = null;

            if (this.ENT.Pokemons.getBD()[1] != null)
            {
                this.Poke_slot2.Image = this.ENT.Pokemons.getBD()[1].PK.getminiImage();
                if (!this.ENT.Pokemons.getBD()[1].dormido || this.ENT.Pokemons.getBD()[1] == null) this.z2.Text = ""; else this.z2.Text = "Zzz";
            }
            else
                this.Poke_slot2.Image = null;
            if (this.ENT.Pokemons.getBD()[2] != null)
            {
                this.Poke_slot3.Image = this.ENT.Pokemons.getBD()[2].PK.getminiImage();
                if (!this.ENT.Pokemons.getBD()[2].dormido || this.ENT.Pokemons.getBD()[2] == null) this.z3.Text = ""; else this.z3.Text = "Zzz";
            }
            else
                this.Poke_slot3.Image = null;
            if (this.ENT.Pokemons.getBD()[3] != null)
            {
                this.Poke_slot5.Image = this.ENT.Pokemons.getBD()[3].PK.getminiImage();
                if (!this.ENT.Pokemons.getBD()[3].dormido || this.ENT.Pokemons.getBD()[3] == null) this.z4.Text = ""; else this.z4.Text = "Zzz";
            }
            else
                this.Poke_slot5.Image = null;
            if (this.ENT.Pokemons.getBD()[4] != null)
            {
                this.Poke_slot4.Image = this.ENT.Pokemons.getBD()[4].PK.getminiImage();
                if (!this.ENT.Pokemons.getBD()[4].dormido || this.ENT.Pokemons.getBD()[4] == null) this.z5.Text = ""; else this.z5.Text = "Zzz";
            }
            else
                this.Poke_slot4.Image = null;
            if (this.ENT.Pokemons.getBD()[5] != null)
            {
                this.Poke_slot6.Image = this.ENT.Pokemons.getBD()[5].PK.getminiImage();
                if (!this.ENT.Pokemons.getBD()[5].dormido || this.ENT.Pokemons.getBD()[4] == null) this.z6.Text = ""; else this.z6.Text = "Zzz";
            }
            else
                this.Poke_slot6.Image = null;


        }


        
        private void PokemonIMG_Click(object sender, EventArgs e)
        {
            if (PokemonSelect != null && !this.PokemonSelect.dormido)
            {
                PokemonIMG.Image = PokemonSelect.PK.getImage();
                PokemonSelect.Jugar(10);
            }
        }

        private void PokemonIMG_MouseMove(object sender, MouseEventArgs e)
        {
            if (PokemonSelect != null && !this.PokemonSelect.dormido)
                PokemonSelect.Bañar(1);
        }

        private void Poke_slot1_Click(object sender, EventArgs e)
        {
            selector(1);
        }
        private void Poke_slot2_Click(object sender, EventArgs e)
        {       
            selector(2);
        }

        private void Poke_slot3_Click(object sender, EventArgs e)
        {
            selector(3);
        }

        private void Poke_slot4_Click(object sender, EventArgs e)
        {
            selector(4);
        }

        private void Poke_slot5_Click(object sender, EventArgs e)
        {
            selector(5);
        }

        private void Poke_slot6_Click(object sender, EventArgs e)
        {
            selector(6);
        }

      
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (PokemonSelect != null)
            {
                if (est == null)
                {
                    est = new Estado(ENT,PokemonIMG.Image);
                    est.pk = pk;
                    est.Show();
                }
                else
                {
                    if (est.Visible)
                        est.Visible = false;
                    else
                        est.Visible = true;//error
                }
            }       


        }
        
        private void EstadoIMG_Click(object sender, EventArgs e)
        {
            if (PokemonSelect!=null)
            {
                pd = new Pokedex(PokemonSelect);
                pd.Show();
            }
        }

    
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(saveFileDialog1.FileName,
                                         FileMode.Create,
                                         FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, ENT);
                stream.Close();
            }
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(openFileDialog1.FileName,
                                          FileMode.Open,
                                          FileAccess.Read,
                                          FileShare.Read);
                ENT = (Entrenador)formatter.Deserialize(stream);
                stream.Close();

                if (PPC != null)
                    PPC.Close();
                if (Mochila != null)
                    Mochila.Close();
                if (Opcio != null)
                    Opcio.Close();
                if (verEstad != null)
                    verEstad.Close();
                if (pd != null)
                    pd.Close();
  

                if (PokemonSelect != null)
                    PokemonIMG.Image = PokemonSelect.PK.getImage();
            }
        }

      

        private bool oculto;

        private void min_Click(object sender, EventArgs e)
        {
            if (!oculto)
            {
                this.BackgroundImage = null;
                this.TopMost = true;
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
             
                Poke_slot1.Visible = false;
                Poke_slot2.Visible = false;
                Poke_slot3.Visible = false;
                Poke_slot4.Visible = false;
                Poke_slot5.Visible = false;
                Poke_slot6.Visible = false;
            
                button2.Visible = false;

                oculto = true;
            }
            else
            {
                this.BackgroundImage =Resources.fondo;
                this.TopMost = false;
                linkLabel1.Visible = true;
                linkLabel2.Visible = true;
        
                Poke_slot1.Visible = true;
                Poke_slot2.Visible = true;
                Poke_slot3.Visible = true;
                Poke_slot4.Visible = true;
                Poke_slot5.Visible = true;
                Poke_slot6.Visible = true;
     
                button2.Visible = true;

                oculto = false;
            }
        }

        private void onepersec_Tick(object sender, EventArgs e)
        {
            //aca solo van variables de tiempo

            


            if (ENT.EmpesoGuarderia)
            {
                if (ENT.TiempoEnGuarderia < 60)
                    ENT.TiempoEnGuarderia += 1;
            }

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pet pika = new Pet(132, 50);
            pika.setSEX(false);

            ENT.AGREGAR_poke(pika);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ENT.AGREGAR_item(new Huevo(new Pet(25)));
            Console.Write("huevitolink");
        }

        private void PokemonIMG_Click_1(object sender, EventArgs e)
        {

        }
    }
}