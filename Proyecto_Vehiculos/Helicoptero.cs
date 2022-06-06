using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Helicoptero:TransporteAereo
    {
        //Metodo de la clase
        public void EncenderHelices()
        {
            Console.WriteLine("Enciende las helices para despegar");
        }
        //Constructores Get y Set
        private int PalancaDeMando;
        private int Timon;
        public Helicoptero(int palancaDeMando, int timon)
        {
            PalancaDeMando = palancaDeMando;
            Timon = timon;
        }

        public Helicoptero()
        {
        }
        public void setHelicoptero(int palancaDeMando, int timon)
        {
            this.PalancaDeMando = palancaDeMando;
            this.Timon = timon;
        }
        public string getHelicoptero()
        {
            return " Palanca de cambios:  "+ PalancaDeMando + " Timon: "+ Timon;
            
        }
    }
}
