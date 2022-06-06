using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Bicicleta:VehiculosDeTraccionHumana
    {
        //Metodo de la clase
        public void TransporteEcologico()
        {
            Console.WriteLine("No genera un impacto ambiental");
        }
        ////Constructor Get y Set
        private string ReferenciaMarco;
        public Bicicleta(string referenciaMarco)
        {
            ReferenciaMarco = referenciaMarco;
        }
        public void setReferenciaMarco(string referenciaMarco)
        {
            this.ReferenciaMarco = referenciaMarco;
        }
        public string getReferenciaMarco()
        {
            return " Referencia marco: " +ReferenciaMarco;
        }
        //Constructor Get y Set
        private int Guardabarros;
        public Bicicleta(int guardabarros)
        {
            Guardabarros = guardabarros;
        }

        public Bicicleta()
        {
        }

        public void setGuardabarros(int guardabarros)
        {
            this.Guardabarros = guardabarros;
        }
        public string getGuardabarros()
        {
            return " Guardabarros: "+Guardabarros;
        }
    }
}
