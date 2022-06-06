using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class VehiculosDeTraccionHumana:TransporteTerrestre
    {
        //Metodo de la clase
        public void ImpulsoHumano()
        {
            Console.WriteLine("Su alimentacion es dada por el impulso humano");
        }
        //Constructor Get y Set
        private double FuerzaMuscularHumana;
        public VehiculosDeTraccionHumana(double fuerzahumana)
        {
            FuerzaMuscularHumana = fuerzahumana;
        }
        public void setFuerzaMuscularHumana(double fuerzahumana)
        {
            this.FuerzaMuscularHumana = fuerzahumana;
        }
        public string getFuerzaMuscularHumana()
        {
            return " Fuerza humana:  " + FuerzaMuscularHumana;
        }
        public VehiculosDeTraccionHumana()
        {
        }
    }
}