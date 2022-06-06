using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class VehiculosDeCombustion:TransporteTerrestre
    {
        //Metodo de la clase
        public void ImpulsoPorCombustion()
        {
            Console.WriteLine("su alimentacion es dada por combustible");
        }
        //Constructor Get y Set
        private double CapacidadDeCombustible;
        public VehiculosDeCombustion (double capacidadcombustible)
	    {
            CapacidadDeCombustible = capacidadcombustible;
	    }
        public void setVehiculosCombustion(double capacidadcombustible)
        {
            this.CapacidadDeCombustible = capacidadcombustible;
        }
        public string getVehiculosCombustion()
        {
            return " Capacidad de combustible:  "+ CapacidadDeCombustible;
        }
        //Constructor Get y Set
        private int Escape;
        public VehiculosDeCombustion (int escape)
	    {
           Escape = escape;
	    }

        public VehiculosDeCombustion()
        {
        }

        public void setVehiculosCombustionExtras(int escape)
        {
            this.Escape = escape;
        }
        public string getVehiculosCombustionExtras()
        {
            return " Escape:  " + Escape;
        }

    }
}