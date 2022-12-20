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
    public partial class Tienda : Form
    {

        private static Item[] BD = {
                            new Item(0), new Item(1), new Item(2),
                            new Item(3),new Item(4),new Item(5),
                            new Item(6),new Item(7),new Item(8),
                            new Item(9),new Item(10),new Item(11),
                            new Item(12),new Item(13),new Item(14),

                            new Item(15),new Item(16),new Item(17),
                            new Item(18),new Item(19),new Item(20),
                            new Item(21),new Item(22),new Item(23),

                            new Item(24),new Item(25),new Item(26),

                            new Item(27),new Item(28)
                            };

        private Entrenador ENT;
        public Tienda(Entrenador e)
        {
            ENT = e;
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labDinero.Text = ENT.getDinero().ToString();
        }

        private void Vender(int precio,short iditem)
        {
            if (ENT.getDinero() >= precio)
            {
                ENT.darDinero(precio * (-1));
                ENT.AGREGAR_item(BD[iditem]);
            }
            else
                MessageBox.Show("No tienes suficiente dinero");
        }        

        private void Slot1_Click(object sender, EventArgs e)
        {
            this.Vender(2000,1);
        }

        private void Slot1b_Click(object sender, EventArgs e)
        {
            this.Vender(50,2);
        }

        private void Slot2b_Click(object sender, EventArgs e)
        {
            this.Vender(100,3);
        }
        
        private void Slot1c_Click(object sender, EventArgs e)
        {
            this.Vender(10000,4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Vender(500, 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Vender(2000, 6);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Vender(5000, 7);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Vender(5000, 8);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Vender(5000, 9);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Vender(5000, 10);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Vender(5000, 11);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Vender(7500, 12);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Vender(500, 13);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Vender(500, 14);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Vender(500, 15);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Vender(20, 16);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Vender(30, 17);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Vender(40, 18);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Vender(50, 19);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Vender(60, 20);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Vender(70, 21);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Vender(80, 22);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Vender(90, 23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Vender(5000, 24);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.Vender(200, 25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Vender(400, 26);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Vender(600, 27);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Vender(1000, 28);
        }
    }
}
