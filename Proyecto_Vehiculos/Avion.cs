using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Avion:TransporteAereo
    {
        //Metodo de la clase
        public void TransportarPersonasEnElAire()
        {
         Console.WriteLine("Puede transportar de manera masiva por el aire");
        }
        private int Alas;
        //Constructor Get y Set
        public Avion(int alas)
        {
            Alas = alas;
        }

        public Avion()
        {
        }

        public void setAlas(int alas)
        {
            this.Alas = alas;
        }
        public String getAlas()
        {
            return " Alas: " +Alas;
        }


    }
}
