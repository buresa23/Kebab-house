using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab_house
{
    internal class Sklad
    {
        public int ZasobaMasa { get; private set; }
        public int ZasobaSalat { get; private set; }
        public int ZasobaZelí { get; private set; }

        public Sklad(int zasobaMasa, int zasobaSalat, int zasobaZelí)
        {
            ZasobaMasa = zasobaMasa;
            ZasobaSalat = zasobaSalat;
            ZasobaZelí = zasobaZelí;
        }
    }
     //public bool KontrolaMnozstviSurovin(int zasobaMasa, int zasobaSalt, int zasobaZeli) 
        //{if (Kebaby. ) 
        
        
        
        
        
        //}
