using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokePet
{
    public class Huevo: Item
    {
        private Pet _Pokemon;

        public Pet Pokemon
        {
            get
            {
                return _Pokemon;
            }

            set
            {
                _Pokemon = value;
            }
        }

       
        public Huevo (Pet P):base(29)
        {
            this.Pokemon = P;

            base.Nombre = Item_bd.nameItem[id];
            base.Cantidad = 1;
            base.Tipo = Item_bd.tipoItem[id];
            base.Aumento = Item_bd.aumItem[id];
            base.TipoAum = Item_bd.tipaumItem[id];
            base.Imagen = Item_bd.imgItem[id];
            base.consumible = true;
            
        }

        public new void USAR(Entrenador e)//nose ejecuta desde la mochila porque??
        {
            e.AGREGAR_poke(Pokemon);
            Console.Write("huevito");
            Cantidad--;
        }

      

    }
}
