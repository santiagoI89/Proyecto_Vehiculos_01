using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class TransporteAereo:Vehiculos
    {
        //Metodos de la clase
        public void Planear()
        {
            Console.WriteLine("Debe planear");
        }
        public void Aterrizar()
        {
            Console.WriteLine("Aterrizaje");
        }
        public void Despegar()
        {
            Console.WriteLine("Debe despegar");
        }
        //Constructor Get y Set
        private int Aleta;
        private int Timon;
        private int CabinaDeMando;
        private int CantidadHelices;
        private int TrenDeAterrizaje;
        public TransporteAereo(int aleta, int timon, int cabinademando, int cantidaddehelices, int trendeaterrizaje)
        {
            Aleta = aleta;
            Timon = timon;
            CabinaDeMando = cabinademando;
            CantidadHelices = cantidaddehelices;
            TrenDeAterrizaje = trendeaterrizaje;
        }

        public TransporteAereo()
        {
        }

        public void setTransporteAereo(int aleta,int timon, int cabinademando, int cantidaddehelices, int trendeaterrizaje)
        {
            this.Aleta = aleta;
            this.Timon = timon;
            this.CabinaDeMando = cabinademando;
            this.CantidadHelices = cantidaddehelices;
            this.TrenDeAterrizaje = trendeaterrizaje;
        }
        public string getTransporteAereo()
        {
            return "Aleta: " + Aleta + "  Timon:  " + Timon + " Cabina de mando: " + CabinaDeMando + " \n Cantidad de helices: " + CantidadHelices + " Tren de aterrizaje: " + TrenDeAterrizaje;
        }

    }
}
