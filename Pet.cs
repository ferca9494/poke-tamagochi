using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PokePet
{
    [Serializable]
    public class Pet 
    {
        public Pokemon PK;

        private string Nombre = "";
        private bool Sexo = true;
        private float Salud = 0;
        private uint SaludMAX = 0;
        private float Exp = 0;
        private short Nivel = 0;
        private uint Ham = 0;
        private uint Sue = 0;
        private uint Hig = 0;
        private uint Ent = 0;

        private bool variocolor = false;

        private uint fue = 0;
        private uint agi = 0;
        private uint res = 0;

        public bool dormido = false;

        public Pet(uint idd,short lvl)
        {
            if (idd > 0)
            {
                this.PK = new Pokemon(idd);
                this.Nombre = poke_bd.namePoke[idd];
                this.Nivel = lvl;
                this.Salud = 1000;
                this.SaludMAX = 1000 + (uint)Nivel * 10;
                this.Ham = 250;
                this.Sue = 400;
                this.Hig = 100;
                this.Ent = 400;

                Random ran = new Random();

                if(new Random().Next(10)==0)
                    this.fue = (uint)ran.Next(10, 20) + (uint)Nivel + PK.getinifue();
                else
                    this.fue = (uint)ran.Next(1,10) + (uint)Nivel + PK.getinifue();

                if (new Random().Next(10) == 0)
                    this.agi = (uint)ran.Next(10,20) + (uint)Nivel + PK.getiniagi();
                else
                    this.agi = (uint)ran.Next(1, 10) + (uint)Nivel + PK.getiniagi();

                if (new Random().Next(10) == 0)
                    this.res = (uint)ran.Next(10,20) + (uint)Nivel + PK.getinires();
                else
                    this.res = (uint)ran.Next(1, 10) + (uint)Nivel + PK.getinires();

            }
        }
        

        public Pet(uint idd)
        {
            if (idd > 0)
            {
                this.PK = new Pokemon(idd);
                this.Nombre = poke_bd.namePoke[idd];
                this.Salud = 1000;
                this.SaludMAX = 1000 + (uint)Nivel * 10;
                this.Ham = 250;
                this.Sue = 400;
                this.Hig = 100;
                this.Ent = 400;
                this.Nivel = 5;

                Random ran = new Random();

                this.fue = (uint)ran.Next(1, 10) + (uint)Nivel + PK.getinifue();
                this.agi = (uint)ran.Next(1, 10) + (uint)Nivel + PK.getiniagi();
                this.res = (uint)ran.Next(1, 10) + (uint)Nivel + PK.getinires();

                setVario(!Convert.ToBoolean(new Random().Next(0,30)));
            }
        }

        //setters
        
        public void setNombre(string x)
        {
            this.Nombre = x;
        }
        public void setSEX(bool x)
        {
            this.Sexo = x;
        }
        public void setSalud(uint x)
        {
            if (x <= this.SaludMAX)
                this.Salud = x;
        }
        public void setSaludMAX(uint x)
        {
            if (x >= this.Salud)
                this.SaludMAX = x;
        }
        public void setExp(uint x)
        {
            if (x <= 1000)
                this.Exp = x;
        }
        public void setHam(uint x)
        {
            if (x <= 500)
                this.Ham = x;
        }
        public void setSue(uint x)
        {
            if (x <= 500)
                this.Sue = x;
        }
        public void setHig(uint x)
        {
            if (x <= 500)
                this.Hig = x;
        }
        public void setEnt(uint x)
        {
            if (x <= 500)
                this.Ent = x;
        }
        public void setNivel(short x)
        {
            if (x <= 100)
                this.Nivel = x;
        }
        public void setVario(bool x)
        {
            this.variocolor = x;
            if(this.variocolor&&poke_bd.varioPoke[PK.getID()]!=null)
                PK.setImagen(poke_bd.varioPoke[PK.getID()]);
            else
                PK.setImagen(poke_bd.Poke[PK.getID()]);
        }

        public void setFue(uint x)
        {
            fue = x;
        }
        public void setAgi(uint x)
        {
            agi = x;
        }
        public void setRes(uint x)
        {
            res = x;
        }

        //getters
        

        public string getNombre()
        {
            return this.Nombre;
        }
        public float getSalud()
        {
            return this.Salud;
        }
        public uint getSaludMAX()
        {
            return this.SaludMAX;
        }
        public float getExp()
        {
            return this.Exp;
        }
        public uint getHam()
        {
            return this.Ham;
        }
        public uint getSue()
        {
            return this.Sue;
        }
        public uint getHig()
        {
            return this.Hig;
        }
        public uint getEnt()
        {
            return this.Ent;
        }
        public short getNivel()
        {
            return this.Nivel;
        }
       
        public bool getSex()
        {
            return this.Sexo;
        }
        
        public uint getFue()
        {
            return this.fue;
        }
        public uint getAgi()
        {
            return this.agi;
        }
        public uint getRes()
        {
            return this.res;
        }
        public bool getVArio()
        {
            return this.variocolor;
        }
        //Funcionales
        public void LevelUp()
        {
            

            this.Nivel++;
            this.Exp = 0;

            this.fue++;
            this.agi++;
            this.res++;
            this.SaludMAX = SaludMAX + 50;

            if (Nivel == poke_bd.Evolucion_lvl[PK.getID()] && Nivel>0)
            {
                Evolucionar(0);
            }
        }
       
        public void AumExp(int num)
        {
            if (this.Exp + num <= 1000)
                this.Exp += (uint)num;
            else
            {
                for(int i=0;i<(int)(num/1000);i++)
                    this.LevelUp();

                this.Exp += (uint)num-((uint)(num/1000)*1000);
            }               
        }
       
        public void Evolucionar(uint idd)
        {

            if (this.Nombre == PK.getTipo())
                this.Nombre = poke_bd.namePoke[PK.getID()];

            PK.EvolucionarPK(idd);
        }
        public void Sanar(float num)
        {
            if (this.Salud + num <= this.SaludMAX)
                this.Salud += num;
            else
                this.Salud = this.SaludMAX;
        }

        public void Alimentar(int num)
        {
            if (this.Ham + num <= 500)
                this.Ham += (uint)num;
            else
                this.Ham = 500;
        }
        public void Dormir(int num)
        {
            if (this.Sue + num <= 500)
                this.Sue += (uint)num;
            else
                this.Sue = 500;
        }       
        public void Bañar(int num)
        {
            if (this.Hig + num <= 500)
                this.Hig += (uint)num;
            else
                this.Hig = 500;
        }
        public void Jugar(int num)
        {
            if (this.Ent + num <= 500)
                this.Ent += (uint)num;
            else
                this.Ent = 500;
        }

        
    }
}
