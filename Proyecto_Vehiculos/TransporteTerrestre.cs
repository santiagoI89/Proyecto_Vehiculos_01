using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class TransporteTerrestre:Vehiculos
    {
        //Metodo de la clase
        public void TrasportarPorSuelo()
        {
            Console.WriteLine("Transporta de suelo");
        }
        //Constructor Get y Set
        private int CantidadDeRuedas;
        private int TraccionDeRuedas;

        public TransporteTerrestre(int cantidadruedas, int traccionruedas)
        {
         CantidadDeRuedas = cantidadruedas;
         TraccionDeRuedas = traccionruedas;
        }

        public TransporteTerrestre()
        {
        }

        public void setTransporteTerrestre(int cantidadruedas, int traccionruedas)
        {
            this.CantidadDeRuedas = cantidadruedas;
            this.TraccionDeRuedas = traccionruedas;
        }
        public string getTransporteTerrestre()
        {
            return "Cantidad ruedas:  " + CantidadDeRuedas + "  Traccion de ruedas:   " + TraccionDeRuedas;
        }
    }
}
