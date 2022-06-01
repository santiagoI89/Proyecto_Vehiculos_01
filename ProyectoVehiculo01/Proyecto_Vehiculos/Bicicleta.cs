using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Bicicleta:VehiculosDeTraccionHumana
    {
        public void TransporteEcologico()
        {

        }
        private string ReferenciaMarco;

        public Bicicleta(string referenciaMarco)
        {
            ReferenciaMarco = referenciaMarco;
        }

        private int Guardabarros;

        public Bicicleta(int guardabarros)
        {
            Guardabarros = guardabarros;
        }
    }
}
