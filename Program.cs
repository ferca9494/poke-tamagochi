using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokePet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Entrenador ent = new Entrenador();
            Form1 f = new Form1(ent);
            Crear c = new Crear(ent,f);
           // f.Close();
            //c.Show();
            Application.Run(f);
            

        }
    }
}
