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
    public partial class Estadisticas : Form
    {
        private Entrenador ENT;
        public Estadisticas(Entrenador e)
        {
            ENT = e;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = ENT.Victorias.ToString();
            label4.Text = ENT.Derrotas.ToString();
            label7.Text = ENT.poke_capturados.ToString();
            label8.Text = ENT.poke_vistos.ToString(); ;
            label9.Text = ENT.getDinero().ToString();
        }
    }
}
