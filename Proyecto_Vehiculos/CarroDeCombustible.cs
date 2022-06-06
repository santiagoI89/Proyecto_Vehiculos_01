using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class CarroDeCombustible:VehiculosDeCombustion
    {
        //Metodo de la clase
        public void ComodidadFamiliar()
        {
            Console.WriteLine("Permite de manera comoda transportar a pocas personas"); 
        }
        //Constructor Get y Set
        private Double NumeroDeRevoluciones;
        public CarroDeCombustible(double numeroDeRevoluciones)
        {
            NumeroDeRevoluciones = numeroDeRevoluciones;
        }
        public void setNumeroDeRevoluciones(double revoluciones)
        {
            this.NumeroDeRevoluciones = revoluciones;
        }
        public string getNumeroDeRevoluciones()
        {
            return " Numero de revoluciones: "+NumeroDeRevoluciones;
        }
        //Constructor Get y Set
        private int VelocidadRespostaje;
        public CarroDeCombustible(int velocidadRespostaje)
        {
            VelocidadRespostaje = velocidadRespostaje;
        }

        public CarroDeCombustible()
        {
        }

        public void setVelocidadRespostaje(int velocidadRespostaje)
        {
            this.VelocidadRespostaje = velocidadRespostaje;
        }
        public string getVelocidadRespostaje()
        {
            return " Velocidad de repostaje: "+VelocidadRespostaje;
        }
    }
}
