using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokePet.Properties;
using System.Windows.Forms;

namespace PokePet
{
    //modela un conjunto de pet
    [Serializable]
    public class Coleccion_de_Pets
    {
        /*
        private static Pet[] BD= { 
                                  new Pet(0),
                                  new Pet(1), new Pet(2), new Pet(3), new Pet(4), new Pet(5),
                                  new Pet(6), new Pet(7), new Pet(8),new Pet(9), new Pet(10),
                                  new Pet(11), new Pet(12), new Pet(13), new Pet(14),new Pet(15),
                                  new Pet(16), new Pet(17), new Pet(18), new Pet(19), new Pet(20),
                                  new Pet(21), new Pet(22), new Pet(23), new Pet(24), new Pet(25),
                                  new Pet(26), new Pet(27),new Pet(28),new Pet(29),new Pet(30),

                                  new Pet(31),new Pet(32),new Pet(33),new Pet(34),new Pet(35),
                                  new Pet(36),new Pet(37),new Pet(38),new Pet(39),new Pet(40),
                                  new Pet(41),new Pet(42),new Pet(43),new Pet(44),new Pet(45),
                                  new Pet(46),new Pet(47),new Pet(48),new Pet(49),new Pet(50),
                                  new Pet(51),new Pet(52),new Pet(53),new Pet(54),new Pet(55),
                                  new Pet(56),new Pet(57),new Pet(58),new Pet(59),new Pet(60),
                                  new Pet(61),new Pet(62),new Pet(63),new Pet(64),new Pet(65),
                                  new Pet(66),new Pet(67),new Pet(68),new Pet(69),new Pet(70),
                                  new Pet(71),new Pet(72),new Pet(73),new Pet(74),new Pet(75),
                                  new Pet(76),new Pet(77),new Pet(78),new Pet(79),new Pet(80),
                                  new Pet(81),new Pet(82),new Pet(83),new Pet(84),new Pet(85),
                                  new Pet(86),new Pet(87),new Pet(88),new Pet(89),new Pet(90),
                                  new Pet(91),new Pet(92),new Pet(93),new Pet(94),new Pet(95),
                                  new Pet(96),new Pet(97),new Pet(98),new Pet(99),new Pet(100),
                                  new Pet(101),new Pet(102),new Pet(103),new Pet(104),new Pet(105),
                                  new Pet(106),new Pet(107),new Pet(108),new Pet(109),new Pet(110),
                                  new Pet(111),new Pet(112),new Pet(113),new Pet(114),new Pet(115),
                                  new Pet(116),new Pet(117),new Pet(118),new Pet(119),new Pet(120),
                                  new Pet(121),new Pet(122),new Pet(123),new Pet(124),new Pet(125),
                                  new Pet(126),new Pet(127),new Pet(128),new Pet(129),new Pet(130),
                                  new Pet(131),new Pet(132),new Pet(133),new Pet(134),new Pet(135),
                                  new Pet(136),new Pet(137),new Pet(138),new Pet(139),new Pet(140),
                                  new Pet(141),new Pet(142),new Pet(143),new Pet(144),new Pet(145),
                                  new Pet(146),new Pet(147),new Pet(148),new Pet(149),new Pet(150),
                                  new Pet(151),new Pet(152)
                                 };
        */
        private Pet[] BD;

        public Coleccion_de_Pets(uint x)
        {
            if (x == 6) BD = new Pet[6];
            if (x == 2) BD = new Pet[2];
            if (x == 10) BD = new Pet[10];
            if (x == 48) BD = new Pet[48];
            /*
            for (uint i=0; i<x; i++)
            {
                BD[i]=new Pet(0);
            }*/
        }

        public  Pet[] getBD()
        {
            return BD;
        }

        public Pet BuscarporID(uint id)
        {
            foreach (Pet aux in BD)
                if (aux.PK.getID() == id)
                    return aux;
              
            return null;        
        }

        public void Agregar(Pet p)
        {
            uint i;
            for ( i = 0; i < BD.Length; i++)
                if (BD[i] == null)
                {
                    BD[i] = p;
                    i = (uint)BD.Length;
                }
            if(i == BD.Length-1)
                MessageBox.Show("No hay Espacio");

        }

        

    }
}
