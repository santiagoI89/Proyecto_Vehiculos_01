using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Bus:VehiculosDeCombustion
    {
        //Metodo de la clase
        public void TransportaGranCantidadDePersonas()
        {
         Console.WriteLine("Tranpota personas de manera masiva por el suelo");
        }
        //Constructor Get y Set
        private string Ruta;
        public Bus(string ruta, string paraderos)
        {
            Ruta = ruta;
            Paraderos = paraderos;
        }
        public void setRuta(string ruta)
        {
            this.Ruta = ruta;
        }
        public string getRuta()
        {
            return " Ruta: "+Ruta;
        }
        // Get y Set Paraderos
        private string Paraderos; 
        public void setParaderos(string paraderos)
        {
            this.Paraderos = paraderos;
        }
        public string getParaderos()
        {
            return " Paraderos: "+Paraderos;
        }
        //Constructor Get y Set
        private int NumeroVagones;

        public Bus(int numeroVagones)
        {
            NumeroVagones = numeroVagones;
        }

        public Bus()
        {
        }

        public void setNumeroVagones(int numeroVagones)
        {
            this.NumeroVagones = numeroVagones;
        }
        public string getNumeroVagones()
        {
            return " Numero de vagones: " +NumeroVagones;
        }
    }
}
