using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PokePet.Properties;



namespace PokePet
{
    //esta clase conecta los recursos al modelo
    static class poke_bd
    {
        public static Image[] Poke = {
        null,//no cambiar
        Resources.Bulbasaur,  Resources.Ivysaur,    Resources.Venusaur,   Resources.Charmander,  Resources.Charmeleon,
        Resources.Charizard,  Resources.Squirtle,   Resources.Wartortle,  Resources.Blastoise,   Resources.Caterpie,
        Resources.Metapod,   Resources.Butterfree,Resources.Weedle,    Resources.Kakuna,     Resources.Beedrill,
        Resources.Pidgey,    Resources.Pidgeotto, Resources.Pidgeot,   Resources.Rattata,    Resources.Raticate,
        Resources.Spearow,   Resources.Fearow,    Resources.Ekans,     Resources.Arbok,      Resources.Pikachu,
        Resources.Raichu,    Resources.Sandshrew, Resources.Sandslash, Resources.Nidoran_f,  Resources.Nidorina,
        Resources.Nidoqueen, Resources.Nidoran_macho_NB, Resources.Nidorino_NB, Resources.Nidoking_NB,  Resources.Clefairy,
        Resources.Clefable, Resources.Vulpix_NB,    Resources.Ninetales_NB,  Resources.Jigglypuff_NB,   Resources.Wigglytuff_NB,
        Resources.Zubat_NB,Resources.Golbat_NB,Resources.Oddish_NB,Resources.Gloom_NB,Resources.Vileplume_NB,
        Resources.Paras_NB,Resources.Parasect_NB,Resources.Venonat_NB,Resources.Venomoth_NB,Resources.Diglett_NB,
        Resources.Dugtrio_NB,Resources.Meowth_NB,Resources.Persian_NB,Resources.Psyduck_NB,Resources.Golduck_NB,
        Resources.Mankey_NB,Resources.Primeape_NB,Resources.Growlithe_NB,Resources.Arcanine_NB,Resources.Poliwag_NB,
        Resources.Poliwhirl_NB,Resources.Poliwrath_NB,Resources.Abra_NB,Resources.Kadabra_NB,Resources.Alakazam_NB,
        Resources.Machop_NB,Resources.Machoke_NB,Resources.Machamp_NB,Resources.Bellsprout_NB,Resources.Weepinbell_NB,
        Resources.Victreebel_NB,Resources.Tentacool_NB,Resources.Tentacruel_NB,Resources.Geodude_NB,Resources.Graveler_NB,
        Resources.Golem_NB,Resources.Ponyta_NB,Resources.Rapidash_NB,Resources.Slowpoke_NB,Resources.Slowbro_NB,
        Resources.Magnemite_NB,Resources.Magneton_NB,Resources.Farfetch_d_NB,Resources.Doduo_NB,Resources.Dodrio_NB,
        Resources.Seel_NB,Resources.Dewgong_NB,Resources.Grimer_NB,Resources.Muk_NB,Resources.Shellder_NB,
        Resources.Cloyster_NB,Resources.Gastly_NB,Resources.Haunter_NB,Resources.Gengar_NB,Resources.Onix_NB,
        Resources.Drowzee_NB,Resources.Hypno_NB,Resources.Krabby_NB,Resources.Kingler_NB,Resources.Voltorb_NB,
        Resources.Electrode_NB,Resources.Exeggcute_NB,Resources.Exeggutor_NB,Resources.Cubone_NB,Resources.Marowak_NB,
        Resources.Hitmonlee_NB,Resources.Hitmonchan_NB,Resources.Lickitung_NB,Resources.Koffing_NB,Resources.Weezing_NB,
        Resources.Rhyhorn_NB,Resources.Rhydon_NB,Resources.Chansey_NB,Resources.Tangela_NB,Resources.Kangaskhan_NB,
        Resources.Horsea_NB,Resources.Seadra_NB,Resources.Goldeen_NB,Resources.Seaking_NB,Resources.Staryu_NB,
        Resources.Starmie_NB,Resources.Mr__Mime_NB,Resources.Scyther_NB,Resources.Jynx_NB,Resources.Electabuzz_NB,
        Resources.Magmar_NB,Resources.Pinsir_NB,Resources.Tauros_NB,Resources.Magikarp_NB,Resources.Gyarados_NB,
        Resources.Lapras_NB,Resources.Ditto_NB,Resources.Eevee_NB,Resources.Vaporeon_NB,Resources.Jolteon_NB,
        Resources.Flareon_NB,Resources.Porygon_NB,Resources.Omanyte_NB,Resources.Omastar_NB,Resources.Kabuto_NB,
        Resources.Kabutops_NB,Resources.Aerodactyl_NB,Resources.Snorlax_NB,Resources.Articuno_NB,Resources.Zapdos_NB,
        Resources.Moltres_NB,Resources.Dratini_NB,Resources.Dragonair_NB,Resources.Dragonite_NB,Resources.Mewtwo_NB,
        Resources.Mew_NB,Resources.Meloetta_lírica_NB
        };

        public static Image[] varioPoke = {
        null,

        null,null,null,null,null,
        null,null,null,null,null,

        null,null,null,null,null,
        null,null,null,null,null,

        null,null,null,null,null,
        null,null,null,null,null,

        null,null,null,null,null,
        null,null,null,null,null,

        null,null,null,null,null,
        null,null,null,null,null,

        null,null,null,null,null,
        null,null,null,null,null,

        null,null,null,null,null,
        null,null,null,null,null,

        null,null,null,null,null,
        null,null,null,null,null,

        null,null,null,null,null,
        null,null,null,null,null,

        null,null,null,null,null,
        null,null,null,null,null,

        null,null,null,null,null,
        null,null,null,null,null,

        null,null,null,null,null,
        null,null,null,null,null,

        null,null,null,null,null,
        null,null,null,Resources.Magikarp_NB_variocolor,Resources.Gyarados_NB_variocolor,

        null,null,null,null,null,
        null,null,null,null,null,

        null,null,null,null,null,
        null,null,null,null,null,
        null,Resources.Meloetta_danza_NB
        };

        public static Image[] miniPoke = {
        null,//no cambiar
        Resources._1Bulbasaur_mini, Resources.Ivysaur_icon,    Resources.Venusaur_icon,  Resources.Charmander_icon, Resources.Charmeleon_icon,
        Resources.Charizard_icon, Resources.Squirtle_icon,   Resources.Wartortle_icon, Resources.Blastoise_icon,  Resources.Caterpie_icon,
        Resources.Metapod_icon,   Resources.Butterfree_icon, Resources.Weedle_icon,    Resources.Kakuna_icon,     Resources.Beedrill_icon,
        Resources.Pidgey_icon,    Resources.Pidgeotto_icon,  Resources.Pidgeot_icon,   Resources.Rattata_icon,    Resources.Raticate_icon,
        Resources.Spearow_icon,   Resources.Fearow_icon,     Resources.Ekans_icon,     Resources.Arbok_icon,      Resources.Pikachu_icon,
        Resources.Raichu_icon,    Resources.Sandshrew_icon,  Resources.Sandslash_icon, Resources.Nidoran_f_icon,  Resources.Nidorina_icon,
        Resources.Nidoqueen_icon, Resources.Nidoran_icon,    Resources.Nidorino_icon,  Resources.Nidoking_icon,   Resources.Clefairy_icon,
        Resources.Clefable_icon, Resources.Vulpix_icon,    Resources.Ninetales_icon,  Resources.Jigglypuff_icon,   Resources.Wigglytuff_icon,
        Resources.Zubat_icon,Resources.Golbat_icon,Resources.Oddish_icon,Resources.Gloom_icon,Resources.Vileplume_icon,
        Resources.Paras_icon,Resources.Parasect_icon,Resources.Venonat_icon,Resources.Venomoth_icon,Resources.Diglett_icon,
        Resources.Dugtrio_icon,Resources.Meowth_icon,Resources.Persian_icon,Resources.Psyduck_icon,Resources.Golduck_icon,
        Resources.Mankey_icon,Resources.Primeape_icon,Resources.Growlithe_icon,Resources.Arcanine_icon,Resources.Poliwag_icon,
        Resources.Poliwhirl_icon,Resources.Poliwrath_icon,Resources.Abra_icon,Resources.Kadabra_icon,Resources.Alakazam_icon,
        Resources.Machop_icon,Resources.Machoke_icon,Resources.Machamp_icon,Resources.Bellsprout_icon,Resources.Weepinbell_icon,
        Resources.Victreebel_icon,Resources.Tentacool_icon,Resources.Tentacruel_icon,Resources.Geodude_icon,Resources.Graveler_icon,
        Resources.Golem_icon,Resources.Ponyta_icon,Resources.Rapidash_icon,Resources.Slowpoke_icon,Resources.Slowbro_icon,
        Resources.Magnemite_icon,Resources.Magneton_icon,Resources.Farfetch_d_icon,Resources.Doduo_icon,Resources.Dodrio_icon,
        Resources.Seel_icon,Resources.Dewgong_icon,Resources.Grimer_icon,Resources.Muk_icon,Resources.Shellder_icon,
        Resources.Cloyster_icon,Resources.Gastly_icon,Resources.Haunter_icon,Resources.Gengar_icon,Resources.Onix_icon,
        Resources.Drowzee_icon,Resources.Hypno_icon,Resources.Krabby_icon,Resources.Kingler_icon,Resources.Voltorb_icon,
        Resources.Electrode_icon,Resources.Exeggcute_icon,Resources.Exeggutor_icon,Resources.Cubone_icon,Resources.Marowak_icon,
        Resources.Hitmonlee_icon,Resources.Hitmonchan_icon,Resources.Lickitung_icon,Resources.Koffing_icon,Resources.Weezing_icon,
        Resources.Rhyhorn_icon,Resources.Rhydon_icon,Resources.Chansey_icon,Resources.Tangela_icon,Resources.Kangaskhan_icon,
        Resources.Horsea_icon,Resources.Seadra_icon,Resources.Goldeen_icon,Resources.Seaking_icon,Resources.Staryu_icon,
        Resources.Starmie_icon,Resources.Mr__Mime_icon,Resources.Scyther_icon,Resources.Jynx_icon,Resources.Electabuzz_icon,
        Resources.Magmar_icon,Resources.Pinsir_icon,Resources.Tauros_icon,Resources.Magikarp_icon,Resources.Gyarados_icon,
        Resources.Lapras_icon,Resources.Ditto_icon,Resources.Eevee_icon,Resources.Vaporeon_icon,Resources.Jolteon_icon,
        Resources.Flareon_icon,Resources.Porygon_icon,Resources.Omanyte_icon,Resources.Omastar_icon,Resources.Kabuto_icon,
        Resources.Kabutops_icon,Resources.Aerodactyl_icon,Resources.Snorlax_icon,Resources.Articuno_icon,Resources.Zapdos_icon,
        Resources.Moltres_icon,Resources.Dratini_icon,Resources.Dragonair_icon,Resources.Dragonite_icon,Resources.Mewtwo_icon,
        Resources.Mew_icon,Resources.Meloetta_lírica_icon          

        };

        public static uint[] Evolucion_lvl = {
        0,

        16,32,0,16,36,0,16,36,0,7,10,0,7,10,0,18,36,0,20,0,20,0,22,0,0,0,22,0,

        16,0,0,16,0,0,0,0,0,0,0,0,22,0,21,0,0,24,0,31,0,26,0,28,0,33,0,28,0,0,0,25,0,0,

        16,0,0,28,0,0,21,0,0,30,0,25,0,0,40,0,0,37,0,0,30,0,0,31,0,34,0,38,0,0,0,25,0,0,

        0,26,0,28,0,30,0,0,0,28,0,0,0,0,35,0,42,0,0,0,0,32,0,33,0,0,0,0,0,0,0,0,0,0,

        20,0,0,0,0,0,0,0,40,0,40,0,0,0,0,0,0,30,55,0,0,0,

        0,

        };

        public static string[] namePoke = {
        null,//no cambiar
        "Bulbasaur", "Ivysaur","Venusaur","Charmander","Charmeleon",
        "Charizard","Squirtle","Wartortle","Blastoise","Caterpie",
        "Metapod","Butterflee","Weedle","Kakuna","Beedrill",
        "Pidgey","Pidgeotto","Pidgeot","Rattata","Raticate",
        "Spearow","Fearow","Ekans","Arbok","Pikachu",
        "Raichu","Sandshrew","Sandslash","Nidoran F","Nidorina",
        "Nidoqueen", "Nidoran M",    "Nidorino",  "Nidoking",   "Clefairy",
        "Clefable", "Vulpix",    "Ninetales",  "Jigglypuff",   "Wigglytuff",
        "Zubat","Golbat","Oddish","Gloom","Vileplume",
        "Paras","Parasect","Venonat","Venomoth","Diglett",
        "Dugtrio","Meowth","Persian","Psyduck","Golduck",
        "Mankey","Primeape","Growlithe","Arcanine","Poliwag",
        "Poliwhirl","Poliwrath","Abra","Kadabra","Alakazam",
        "Machop","Machoke","Machamp","Bellsprout","Weepinbell",
        "Victreebel","Tentacool","Tentacruel","Geodude","Graveler",
        "Golem","Ponyta","Rapidash","Slowpoke","Slowbro",
        "Magnemite","Magneton","Farfetch d","Doduo","Dodrio",
        "Seel","Dewgong","Grimer","Muk","Shellder",
        "Cloyster","Gastly","Haunter","Gengar","Onix",
        "Drowzee","Hypno","Krabby","Kingler","Voltorb",
        "Electrode","Exeggcute","Exeggutor","Cubone","Marowak",
        "Hitmonlee","Hitmonchan","Lickitung","Koffing","Weezing",
        "Rhyhorn","Rhydon","Chansey","Tangela","Kangaskhan",
        "Horsea","Seadra","Goldeen","Seaking","Staryu",
        "Starmie","Mr. Mime","Scyther","Jynx","Electabuzz",
        "Magmar","Pinsir","Tauros","Magikarp","Gyarados",
        "Lapras","Ditto","Eevee","Vaporeon","Jolteon",
        "Flareon","Porygon","Omanyte","Omastar","Kabuto",
        "Kabutops","Aerodactyl","Snorlax","Articuno","Zapdos",
        "Moltres","Dratini","Dragonair","Dragonite","Mewtwo",
        "Mew","Meloetta"
        };

        public static string[] Tipos = {
        /*0*/"Acero",/*1*/"Agua",/*2*/"Bicho",/*3*/"Dragon",/*4*/"Electrico",
        /*5*/"Fantasma",/*6*/"Fuego",/*7*/"Hada",/*8*/"Hielo",/*9*/"Lucha",
        /*10*/"Normal",/*11*/"Planta",/*12*/"Psiquico",/*13*/"Roca",/*14*/"Siniestro",
        /*15*/"Tierra",/*16*/"Veneno",/*17*/"Volador"
        };

        public static string[] poketipo1 = {
        "",
        poke_bd.Tipos[11],poke_bd.Tipos[11],poke_bd.Tipos[11],poke_bd.Tipos[6],poke_bd.Tipos[6],//charmeleon
        poke_bd.Tipos[6],poke_bd.Tipos[1],poke_bd.Tipos[1],poke_bd.Tipos[1],poke_bd.Tipos[2],//caterpie
        
        poke_bd.Tipos[2],poke_bd.Tipos[2],poke_bd.Tipos[2],poke_bd.Tipos[2],poke_bd.Tipos[2],//beedrill
        poke_bd.Tipos[10],poke_bd.Tipos[10],poke_bd.Tipos[10],poke_bd.Tipos[10],poke_bd.Tipos[10],//raticate
        poke_bd.Tipos[10],poke_bd.Tipos[10],poke_bd.Tipos[16],poke_bd.Tipos[16],poke_bd.Tipos[4],//pikachu
        poke_bd.Tipos[4],poke_bd.Tipos[15],poke_bd.Tipos[15],poke_bd.Tipos[16],poke_bd.Tipos[16],//nidorina
        poke_bd.Tipos[16],poke_bd.Tipos[16],poke_bd.Tipos[16],poke_bd.Tipos[16],poke_bd.Tipos[7],//clefairy
        poke_bd.Tipos[7],poke_bd.Tipos[6],poke_bd.Tipos[6],poke_bd.Tipos[10],poke_bd.Tipos[10],//wigglytuff
        poke_bd.Tipos[16],poke_bd.Tipos[16],poke_bd.Tipos[11],poke_bd.Tipos[11],poke_bd.Tipos[11],//vileplume
     
        poke_bd.Tipos[2],poke_bd.Tipos[2],poke_bd.Tipos[2],poke_bd.Tipos[2],poke_bd.Tipos[15],//diglett
        poke_bd.Tipos[15],poke_bd.Tipos[10],poke_bd.Tipos[10],poke_bd.Tipos[1],poke_bd.Tipos[1],//golduck
        poke_bd.Tipos[9],poke_bd.Tipos[9],poke_bd.Tipos[6],poke_bd.Tipos[6],poke_bd.Tipos[1],//poliwag
        poke_bd.Tipos[1],poke_bd.Tipos[1],poke_bd.Tipos[12],poke_bd.Tipos[12],poke_bd.Tipos[12],//alakazam
        poke_bd.Tipos[9],poke_bd.Tipos[9],poke_bd.Tipos[9],poke_bd.Tipos[11],poke_bd.Tipos[11],//weepinbell
        poke_bd.Tipos[11],poke_bd.Tipos[1],poke_bd.Tipos[1],poke_bd.Tipos[13],poke_bd.Tipos[13],//graveler
        poke_bd.Tipos[13],poke_bd.Tipos[6],poke_bd.Tipos[6],poke_bd.Tipos[1],poke_bd.Tipos[1],//slowbro
        poke_bd.Tipos[4],poke_bd.Tipos[4],poke_bd.Tipos[10],poke_bd.Tipos[10],poke_bd.Tipos[10],//dodrio
        poke_bd.Tipos[1],poke_bd.Tipos[1],poke_bd.Tipos[16],poke_bd.Tipos[16],poke_bd.Tipos[1],//shellder
        poke_bd.Tipos[1],poke_bd.Tipos[5],poke_bd.Tipos[5],poke_bd.Tipos[5],poke_bd.Tipos[13],//onix
        poke_bd.Tipos[12],poke_bd.Tipos[12],poke_bd.Tipos[1],poke_bd.Tipos[1],poke_bd.Tipos[4],
        poke_bd.Tipos[4],poke_bd.Tipos[11],poke_bd.Tipos[11],poke_bd.Tipos[15],poke_bd.Tipos[15],
        poke_bd.Tipos[9],poke_bd.Tipos[9],poke_bd.Tipos[10],poke_bd.Tipos[16],poke_bd.Tipos[16],
        poke_bd.Tipos[15],poke_bd.Tipos[15],poke_bd.Tipos[10],poke_bd.Tipos[11],poke_bd.Tipos[10],
        poke_bd.Tipos[1],poke_bd.Tipos[1],poke_bd.Tipos[1],poke_bd.Tipos[1],poke_bd.Tipos[1],
        poke_bd.Tipos[1],poke_bd.Tipos[12],poke_bd.Tipos[2],poke_bd.Tipos[8],poke_bd.Tipos[4],
        poke_bd.Tipos[6],poke_bd.Tipos[2],poke_bd.Tipos[10],poke_bd.Tipos[1],poke_bd.Tipos[1],
        poke_bd.Tipos[1],poke_bd.Tipos[10],poke_bd.Tipos[10],poke_bd.Tipos[1],poke_bd.Tipos[4],
        poke_bd.Tipos[6],poke_bd.Tipos[10],poke_bd.Tipos[13],poke_bd.Tipos[13],poke_bd.Tipos[13],
        poke_bd.Tipos[13],poke_bd.Tipos[13],poke_bd.Tipos[10],poke_bd.Tipos[8],poke_bd.Tipos[4],
        poke_bd.Tipos[6],poke_bd.Tipos[3],poke_bd.Tipos[3],poke_bd.Tipos[3],poke_bd.Tipos[12],
        poke_bd.Tipos[12],poke_bd.Tipos[10]
        };

        public static string[] poketipo2 = {
        "",//no cambiar
        poke_bd.Tipos[16],poke_bd.Tipos[16],poke_bd.Tipos[16],"","",//charmeleon                               
        poke_bd.Tipos[17],"","","","",                              //caterpie                                        
        "",poke_bd.Tipos[17],poke_bd.Tipos[16],poke_bd.Tipos[16],poke_bd.Tipos[16],//beedrill
        poke_bd.Tipos[17],poke_bd.Tipos[17],poke_bd.Tipos[17],"","",//raticate
        poke_bd.Tipos[17],poke_bd.Tipos[17],"","","",//pikachu
        "","","","","",//nidorina
        poke_bd.Tipos[15],"","",poke_bd.Tipos[15],"",//clefairy
        "","","",poke_bd.Tipos[7],poke_bd.Tipos[7],//wiglytuff
        poke_bd.Tipos[17],poke_bd.Tipos[17],poke_bd.Tipos[16],poke_bd.Tipos[16],poke_bd.Tipos[16],//vileplume
        poke_bd.Tipos[11],poke_bd.Tipos[11],poke_bd.Tipos[16],poke_bd.Tipos[16],"",//diglett
        "","","","","",//golduck
        "","","","","",//poliwag
        "",poke_bd.Tipos[9],"","","",//alakazam
        "","","",poke_bd.Tipos[16],poke_bd.Tipos[16],//weepinbell
        poke_bd.Tipos[16],poke_bd.Tipos[16],poke_bd.Tipos[16],poke_bd.Tipos[15],poke_bd.Tipos[15],//graveler
        poke_bd.Tipos[15], "","",poke_bd.Tipos[12],poke_bd.Tipos[12],//slowbro
        poke_bd.Tipos[0],poke_bd.Tipos[0],poke_bd.Tipos[17],poke_bd.Tipos[17],poke_bd.Tipos[17],//dodrio
        "", poke_bd.Tipos[8],"","","",//shelder
        poke_bd.Tipos[8],poke_bd.Tipos[16],poke_bd.Tipos[16],poke_bd.Tipos[16],poke_bd.Tipos[15],//onix
        "","","","","",//voltrob 100
        "",poke_bd.Tipos[12],poke_bd.Tipos[12],"","",//marowak
        "","","","","",//weezing

        poke_bd.Tipos[13],poke_bd.Tipos[13],"","", "",//kanghaskan

        "","","","","",//staryu

        poke_bd.Tipos[12],poke_bd.Tipos[7],poke_bd.Tipos[17],poke_bd.Tipos[12],"",//electabuzz
        "","","","",poke_bd.Tipos[17],//gyarados
        poke_bd.Tipos[8],"","","","",//jolteon
        "","",poke_bd.Tipos[1],poke_bd.Tipos[1],poke_bd.Tipos[1],//kabuto
        poke_bd.Tipos[1],poke_bd.Tipos[17],"",poke_bd.Tipos[17], poke_bd.Tipos[17],//zapdos
        poke_bd.Tipos[17],"","",poke_bd.Tipos[17],"",//mewtwo
        "",poke_bd.Tipos[12]
        };


        public static float[,] tabla_de_danios_portipo =
        {
            {0.5f,0.5f,1,1,0.5f,1,0.5f,2,2,1,1,1,1,2,1,1,1,1},
            {1,0.5f,1,0.5f,1,1,2,1,1,1,1,0.5f,1,2,1,2,1,1},
            {0.5f,1,1,1,1,0.5f,0.5f,0.5f,1,0.5f,1,2,2,1,2,1,0.5f,0.5f},
            {0.5f,1,1,2,1,1,1,0,1,1,1,1,1,1,1,1,1,1},
            {1,2,1,0.5f,0.5f,1,1,1,1,1,1,0.5f,1,1,1,0,1,2},
            
            {1,1,1,1,1,2,1,1,1,1,0,1,2,1,0.5f,1,1,1},
            {2,0.5f,2,0.5f,1,1,0.5f,1,2,1,1,2,1,0.5f,1,1,1,1},
            {0.5f,1,1,2,1,1,0.5f,1,1,2,1,1,1,1,2,1,0.5f,1},
            {0.5f,0.5f,1,2,1,1,0.5f,1,0.5f,1,1,2,1,1,1,2,1,2},
            {2,1,0.5f,1,1,0,1,0.5f,2,1,2,1,0.5f,2,2,1,0.5f,0.5f},

            {0.5f,1,1,1,1,0,1,1,1,1,1,1,1,0.5f,1,1,1,1},
            {0.5f,2,0.5f,0.5f,1,1,0.5f,1,1,1,1,0.5f,1,2,1,2,0.5f,0.5f},
            {0.5f,1,1,1,1,1,1,1,1,2,1,1,0.5f,1,0,1,2,1},
            {0.5f,1,2,1,1,1,2,1,2,0.5f,1,1,1,1,1,0.5f,1,2},
            {1,1,1,1,1,2,1,0.5f,1,0.5f,1,1,2,1,0.5f,1,1,1},
            
            {2,1,0.5f,1,2,1,2,1,1,1,1,0.5f,1,2,1,1,2,0},
            {0,1,1,1,1,0.5f,1,2,1,1,1,2,1,0.5f,1,0.5f,0.5f,1},
            {0.5f,1,2,1,0.5f,1,1,1,1,2,1,2,1,0.5f,1,1,1,1}

        };



    }
}
