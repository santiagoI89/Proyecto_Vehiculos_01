using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class VehiculoDeCarga:VehiculosDeCombustion
    {
        //Metodo de la clase
        public void TransporteDeMercancia()
        {
            Console.WriteLine("Trasporta altas cargas de peso");
        }
        //Constructor Get y Set
        private double CapacidadRemolque;
        public VehiculoDeCarga(double capacidad )
        {
         CapacidadRemolque = capacidad;
        }

        public VehiculoDeCarga()
        {
        }

        public void setVehiculoDeCarga(double capacidad)
        {
            this.CapacidadRemolque = capacidad;
        }
        public string getVehiculoDeCarga()
        {
            return " Capacidad de remolque: "+ CapacidadRemolque;
        }
    }
}