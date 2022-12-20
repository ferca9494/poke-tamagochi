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
    public partial class PokePC : Form
    {
        
        //private Entrenador ENT;
        private Entrenador ENT;
        private Pokedex Info;

        public PokePC(Entrenador e)
        {
            ENT = e ;
            
            InitializeComponent();    
        }

        private void PokePC_Load(object sender, EventArgs e)
        {
            //Slot1.AllowDrop = true;
            //Poke_slot6.AllowDrop = true;

            cargarimagenes();
        }

        private void cargarimagenes()
        {       
            this.Poke_slot1.Image = cargarImagen(0,false);          
            this.Poke_slot2.Image = cargarImagen(1, false);
            this.Poke_slot3.Image = cargarImagen(2, false);
            this.Poke_slot4.Image = cargarImagen(3, false);
            this.Poke_slot5.Image = cargarImagen(4, false);
            this.Poke_slot6.Image = cargarImagen(5, false);

            this.Slot1.Image = cargarImagen(0,true);        
            this.Slot2.Image = cargarImagen(1,true);        
            this.Slot3.Image = cargarImagen(2,true);            
            this.Slot4.Image = cargarImagen(3,true);          
            this.Slot5.Image = cargarImagen(4,true);            
            this.Slot6.Image = cargarImagen(5,true);           
            this.Slot7.Image = cargarImagen(6,true);            
            this.Slot8.Image = cargarImagen(7,true);          
            this.Slot9.Image = cargarImagen(8,true);            
            this.Slot10.Image = cargarImagen(9,true);
            this.Slot11.Image = cargarImagen(10,true);          
            this.Slot12.Image = cargarImagen(11,true);            
            this.Slot13.Image = cargarImagen(12,true);
            this.Slot14.Image = cargarImagen(13,true);       
            this.Slot15.Image = cargarImagen(14,true);          
            this.Slot16.Image = cargarImagen(15,true);          
            this.Slot17.Image = cargarImagen(16,true);         
            this.Slot18.Image = cargarImagen(17,true);          
            this.Slot19.Image = cargarImagen(18,true);            
            this.Slot20.Image = cargarImagen(19,true);
            this.Slot21.Image = cargarImagen(20,true);           
            this.Slot22.Image = cargarImagen(21,true);
            this.Slot23.Image = cargarImagen(22,true);
            this.Slot24.Image = cargarImagen(23,true);
            this.Slot25.Image = cargarImagen(24,true);
            this.Slot26.Image = cargarImagen(25,true);
            this.Slot27.Image = cargarImagen(26,true);
            this.Slot28.Image = cargarImagen(27,true);
            this.Slot29.Image = cargarImagen(28,true);
            this.Slot30.Image = cargarImagen(29,true);
            this.Slot31.Image = cargarImagen(30,true);
            this.Slot32.Image = cargarImagen(31,true);
            this.Slot33.Image = cargarImagen(32,true);
            this.Slot34.Image = cargarImagen(33,true);
            this.Slot35.Image = cargarImagen(34,true);
            this.Slot36.Image = cargarImagen(35,true);
            this.Slot37.Image = cargarImagen(36,true);
            this.Slot38.Image = cargarImagen(37,true);
            this.Slot39.Image = cargarImagen(38,true);
            this.Slot40.Image = cargarImagen(39,true);
            this.Slot41.Image = cargarImagen(40,true);
            this.Slot42.Image = cargarImagen(41,true);
            this.Slot43.Image = cargarImagen(42,true);
            this.Slot44.Image = cargarImagen(43,true);
            this.Slot45.Image = cargarImagen(44,true);
            this.Slot46.Image = cargarImagen(45,true);
            this.Slot47.Image = cargarImagen(46,true);
            this.Slot48.Image = cargarImagen(47,true);
        }

        private Image cargarImagen(int slot,bool pc)
        {
            if (pc)
                if (this.ENT.PC.getBD()[slot] != null)
                    return this.ENT.PC.getBD()[slot].PK.getminiImage();
                else
                    return null;
            else
                if (this.ENT.Pokemons.getBD()[slot] != null)
                    return this.ENT.Pokemons.getBD()[slot].PK.getminiImage();
                else
                    return null;

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarimagenes();           
        }


        private void Seleccionar_poke(uint p)
        {
            if (radioButton1.Checked)//transferir a pc
            {
                ENT.PC.Agregar(ENT.Pokemons.getBD()[p]);
                ENT.Pokemons.getBD()[p] = null;
            }
            if (radioButton2.Checked)//info
            {
                Info = new Pokedex(ENT.Pokemons.getBD()[p]);
                Info.Show();
            }
            if (radioButton3.Checked)//liberar
            {
                ENT.Liberar(ENT.Pokemons.getBD()[p]);
                ENT.Pokemons.getBD()[p] = null;
            }

            //eliminar la imagen del poke si se ve en el form principal
            /*
            if (this.ENT.Pokemons.getBD()[pk] != null)
            {
                this.PokemonIMG.Image = this.ENT.Pokemons.getBD()[pk].PK.getImage();
            }
            else
            {
                this.PokemonIMG.Image = null;
            }
            */

        }
        private void Seleccionar_pc(uint p)
        {
            if (radioButton1.Checked)//transferir a entrenador
            {
                ENT.Pokemons.Agregar(ENT.PC.getBD()[p]);
                ENT.PC.getBD()[p] = null;
            }
            if (radioButton2.Checked)//info
            {
                Info = new Pokedex(ENT.PC.getBD()[p]);
                Info.Show();
            }
            if (radioButton3.Checked)//liberar
            {
                ENT.Liberar(ENT.PC.getBD()[p]);
                ENT.PC.getBD()[p] = null;
            }
        }

        private void Poke_slot1_Click(object sender, EventArgs e)//,int tag)
        {
            Seleccionar_poke(0);
        }

        private void Poke_slot2_Click(object sender, EventArgs e)
        {
            Seleccionar_poke(1);
        }

        private void Poke_slot3_Click(object sender, EventArgs e)
        {
            Seleccionar_poke(2);
        }

        private void Poke_slot4_Click(object sender, EventArgs e)
        {
            Seleccionar_poke(3);
        }

        private void Poke_slot5_Click(object sender, EventArgs e)
        {
            Seleccionar_poke(4);
        }

        private void Poke_slot6_Click(object sender, EventArgs e)
        {
            Seleccionar_poke(5);
        }
        /*
        ----------------------------------------------------------
        */
        private void Slot1_Click(object sender, EventArgs e)
        {
            uint p = 0;
            Seleccionar_pc(p);
        }

        private void Slot2_Click(object sender, EventArgs e)
        {
            uint p = 1;
            Seleccionar_pc(p);
        }

        private void Slot3_Click(object sender, EventArgs e)
        {
            uint p = 2;
            Seleccionar_pc(p);

        }

        private void Slot4_Click(object sender, EventArgs e)
        {
            uint p = 3;
            Seleccionar_pc(p);
        }

        private void Slot5_Click(object sender, EventArgs e)
        {
            uint p = 4;
            Seleccionar_pc(p);
        }

        private void Slot6_Click(object sender, EventArgs e)
        {
            uint p = 5;
            Seleccionar_pc(p);
        }

        private void Slot7_Click(object sender, EventArgs e)
        {
            uint p = 6;
            Seleccionar_pc(p);
        }

        private void Slot8_Click(object sender, EventArgs e)
        {
            uint p = 7;
            Seleccionar_pc(p);
        }

        private void Slot9_Click(object sender, EventArgs e)
        {
            uint p = 8;
            Seleccionar_pc(p);
        }

        private void Slot10_Click(object sender, EventArgs e)
        {
            uint p = 9;
            Seleccionar_pc(p);
        }

        private void Slot11_Click(object sender, EventArgs e)
        {
            uint p = 10;
            Seleccionar_pc(p);
        }

        private void Slot12_Click(object sender, EventArgs e)
        {
            uint p = 11;
            Seleccionar_pc(p);
        }

        private void Slot13_Click(object sender, EventArgs e)
        {
            uint p = 12;
            Seleccionar_pc(p);
        }

        private void Slot14_Click(object sender, EventArgs e)
        {
            uint p = 13;
            Seleccionar_pc(p);
        }

        private void Slot15_Click(object sender, EventArgs e)
        {
            uint p = 14;
            Seleccionar_pc(p);
        }

        private void Slot16_Click(object sender, EventArgs e)
        {
            uint p = 15;
            Seleccionar_pc(p);
        }

        private void Slot17_Click(object sender, EventArgs e)
        {
            uint p = 16;
            Seleccionar_pc(p);
        }

        private void Slot18_Click(object sender, EventArgs e)
        {
            uint p = 17;
            Seleccionar_pc(p);
        }

        private void Slot19_Click(object sender, EventArgs e)
        {
            uint p = 18;
            Seleccionar_pc(p);
        }

        private void Slot20_Click(object sender, EventArgs e)
        {
            uint p = 19;
            Seleccionar_pc(p);
        }

        private void Slot21_Click(object sender, EventArgs e)
        {
            uint p = 20;
            Seleccionar_pc(p);
        }

        private void Slot22_Click(object sender, EventArgs e)
        {
            uint p = 21;
            Seleccionar_pc(p);
        }

        private void Slot23_Click(object sender, EventArgs e)
        {
            uint p = 22;
            Seleccionar_pc(p);
        }

        private void Slot24_Click(object sender, EventArgs e)
        {
            uint p = 23;
            Seleccionar_pc(p);
        }

        private void Slot25_Click(object sender, EventArgs e)
        {
            uint p = 24;
            Seleccionar_pc(p);
        }

        private void Slot26_Click(object sender, EventArgs e)
        {
            uint p = 25;
            Seleccionar_pc(p);
        }

        private void Slot27_Click(object sender, EventArgs e)
        {
            uint p = 26;
            Seleccionar_pc(p);
        }

        private void Slot28_Click(object sender, EventArgs e)
        {
            uint p = 27;
            Seleccionar_pc(p);
        }

        private void Slot29_Click(object sender, EventArgs e)
        {
            uint p = 28;
            Seleccionar_pc(p);
        }

        private void Slot30_Click(object sender, EventArgs e)
        {
            uint p = 29;
            Seleccionar_pc(p);
        }

        private void Slot31_Click(object sender, EventArgs e)
        {
            uint p = 30;
            Seleccionar_pc(p);
        }

        private void Slot32_Click(object sender, EventArgs e)
        {
            uint p = 31;
            Seleccionar_pc(p);
        }

        private void Slot33_Click(object sender, EventArgs e)
        {
            uint p = 32;
            Seleccionar_pc(p);
        }

        private void Slot34_Click(object sender, EventArgs e)
        {
            uint p = 33;
            Seleccionar_pc(p);
        }

        private void Slot35_Click(object sender, EventArgs e)
        {
            uint p = 34;
            Seleccionar_pc(p);
        }

        private void Slot36_Click(object sender, EventArgs e)
        {
            uint p = 35;
            Seleccionar_pc(p);
        }

        private void Slot37_Click(object sender, EventArgs e)
        {
            uint p = 36;
            Seleccionar_pc(p);
        }

        private void Slot38_Click(object sender, EventArgs e)
        {
            uint p = 37;
            Seleccionar_pc(p);
        }

        private void Slot39_Click(object sender, EventArgs e)
        {
            uint p = 38;
            Seleccionar_pc(p);
        }

        private void Slot40_Click(object sender, EventArgs e)
        {
            uint p = 39;
            Seleccionar_pc(p);
        }
        private void Slot41_Click(object sender, EventArgs e)
        {
            uint p = 40;
            Seleccionar_pc(p);
        }
        private void Slot42_Click(object sender, EventArgs e)
        {
            uint p = 41;
            Seleccionar_pc(p);
        }
        private void Slot43_Click(object sender, EventArgs e)
        {
            uint p = 42;
            Seleccionar_pc(p);
        }
        private void Slot44_Click(object sender, EventArgs e)
        {
            uint p = 43;
            Seleccionar_pc(p);
        }
        private void Slot45_Click(object sender, EventArgs e)
        {
            uint p = 44;
            Seleccionar_pc(p);
        }
        private void Slot46_Click(object sender, EventArgs e)
        {
            uint p = 45;
            Seleccionar_pc(p);
        }
        private void Slot47_Click(object sender, EventArgs e)
        {
            uint p = 46;
            Seleccionar_pc(p);
        }
        private void Slot48_Click(object sender, EventArgs e)
        {
            uint p = 47;
            Seleccionar_pc(p);
        }

        
        
    }
}