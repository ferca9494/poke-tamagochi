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
    public partial class Mochila : Form
    {
        
        private Entrenador ENT;
        public int pk; //poke seleccionado
        public bool itemusado=false;
        private short SELECT_MOCHILA=1;

        public Mochila(Entrenador e)
        {
            ENT = e;

            if (ENT.Pokemons.getBD()[pk] != null)
            {
                InitializeComponent();              
            }
        }

        public void setpk(int p)
        {
            pk = p;
        }

        private void Slot1_Click(object sender, EventArgs e)
        {
            USAR(0);         
        }

        private void Slot2_Click(object sender, EventArgs e)
        {
            USAR(1);
        }

        private void Slot3_Click(object sender, EventArgs e)
        {
            USAR(2);
        }

        private void Slot4_Click(object sender, EventArgs e)
        {
            USAR(3);
        }

        private void Slot5_Click(object sender, EventArgs e)
        {
            USAR(4);
        }
    
        private void Slot6_Click(object sender, EventArgs e)
        {
            USAR(5);
        }

        private void Slot7_Click(object sender, EventArgs e)
        {
            USAR(6);
        }

        private void Slot8_Click(object sender, EventArgs e)
        {
            USAR(7);
        }

        private void Slot9_Click(object sender, EventArgs e)
        {
            USAR(8);
        }

        private void Slot10_Click(object sender, EventArgs e)
        {
            USAR(9);
        }

        private void Slot11_Click(object sender, EventArgs e)
        {
            USAR(10);
        }

        private void Slot12_Click(object sender, EventArgs e)
        {
            USAR(11);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Slot1.Image = ImagenItem(0);
            Slot2.Image = ImagenItem(1);
            Slot3.Image = ImagenItem(2);
            Slot4.Image = ImagenItem(3);
            Slot5.Image = ImagenItem(4);
            Slot6.Image = ImagenItem(5);
            Slot7.Image = ImagenItem(6);
            Slot8.Image = ImagenItem(7);
            Slot9.Image = ImagenItem(8);
            Slot10.Image = ImagenItem(9);
            Slot11.Image = ImagenItem(10);
            Slot12.Image = ImagenItem(11);

            SlotName1.Text = NombreItem(0);
            SlotName2.Text = NombreItem(1);
            SlotName3.Text = NombreItem(2);
            SlotName4.Text = NombreItem(3);
            SlotName5.Text = NombreItem(4);
            SlotName6.Text = NombreItem(5);
            SlotName7.Text = NombreItem(6);
            SlotName8.Text = NombreItem(7);
            SlotName9.Text = NombreItem(8);
            SlotName10.Text = NombreItem(9);
            SlotName11.Text = NombreItem(10);
            SlotName12.Text = NombreItem(11);

            SlotCant1.Text = CantidadItem(0);
            SlotCant2.Text = CantidadItem(1);
            SlotCant3.Text = CantidadItem(2);
            SlotCant4.Text = CantidadItem(3);
            SlotCant5.Text = CantidadItem(4);
            SlotCant6.Text = CantidadItem(5);
            SlotCant7.Text = CantidadItem(6);
            SlotCant8.Text = CantidadItem(7);
            SlotCant9.Text = CantidadItem(8);
            SlotCant10.Text = CantidadItem(9);
            SlotCant11.Text = CantidadItem(10);
            SlotCant12.Text = CantidadItem(11);

        }

        private Image ImagenItem(short x)
        {
            
            switch(SELECT_MOCHILA)
            {
                case 1:
                    if (ENT.Mochila[x] != null)
                        return ENT.Mochila[x].getImagen();
                    else
                        return null;
                case 2:
                    if (ENT.Mochila[x+12] != null)
                        return ENT.Mochila[x+12].getImagen();
                    else
                        return null;
                case 3:
                    if (ENT.Mochila[x+24] != null)
                        return ENT.Mochila[x+24].getImagen();
                    else
                        return null;
                case 4:
                    if (ENT.Mochila[x + 24] != null)
                        return ENT.Mochila[x+36].getImagen();
                    else
                        return null;

            }
            return null;
        }
        private string NombreItem(short x)
        {
            switch (SELECT_MOCHILA)
            {
                case 1:
                    if (ENT.Mochila[x] != null)
                        return ENT.Mochila[x].getNombre();
                    else
                        return null;
                case 2:
                    if (ENT.Mochila[x+12] != null)
                        return ENT.Mochila[x + 12].getNombre();
                    else
                        return null;
                case 3:
                    if (ENT.Mochila[x+24] != null)
                        return ENT.Mochila[x + 24].getNombre();
                    else
                        return null;
                case 4:
                    if (ENT.Mochila[x+36] != null)
                        return ENT.Mochila[x + 36].getNombre();
                    else
                        return null;
            }
            return null;
        }
        private string CantidadItem(short x)
        {
            switch (SELECT_MOCHILA)
            {
                case 1:
                    if (ENT.Mochila[x] != null && ENT.Mochila[x].getID()!=29)
                        return "x" + ENT.Mochila[x].getCantidad().ToString();
                    else
                        return null;
                case 2:
                    if (ENT.Mochila[x+12] != null && ENT.Mochila[x].getID() != 29)
                        return "x" + ENT.Mochila[x + 12].getCantidad().ToString();
                    else
                        return null;
                case 3:
                    if (ENT.Mochila[x+24] != null && ENT.Mochila[x].getID() != 29)
                        return "x" + ENT.Mochila[x + 24].getCantidad().ToString();
                    else
                        return null;
                case 4:
                    if (ENT.Mochila[x+36] != null && ENT.Mochila[x].getID() != 29)
                        return "x" + ENT.Mochila[x + 36].getCantidad().ToString();
                    else
                        return null;
            }
            return null;
        }
        private void Mochila1_Click(object sender, EventArgs e)
        {
            SELECT_MOCHILA = 1;
            
        }
        private void Mochila2_Click(object sender, EventArgs e)
        {
            SELECT_MOCHILA = 2;
        }
        private void Mochila3_Click(object sender, EventArgs e)
        {
            SELECT_MOCHILA = 3;
        }
        private void Mochila4_Click(object sender, EventArgs e)
        {
            SELECT_MOCHILA = 4;
        }

        private void desbloquearMochila(int slot)
        {
            if(ENT.Mochila[slot]!=null&&ENT.Mochila[slot].getID()==6)
            {
                if (Mochila3.Visible)
                    Mochila4.Visible = true;

                if (Mochila2.Visible)
                    Mochila3.Visible = true;
              
                Mochila2.Visible = true;
            }
        }

        private void usar_item(int slot, int offset)
        {
            if (ENT.Mochila[slot] != null)
            {
                desbloquearMochila(slot + offset);
                if (ENT.Mochila[slot + offset].getID() == 29)
                {
                    Huevo hue = (Huevo)ENT.Mochila[slot + offset];
                    hue.USAR(ENT);
                  
                    if (ENT.Mochila[slot + offset].getCantidad() == 0)
                        ENT.Quitar(slot + offset);
                }
                else
                {
                    if (ENT.Mochila[slot + offset].getID() != 5)
                        ENT.Mochila[slot + offset].USAR(ENT, pk);

                    if (ENT.Mochila[slot + offset].getCantidad() == 0)
                        ENT.Quitar(slot + offset);
                }
            }
        }

        private void USAR(int slot)
        {
            
            switch (SELECT_MOCHILA)
            {
                case 1:
                    usar_item(slot, 0);
                    break;
                case 2:
                    usar_item(slot, 12);
                    break;
                case 3:
                    usar_item(slot, 24);
                    break;
                case 4:
                    usar_item(slot, 36);
                    break;
            }

            itemusado = true;
        }
          
    }
}
