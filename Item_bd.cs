using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PokePet.Properties;
namespace PokePet
{
    static class Item_bd
    {

        public static string[] nameItem = {
                                           null,//no cambiar
                                          "Cubo Arcoiris",
                                          "Pocion",
                                          "SPocion",
                                          "Car. raro",
                                          "Pokebola",
                                          "Mochila",
                                          "Piedra Lunar",
                                          "Piedra Fuego",
                                          "Piedra Trueno",
                                          "Piedra Agua",
                                          "Piedra Hoja",
                                          "Artefacto",
                                          "Cubo Rojo",
                                          "Cubo Azul",
                                          "Cubo Amarillo",
                                          "Zreza",
                                          "Atania",
                                          "Meloc",
                                          "Safre",
                                          "Perasi",
                                          "Frambu",
                                          "Lagro",
                                          "Oram",
                                          "Masterball",
                                          "HPocion",
                                          "Poc. MAX",
                                          "Restaurador",
                                          "Pase",
                                          "Huevo"
                                          } ;
        public static byte[] tipoItem = { 
                                        0,//no cambiar
                                        1,2,2,0,0,0,4,4,4,4,4,4,1,1,1,1,1,1,1,1,1,1,1,0,2,2,2,0,0
                                        };
        public static int[] aumItem = {
                                       0,//no cambiar
                                       10,300,500,1,0,0,0,0,0,0,0,0,10,10,10,20,40,60,80,100,120,140,160,0,700,9999,9999,0,0
                                       };
        public static byte[] tipaumItem = {
                                            0,//no cambiar
                                            11,1,1,2,0,0,0,0,0,0,0,0,8,9,10,4,4,4,4,4,4,4,4,0,1,1,12,13,0
                                          };
        public static Image[] imgItem = {
                                            null,//no cambiar
                                        Resources.item_arcoiris,
                                        Resources.item_Potion,
                                        Resources.item_Superpotion,
                                        Resources.item_carameloraro,
                                        Resources.item_Pokeball,
                                        Resources.icon_Backpack,
                                        Resources.item_Piedra_lunar,
                                        Resources.item_Piedra_fuego,
                                        Resources.item_Piedra_trueno,
                                        Resources.item_Piedra_agua,
                                        Resources.item_Piedra_hoja,
                                        Resources.icon_PC,
                                        Resources.item_cuborojo,
                                        Resources.item_cuboazul,
                                        Resources.item_cuboamarillo,
                                        Resources.item_Zreza,
                                        Resources.item_Atania,
                                        Resources.item_Meloc,
                                        Resources.item_Safre,
                                        Resources.item_Perasi,
                                        Resources.item_Frambu,
                                        Resources.item_Lagro,
                                        Resources.item_Oram,
                                        Resources.item_masterball,
                                        Resources.item_Hiperpocion,
                                        Resources.item_Pociónmax,
                                        Resources.item_Restaurartodo,
                                        Resources.icon_pase,
                                        Resources.Huevo
                                        };

    }
}
