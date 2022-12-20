using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PokePet
{

    //modela los items del juego
    [Serializable]
    public class Item
    {
        protected short id=0;        //num de item
        protected string Nombre="-"; //nombre de item
        protected byte Cantidad=1;   //cantidad de items
        protected byte Tipo=0;       //tipo de item
                                     //comida=1 pocion=2 piedra evolutiva=4 otro=0
        protected int Aumento=0;     //Aumento
        protected byte TipoAum=0;    //tipo de aumento
                                     //salud=1 nivel=2 exp=3 hambre=4  higiene=5 sueño=6 entret=7 
                                     //fuerza=8 defensa=9 agilidad=10 lostres=11 todo=12 pase=13 NADA=0

        protected Image Imagen=null; //imagen

        protected bool consumible;   //consumibilidad

  
        public Item(short idd)
        {
            if (idd > 0)
            {
                this.id = idd;
                this.Nombre = Item_bd.nameItem[idd];
                this.Cantidad = 1;
                this.Tipo = Item_bd.tipoItem[idd];
                this.Aumento = Item_bd.aumItem[idd];
                this.TipoAum = Item_bd.tipaumItem[idd];
                this.Imagen = Item_bd.imgItem[idd];
                if (id == 5|| id == 24)
                    this.consumible = false;
                else
                    this.consumible = true;
            }
        }
        public bool getUsable()
        {
            return consumible;
        }

        public short getID()
        {
            return id;
        }
        public Image getImagen()
        {
            return Imagen;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public byte getCantidad()
        {
            return Cantidad;
        }

        public void CantidadMASUNO()
        {
            this.Cantidad++;
        }
     
        public void USAR(Entrenador e,int pk)
        {
            if (Cantidad > 0 && e.Pokemons.getBD()[pk].dormido==false )
            {
                if (Tipo == 4)
                {
                    uint[] evo_pie_lunar = { 30, 33, 35, 39 };
                    uint[] evo_pie_fuego = { 37, 58, 77, 133 };
                    uint[] evo_pie_trueno = { 25, 133 };
                    uint[] evo_pie_agua = { 61, 120, 133 };
                    uint[] evo_pie_hoja = { 44, 70 };
                    uint[] evo_intercambio = { 64, 67, 75, 93 };

                    switch (id)
                    {
                        case 7:                 
                            foreach (uint x in evo_pie_lunar)
                            {
                                if (e.Pokemons.getBD()[pk].PK.getID() == x)
                                    e.Pokemons.getBD()[pk].Evolucionar(0);
                            }
                            break;
                        case 8:

                            if (e.Pokemons.getBD()[pk].PK.getID() == 133)
                            {
                                e.Pokemons.getBD()[pk].Evolucionar(136);
                                break;
                            }
                            foreach (uint x in evo_pie_fuego)
                            {
                                
                                if (e.Pokemons.getBD()[pk].PK.getID() == x)
                                    e.Pokemons.getBD()[pk].Evolucionar(0);
                            }
                            break;
                        case 9:
                            if (e.Pokemons.getBD()[pk].PK.getID() == 133)
                            {
                                e.Pokemons.getBD()[pk].Evolucionar(135);
                                break;
                            }
                            foreach (uint x in evo_pie_trueno)
                            {
                                if (e.Pokemons.getBD()[pk].PK.getID() == x)                             
                                    e.Pokemons.getBD()[pk].Evolucionar(0);
                            }
                            break;
                        case 10:
                    
                        foreach (uint x in evo_pie_agua)
                        {
                            if (e.Pokemons.getBD()[pk].PK.getID() == x)
                                e.Pokemons.getBD()[pk].Evolucionar(0);
                        }
                            break;
                        case 11:
                    
                        foreach (uint x in evo_pie_hoja)
                        {
                            if (e.Pokemons.getBD()[pk].PK.getID() == x)
                                e.Pokemons.getBD()[pk].Evolucionar(0);
                        }
                            break;
                        case 12:               
                        foreach (uint x in evo_intercambio)
                        {
                            if (e.Pokemons.getBD()[pk].PK.getID() == x)
                                e.Pokemons.getBD()[pk].Evolucionar(0);
                        }
                            break;
                    }
                }

                switch (TipoAum)
                {                    
                    case 1:
                        e.Pokemons.getBD()[pk].Sanar(Aumento);
                        break;
                    case 2:
                        e.Pokemons.getBD()[pk].LevelUp();
                        break;
                    case 3:
                        e.Pokemons.getBD()[pk].AumExp(Aumento);
                        break;
                    case 4:                       
                        e.Pokemons.getBD()[pk].Alimentar(Aumento);                      
                        break;
                    case 5:                      
                        e.Pokemons.getBD()[pk].Bañar(Aumento);                      
                        break;
                    case 6:       
                        e.Pokemons.getBD()[pk].Dormir(Aumento);
                        break;
                    case 7:
                        e.Pokemons.getBD()[pk].Jugar(Aumento);
                        Cantidad--;                       
                        break;
                    case 8:
                        e.Pokemons.getBD()[pk].setFue(e.Pokemons.getBD()[pk].getFue() + (uint)Aumento);
                        break;
                    case 9:
                        e.Pokemons.getBD()[pk].setAgi(e.Pokemons.getBD()[pk].getAgi() + (uint)Aumento);                     
                        break;
                    case 10:
                        e.Pokemons.getBD()[pk].setRes(e.Pokemons.getBD()[pk].getRes() + (uint)Aumento);
                        break;
                    case 11:
                        e.Pokemons.getBD()[pk].setFue(e.Pokemons.getBD()[pk].getFue() + (uint)Aumento);
                        e.Pokemons.getBD()[pk].setAgi(e.Pokemons.getBD()[pk].getAgi() + (uint)Aumento);
                        e.Pokemons.getBD()[pk].setRes(e.Pokemons.getBD()[pk].getRes() + (uint)Aumento);
                        break;
                    case 12:
                        e.Pokemons.getBD()[pk].Sanar(Aumento);
                        e.Pokemons.getBD()[pk].Alimentar(Aumento);
                        e.Pokemons.getBD()[pk].Bañar(Aumento);
                        e.Pokemons.getBD()[pk].Dormir(Aumento);
                        e.Pokemons.getBD()[pk].Jugar(Aumento);                      
                        break;
                    case 13:
                        e.Pases++;
                        break;
                }
                //if(consumible)
                Cantidad--;

                if(id==29)
                {
                   
                    Console.Write("huevito2");
                    Cantidad--;
                }
            }

            
        }
    }
}