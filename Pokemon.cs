using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PokePet
{
    [Serializable]
    public class Pokemon
    {

        private uint ID = 0;
        private string Tipo = "";
        private string tipo1 = "-";
        private string tipo2 = "-";
        private Image Imagen = null;
        private Image miniImagen = null;

        private uint inifue = 0;
        private uint iniagi = 0;
        private uint inires = 0;

        public Pokemon(uint idd)
        {
            if (idd > 0)
            {
                this.ID = idd; 
                this.Tipo = poke_bd.namePoke[idd];

                this.Imagen = poke_bd.Poke[idd];

                this.miniImagen = poke_bd.miniPoke[idd];

                this.tipo1 = poke_bd.poketipo1[idd];
                this.tipo2 = poke_bd.poketipo2[idd];

                this.inifue = 0;
                this.iniagi = 0;
                this.inires = 0;

            }
        }
        //setters
        public void setImagen(Image x)
        {
            Imagen = x;
        }
        //getters
        public uint getID()
        {
            return this.ID;
        }
        public string getTipo()
        {
            return this.Tipo;
        }
        public string getTipo1()
        {
            return this.tipo1;
        }
        public string getTipo2()
        {
            return this.tipo2;
        }
        public uint getinifue()
        {
            return this.inifue;
        }
        public uint getinires()
        {
            return this.inires;
        }
        public uint getiniagi()
        {
            return this.iniagi;
        }


        public Image getImage()
        {
            if (ID != 0)
                return this.Imagen;
            else
                return null;
        }
        public Image getminiImage()
        {
            if (ID != 0)
                return this.miniImagen;
            else
                return null;
        }
        

        //metodos
        public void EvolucionarPK(uint idd)
        {
            if (idd != 0)
                ID = idd;
            else
                ID++;

            this.Tipo = poke_bd.namePoke[ID];
            this.Imagen = poke_bd.Poke[ID];
            this.miniImagen = poke_bd.miniPoke[ID];

            this.tipo1 = poke_bd.poketipo1[ID];
            this.tipo2 = poke_bd.poketipo2[ID];
        }

    }


    
}
/*
sensible 
joven 
alma
naturaleza 
comida
testigo
*/ 