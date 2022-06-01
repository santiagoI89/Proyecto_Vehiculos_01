using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class TransporteAereo:Vehiculos
    {
        public void Planear()
        {

        }
        public void Aterrizar()
        {

        }
        public void Despegar()
        {

        }
        private int Aleta;

        public TransporteAereo(int aleta)
        {
            Aleta = aleta;
        }

        private int Timon;
        private int CabinaDeMando;
        private int CantidadHelices;
        private int TrenDeAterrizaje;
    }
}
