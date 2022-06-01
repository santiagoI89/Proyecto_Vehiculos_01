using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Bus
    {
        public void TransportaGranCantidadDePersonas()
        {

        }
        private string Ruta;

        public Bus(string ruta)
        {
            Ruta = ruta;
        }

        private string Paraderos; 
        public Bus()
        {
                
        }
        private int NumeroVaganes;

        public Bus(int numeroVaganes)
        {
            NumeroVaganes = numeroVaganes;
        }
    }
}
