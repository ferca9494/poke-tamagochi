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
    public partial class Jugar : Form
    {
        //aliado
        public int pk;
        private Entrenador ENT;

        //enemigo
        private Random RANDOMENEMY;
        private uint ENEMYID;
        private Pet ENEMY;
        private short ENEMYLVL = 2;

        //contador de victorias
        private int vic = 0;

        //bools
        private bool ally = false;
        bool Pauseado = false;

        //cooldown
        private uint cd_skill1 = 0;
        private uint cd_skill2 = 0;

        //Pokebola
        Item PB;
        Pokedex pi;

        string[] lugares = { "Bosque","Cueva","Playa",
            "Oceano","Volcan","Montaña",
            "Pantano","Central Electrica", "Cementerio",
            "Randomville" };

        public Jugar(Entrenador e,int p)
        {
            ENT = e;
            pk = p;
            InitializeComponent();

            if (ENT.Pokemons.getBD()[pk] != null)
            {

                //inicio
                

                comboBox1.SelectedIndex = 0;
                if(ENT.Pases < lugares.Length)
                    for(int i=0;i< ENT.Pases; i++)                   
                        comboBox1.Items.Add(lugares[i]);                  
                else
                    for (int i = 0; i < lugares.Length; i++)                   
                        comboBox1.Items.Add(lugares[i]);

                //correr tiempo
                Pokeball_timer.Enabled = true;
                Refrescar.Enabled = true;            

                //preparar enemigo
                this.NuevaBatalla();
            }

        }

       
        //pokeball
        private void timer1_Tick(object sender, EventArgs e)
        {

            PB = ENT.BUSCAR_item_en_mochila(24);

            if(PB == null)
                PB = ENT.BUSCAR_item_en_mochila(5);

            if (PB != null)
                poke_cant.BackgroundImage = PB.getImagen();

            //refrescar cantidad de pokebolas
            if ( PB != null)          
                pokeball_cant.Text = "x" + PB.getCantidad();
            else
                pokeball_cant.Text = "x0";

            //pokeball activar / desactivar
            if (PB != null)
            {
                if (PB.getID()==5)
                {
                    if (PB.getCantidad() > 0)
                    {
                        if (this.ENEMY.getSalud() < this.ENEMY.getSaludMAX()/4)
                        {
                            poke_cant.Enabled = true;
                            poke_cant.BackColor = Color.White;
                        }
                        else
                        {
                            poke_cant.Enabled = false;
                            poke_cant.BackColor = Color.Silver;
                        }
                    }
                }
                else
                {
                    if (PB.getCantidad() > 0)
                    {
                        poke_cant.Enabled = true;
                        poke_cant.BackColor = Color.White;
                    }
                }
            }
        }

        //mostrar
        private void timer2_Tick(object sender, EventArgs e)
        {

            
            //cd
            if (cd_skill1 == 0)
            {    
                skill1.Enabled = true;
                cd1.Visible = false;
            }
            else
                cd_skill1--;

            if (cd_skill2 == 0)
            {
                skill2.Enabled = true;
                cd2.Visible = false;
            }         
            else
                cd_skill2--;

            cd1.Text = cd_skill1.ToString();
            cd2.Text = cd_skill2.ToString();

            //refrescar fondo de color de imagenes de pokes
            Enemy_Image.BackColor = Color.White;
            Ally_Image.BackColor = Color.White;

            //racha
            this.racha.Text = Convert.ToString(this.vic);

            //dinero
            this.pc.Text = ENT.getDinero().ToString();


            if (ENT.Pokemons.getBD()[pk] != null)
            {
                //refrescar pokemon
                Ally_HP.Maximum = (int)ENT.Pokemons.getBD()[pk].getSaludMAX();
                if (ENT.Pokemons.getBD()[pk].getSalud() > 0)
                {
                    if (ENT.Pokemons.getBD()[pk].getSalud() > ENT.Pokemons.getBD()[pk].getSaludMAX())
                        Ally_HP.Value = (int)ENT.Pokemons.getBD()[pk].getSaludMAX();
                    else
                        Ally_HP.Value = (int)ENT.Pokemons.getBD()[pk].getSalud();
                }
                else
                    Ally_HP.Value = 0;


                Ally_Name.Text = ENT.Pokemons.getBD()[pk].getNombre() + "  nvl " + ENT.Pokemons.getBD()[pk].getNivel().ToString(); ;
                skill1.BackgroundImage = DefinirPoder(true, ENT.Pokemons.getBD()[pk]);
                if (DefinirPoder(false, ENT.Pokemons.getBD()[pk]) != null)
                    skill2.BackgroundImage = DefinirPoder(false, ENT.Pokemons.getBD()[pk]);
                else
                    skill2.Visible = false;

                if (!ally)
                {
                    this.Ally_Image.Image = ENT.Pokemons.getBD()[pk].PK.getImage();
                    ally = true;
                }

                //derrota
                if (ENT.Pokemons.getBD()[pk].getSalud() < ENT.Pokemons.getBD()[pk].getSaludMAX() / 4)
                {
                    bool flag = false;
                    for(int i = 0;i<6;i++)
                    {
                        if(ENT.Pokemons.getBD()[i]!=null && !ENT.Pokemons.getBD()[i].dormido && ENT.Pokemons.getBD()[i].getSalud() > ENT.Pokemons.getBD()[i].getSaludMAX() / 4)
                        {
                            pk = i;
                            ally = false;
                            flag = true;
                        }
                        
                    }
                    if (!flag)
                    {
                        Pokeball_timer.Enabled = false;
                        Refrescar.Enabled = false;
                        golpe_enemigo.Enabled = false;
                        ENT.Derrotas++;
                        MessageBox.Show("*DERROTA*\nTu pokemon está a punto de morir\n curalo con alguna pocion");
                        Close();
                    }
                }
                else
                {
                    Pokeball_timer.Enabled = true;
                    Refrescar.Enabled = true;
                    golpe_enemigo.Enabled = true;
                }

                //refrescar enemigo
                Random Rdinero = new Random();
                if ((int)this.ENEMY.getSalud() <= 0)//muerte del enemigo
                {
                   
                        ENT.darDinero(100 + (vic*2) + this.ENEMY.getNivel() * 20 + Rdinero.Next(10));

                        if(ENT.Pokemons.getBD()[pk]!=null)
                            ENT.Pokemons.getBD()[pk].AumExp(100 + Rdinero.Next(150));
                    

                    vic++;
                    ENT.Victorias++;

                    this.NuevaBatalla();
                }
                else
                {
                    Enemy_HP.Value = (int)this.ENEMY.getSalud();
                }

            }else
                MessageBox.Show("Tu pokemon esta muerto");

        }

        // boton pokebola
        private void button10_Click(object sender, EventArgs e)
        {
            if (PB != null)
                if (PB.getCantidad() > 0)
                {
                    PB.USAR(ENT, pk);
                    ENT.Capturar_poke(this.ENEMY);
                    this.NuevaBatalla();
                    if (PB.getCantidad() == 0)
                    {
                        poke_cant.BackColor = Color.Silver;
                    }
                }
        }

        private void CalcularGolpe(Pet Emisor,Pet Receptor,short tipo)
        {
            float hit;
            int fue_amiga = (int)Emisor.getFue() - (500 - (int)Emisor.getHam());
            int res_enemiga = (int)Receptor.getRes() - (500 - (int)Receptor.getSue());

            switch(tipo)
            {
                case 1:
                    if (ENT.Pokemons.getBD()[pk].PK.getTipo2() == "")
                        if (fue_amiga > res_enemiga)
                            hit = GOLPE(200+fue_amiga - res_enemiga, Emisor.PK.getTipo1(), Receptor.PK.getTipo1());
                        else
                            hit = GOLPE(200, Emisor.PK.getTipo1(), Receptor.PK.getTipo1());
                    else
                        if (fue_amiga > res_enemiga)
                            hit = GOLPE(100+fue_amiga - res_enemiga, Emisor.PK.getTipo1(), Receptor.PK.getTipo1());
                        else
                            hit = GOLPE(100, Emisor.PK.getTipo1(), Receptor.PK.getTipo1());
                    break;
                case 2:
                    if (fue_amiga > res_enemiga)
                        hit = GOLPE(100+fue_amiga - res_enemiga, Emisor.PK.getTipo2(), Receptor.PK.getTipo1());
                    else
                        hit = GOLPE(100, Emisor.PK.getTipo2(), Receptor.PK.getTipo1());
                    break;
                default:
                    if (fue_amiga > res_enemiga)
                        hit = GOLPE(fue_amiga - res_enemiga, "Normal", Receptor.PK.getTipo1());
                    else
                        hit = GOLPE(0, "Normal", Receptor.PK.getTipo1());
                    break;
            }
            Receptor.Sanar(-hit);
            Emisor.Jugar(10);
            Emisor.Dormir(-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            CalcularGolpe(ENT.Pokemons.getBD()[pk], ENEMY, 0);
            Enemy_Image.BackColor = Color.Red;
        }

        private void skill1_Click(object sender, EventArgs e)
        {
            skill1.Enabled = false;
            cd1.Visible = true;
            if (ENT.Pokemons.getBD()[pk].getAgi() < 120)
                cd_skill1 = 120 - ENT.Pokemons.getBD()[pk].getAgi();
            else
                cd_skill1 = 0;

            CalcularGolpe(ENT.Pokemons.getBD()[pk], ENEMY, 1);
            Enemy_Image.BackColor = Color.Blue;
        }

        private void skill2_Click(object sender, EventArgs e)
        {
            if (ENT.Pokemons.getBD()[pk].PK.getTipo2() != "")
            {
                skill2.Enabled = false;
                cd2.Visible = true;
                if (ENT.Pokemons.getBD()[pk].getAgi() < 120)
                    cd_skill2 = 120 - ENT.Pokemons.getBD()[pk].getAgi();
                else
                    cd_skill2 = 0;

                CalcularGolpe(ENT.Pokemons.getBD()[pk], ENEMY, 2);
                Enemy_Image.BackColor = Color.Blue;
            }
        }

        //golpe de enemigo
        private void timer3_Tick(object sender, EventArgs e)
        {
            //golpes de enemigo
            int golperandom = new Random().Next(10);

            if (golperandom > 0 && golperandom <= 4)
            {
                CalcularGolpe(ENEMY, ENT.Pokemons.getBD()[pk], 0);
                Ally_Image.BackColor = Color.Red;
            }
            /*
            if (golperandom == 0  )
            {             
                CalcularGolpe( ENEMY, ENT.Pokemons.getBD()[pk], 1);
                Ally_Image.BackColor = Color.Blue;
            }*/
          
        }
        private void atajos_teclado_Tick(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Space)
            {
                CalcularGolpe(ENT.Pokemons.getBD()[pk], ENEMY, 0);
                Enemy_Image.BackColor = Color.Red;
            }
            if (Control.ModifierKeys == Keys.NumPad1)
            {
                skill1.Enabled = false;
                cd1.Visible = true;
                cd_skill1 = 120 - ENT.Pokemons.getBD()[pk].getAgi();

                CalcularGolpe(ENT.Pokemons.getBD()[pk], ENEMY, 1);
                Enemy_Image.BackColor = Color.Blue;
            }

            if (Control.ModifierKeys == Keys.NumPad2)
            {
                if (ENT.Pokemons.getBD()[pk].PK.getTipo2() != "")
                {
                    skill2.Enabled = false;
                    cd2.Visible = true;
                    cd_skill2 = 120 - ENT.Pokemons.getBD()[pk].getAgi();

                    CalcularGolpe(ENT.Pokemons.getBD()[pk], ENEMY, 2);
                    Enemy_Image.BackColor = Color.Blue;
                }
            }
            if (Control.ModifierKeys == Keys.NumPad3)
            {
                if (PB != null)
                    if (PB.getCantidad() > 0)
                    {
                        PB.USAR(ENT, pk);
                        ENT.Capturar_poke(this.ENEMY);
                        this.NuevaBatalla();
                        if (PB.getCantidad() == 0)
                        {
                            poke_cant.BackColor = Color.Silver;
                        }
                    }
            }
            if (Control.ModifierKeys == Keys.E)
            {
                Close();
            }
            if (Control.ModifierKeys == Keys.Q)
            {
                if (!Pauseado)
                {
                    button2.Text = "Seguir";
                    Refrescar.Enabled = false;
                    golpe_enemigo.Enabled = false;
                    Pauseado = true;
                }
                else
                {
                    button2.Text = "Pausa";
                    Refrescar.Enabled = true;
                    golpe_enemigo.Enabled = true;
                    Pauseado = false;
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!Pauseado)
            {
                button2.Text = "Seguir";
                Refrescar.Enabled = false;
                golpe_enemigo.Enabled = false;
                Pauseado = true;
            }
            else
            {
                button2.Text = "Pausa";
                Refrescar.Enabled = true;
                golpe_enemigo.Enabled = true;
                Pauseado = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pi = new Pokedex(ENEMY);
            pi.Show();
        }


        /*
         * Metodos agregados
         */
        private void NuevaBatalla()
        {
            ENT.poke_vistos++;

            //preparar enemigo
            if (comboBox1.SelectedIndex == 9)
            {
                int cont = 0;
                foreach (Pet pk in ENT.CementerioPK.getBD())
                    if (pk != null)
                        cont++;

                if (new Random().Next(0, 10) != 0||cont==0)
                {
                    this.ENEMYLVL = EnemigolvlRandom();
                    this.ENEMYID = EnemigoRandom();
                    this.ENEMY = new Pet(this.ENEMYID, ENEMYLVL);
                    this.ENEMY.setSEX(Convert.ToBoolean(new Random().Next(2)));
                    this.ENEMY.setVario(Convert.ToBoolean(new Random().Next(2)));
                }
                else
                {
                    this.ENEMY = ENT.CementerioPK.getBD()[new Random().Next(0,cont)];
                }

            }
            else
            {
                int cont = 0;
                foreach (Pet pk in ENT.LiberadosPK.getBD())
                    if (pk != null)
                        cont++;

                if (new Random().Next(0, 30) != 0 || cont == 0)
                {
                    this.ENEMYLVL = EnemigolvlRandom();
                    this.ENEMYID = EnemigoRandom();

                    this.ENEMY = new Pet(this.ENEMYID, ENEMYLVL);
                    if (ENEMYID == (29 | 30 | 31 | 32 | 33 | 34))
                        if (ENEMYID == (29 | 31 | 31))
                            this.ENEMY.setSEX(false);
                        else
                            this.ENEMY.setSEX(true);
                    else
                        this.ENEMY.setSEX(Convert.ToBoolean(new Random().Next(2)));

                    this.ENEMY.setVario(Convert.ToBoolean(new Random().Next(2)));

                }
                else
                {
                    this.ENEMY = ENT.LiberadosPK.getBD()[new Random().Next(0, cont)];
                }
            }

            this.Enemy_Name.Text = this.ENEMY.getNombre() + "  nvl " + this.ENEMY.getNivel().ToString();
            this.Enemy_Image.Image = this.ENEMY.PK.getImage();
            this.label1.Text = this.ENEMY.getSex() ? "Macho" : "Hembra";
            this.Text = "Batalla ( " + ENT.Pokemons.getBD()[pk].getNombre() + " vs " + this.ENEMY.getNombre() + " )";
        }

        private float GOLPE(int aumento, string tipoaliado, string tipoenemigo)
        {
            float multiplicador;
            int tipoenemigo_id = 0;
            int tipoaliado_id = 0;

            for (int i = 0; i < poke_bd.Tipos.Length; i++)
                if (tipoenemigo == poke_bd.Tipos[i])
                    tipoenemigo_id = i;

            for (int i = 0; i < poke_bd.Tipos.Length; i++)
                if (tipoaliado == poke_bd.Tipos[i])
                    tipoaliado_id = i;

            multiplicador = poke_bd.tabla_de_danios_portipo[tipoaliado_id, tipoenemigo_id];

            
            return (new Random().Next(-5,5) + 25 + aumento) * multiplicador;

        }

        private Image DefinirPoder(bool num, Pet p)
        {
            string tipo;
            if (num)
                tipo = p.PK.getTipo1();
            else
                tipo = p.PK.getTipo2();

            switch (tipo)
            {
                case "Acero":
                    return Resources.skill_acero;
                case "Agua":
                    return Resources.skill_agua;
                case "Bicho":
                    return Resources.skill_bicho;
                case "Dragon":
                    return Resources.skill_dragon;
                case "Electrico":
                    return Resources.skill_electrico;
                case "Fantasma":
                    return Resources.skill_fantasma;
                case "Lucha":
                    return Resources.skill_fight;
                case "Fuego":
                    return Resources.skill_fuego;
                case "Hada":
                    return Resources.skill_hada;
                case "Hielo":
                    return Resources.skill_hielo;
                case "Planta":
                    return Resources.skill_hoja;
                case "Normal":
                    return Resources.skill_normal;
                case "Siniestro":
                    return Resources.skill_oscuro;
                case "Psiquico":
                    return Resources.skill_agua;
                case "Roca":
                    return Resources.skill_roca;
                case "Tierra":
                    return Resources.skill_tierra;
                case "Veneno":
                    return Resources.skill_veneno;
                case "Volador":
                    return Resources.skill_volador;
            }
            return null;
        }

        private uint[] Bosque = { 1,10,11,13,14,16,19,21,23,24,25,29,32,43,44,69,114};
        private uint[] Pradera = { 16,17,19,21,22,23,27,35,37,39,43,48,52,53,56,58,63,69,70,83,84,96,102,103,104,105,115,123,128,132,133};
        private uint[] Cueva = {35,41,42,46,50,51,74,75,95,124,140};
        private uint[] Playa = {54,60,61,79,86,90,98,103,120,129,138 };
        private uint[] Oceano = {7,72,116,118,119,120,121,129,130,131 };
        private uint[] Volcan = { 4,37,38,58,59,74,77,95,111,126,146 };
        private uint[] Montaña = {16,17,18,21,22,50,74,83,84,85,142,144,147};
        private uint[] Pantano = {88,89,109,110, 123, 127,132,138, };
        private uint[] CentralElectrica = { 25,81,82,100,101,125,137,145};
        private uint[] Cementerio = { 19,20,92,93,104,105};

        private uint EnemigoRandom()
        {
            this.RANDOMENEMY = new Random();

            switch (comboBox1.Text)
            {
                case "Randomville":
                    return Convert.ToUInt32(this.RANDOMENEMY.Next(1, 152));
                case "Bosque":
                    return Convert.ToUInt32(Bosque[this.RANDOMENEMY.Next(Bosque.Length)]);
                case "Pradera":
                    return Convert.ToUInt32(Pradera[this.RANDOMENEMY.Next(Pradera.Length)]);
                case "Cueva":
                    return Convert.ToUInt32(Cueva[this.RANDOMENEMY.Next(Cueva.Length)]);
                case "Playa":
                    return Convert.ToUInt32(Playa[this.RANDOMENEMY.Next(Playa.Length)]);
                case "Oceano":
                    return Convert.ToUInt32(Oceano[this.RANDOMENEMY.Next(Oceano.Length)]);
                case "Volcan":
                    return Convert.ToUInt32(Volcan[this.RANDOMENEMY.Next(Volcan.Length)]);
                case "Montaña":
                    return Convert.ToUInt32(Montaña[this.RANDOMENEMY.Next(Montaña.Length)]);
                case "Pantano":
                    return Convert.ToUInt32(Pantano[this.RANDOMENEMY.Next(Pantano.Length)]);
                case "Central Electrica":
                    return Convert.ToUInt32(CentralElectrica[this.RANDOMENEMY.Next(CentralElectrica.Length)]);
                case "Cementerio":
                    return Convert.ToUInt32(Cementerio[this.RANDOMENEMY.Next(Cementerio.Length)]);


            }
            return 25;
            

        }
        private short EnemigolvlRandom()
        {
            Random lvl = new Random();

            switch (comboBox1.Text)
            {
                case "Pradera":
                    return (short)(lvl.Next(2, 12));
                case "Bosque":
                    return (short)(lvl.Next(12, 22));
                case "Cueva":
                    return (short)(lvl.Next(2, 12));
                case "Playa":
                    return (short)(lvl.Next(22, 32));
                case "Pantano":
                    return (short)(lvl.Next(32, 42));
                case "Cementerio":
                    return (short)(lvl.Next(52, 62));
                case "Oceano":
                    return (short)(lvl.Next(72, 82));
                case "Volcan":
                    return (short)(lvl.Next(82, 100));
                case "Montaña":
                    return (short)(lvl.Next(82, 100));
                case "Central Electrica":
                    return (short)(lvl.Next(82, 100));
                case "Randomville":
                    return (short)(lvl.Next(2, 100));
            }
            return 1;

        }

        
    }
}
