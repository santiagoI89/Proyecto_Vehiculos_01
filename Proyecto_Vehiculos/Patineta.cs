using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Patineta:VehiculosDeTraccionHumana
    {
        //Metodo de la clase
        public void TransportaUnaPersona()
        {
            Console.WriteLine("Solo puede transportar a una persona ");
        }
        //Constructor Get y Set
        private string ReferenciaTabla;

        public Patineta(string referenciaTabla)
        {
            ReferenciaTabla = referenciaTabla;
        }

        public Patineta()
        {
        }

        public void setReferenciaTabla(string referenciatabla)
        {
            this.ReferenciaTabla = referenciatabla;
        }
        public string getReferenciaTabla()
        {
            return " Referencia tabla: "+ReferenciaTabla;
        }
    }
}
