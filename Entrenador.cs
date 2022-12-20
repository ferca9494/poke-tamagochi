using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokePet.Properties;


namespace PokePet
{
    [Serializable]
    public class Entrenador 
    {
        //propiedades
        private int Dinero=200000;
        public int TiempoEnGuarderia = 0;
        public bool EmpesoGuarderia;

        public int Victorias;
        public int Derrotas;
        public int poke_capturados;
        public int poke_vistos;

        public Coleccion_de_Pets Pokemons = new Coleccion_de_Pets(6);
        public Coleccion_de_Pets Guarderia = new Coleccion_de_Pets(2);
        public Coleccion_de_Pets CementerioPK = new Coleccion_de_Pets(10);
        public Coleccion_de_Pets LiberadosPK = new Coleccion_de_Pets(10);
        public Coleccion_de_Pets PC = new Coleccion_de_Pets(48);

        public Item[] Mochila = new Item[48];

        public short Pases=0;

        //getters
        public int getDinero()
        {
            return this.Dinero;
        }


        //metodos
        public void darDinero(int din)
        {
            if (din < 0)
            {
                if (this.Dinero - din >= 0)
                    this.Dinero += din;
            }
            else
                this.Dinero += din;
        }
        public void Capturar_poke(Pet p)
        {
            AGREGAR_poke(p);
            this.poke_capturados++;
        }

        public void AGREGAR_poke(Pet p)
        {
            bool FLAG = false;
            bool FLAG2 = false;

            if (p != null)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (this.Pokemons.getBD()[i]==null)
                    {                       
                        
                        this.Pokemons.getBD()[i] = p;
                        FLAG = true;
                        i = 6;
                    }
                }
                if (!FLAG)
                {
                    for (int i = 0; i < 48; i++)
                    {
                        if (this.PC.getBD()[i] == null)
                        {
                            this.PC.getBD()[i] = p;
                            FLAG2 = true;
                            i = 48;
                        }
                    }
                    if (!FLAG2)
                    {
                        //no hay mas espacio en la pc
                        
                    }
                }

            }
        }
 
        
        public void AGREGAR_item(Item item)
        {
            bool flag = false;
            bool lleno = true;
            Item aux = item;
            if (aux != null)
            {
                if(aux.getID()!=29)
                    foreach (Item auxcol in this.Mochila)
                    {
                        if (auxcol!=null && aux.getID() == auxcol.getID())
                        {
                            auxcol.CantidadMASUNO();
                            flag = true;
                        }
                    }
                if (!flag)
                {
                    for (int i = 0; i < 48; i++)
                    {
                        if (this.Mochila[i] == null)
                        {
                            this.Mochila[i] = aux;
                            if (this.Mochila[i].getCantidad()==0)
                                this.Mochila[i].CantidadMASUNO();
                            i = 49;
                        }
                    }
                    item = aux;
                }
            }
        }
        public void Quitar(int slot)
        {
            this.Mochila[slot]=null;   
        }

        public Item BUSCAR_item_en_mochila(short id)
        {
            foreach (Item aux in this.Mochila)
                if (aux != null && aux.getCantidad() > 0 && aux.getID() == id)
                    return aux;

            return null;
        }



       
        private int sig_tumba=0;
        public void Agregar_a_Cementerio(Pet p)
        {
            CementerioPK.getBD()[sig_tumba] = p;
            CementerioPK.getBD()[sig_tumba].setSalud(CementerioPK.getBD()[sig_tumba].getSaludMAX());
            if (sig_tumba < 10)
                sig_tumba++;
            else
                sig_tumba = 0;

        }
        private int sig_liberado = 0;
        public void Liberar(Pet p)
        {
            LiberadosPK.getBD()[sig_liberado] = p;
            LiberadosPK.getBD()[sig_liberado].setSalud(LiberadosPK.getBD()[sig_liberado].getSaludMAX());
            if (sig_liberado < 10)
                sig_liberado++;
            else
                sig_liberado = 0;

        }


    }
}
