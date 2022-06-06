using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Moto:VehiculosDeCombustion
    {
        //Metodo de la clase
        public void MenorConsumoDeCombustible()
        {
            Console.WriteLine("pemite el transporte de personas con poco combustible");
        }
        //Constructor Get y Set
        private int Cilindraje;

        public Moto(int cilindraje)
        {
            Cilindraje = cilindraje;
        }

        public Moto()
        {
        }

        public void setCilindraje(int cilindraje)
        {
            this.Cilindraje = cilindraje;
        }
        public string getCilindraje()
        {
            return " Cilindraje: "+Cilindraje;
        }
    }
}
