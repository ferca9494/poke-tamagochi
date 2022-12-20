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
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Notificaciones;
        }

        public static bool Notificaciones=true;

        private void button1_Click(object sender, EventArgs e)
        {
            Notificaciones = checkBox1.Checked;
            this.Close();
        }
    }
}
