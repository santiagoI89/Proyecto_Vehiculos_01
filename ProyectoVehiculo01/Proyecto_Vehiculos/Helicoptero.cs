using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Helicoptero:TransporteAereo
    {
        public void EncenderHelices()
        {

        }
        private int PalancaDeMando;
        private int Timon;
        public Helicoptero(int palancaDeMando, int timon)
        {
            PalancaDeMando = palancaDeMando;
            Timon = timon;
        }

          
        
    }
}
