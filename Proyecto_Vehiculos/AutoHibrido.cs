using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class AutoHibrido:VehiculoHibrido
    {
        //Metodo de la clase
        public void EscogerMotorPropulsor()
        {
         Console.WriteLine("Puede utilizar propulsion electrica o de combustion");
        }
        private string ReferenciasDeMotoresCompatibles;
        //Constructor Get y Set
        public AutoHibrido(string referencia)
        {
            ReferenciasDeMotoresCompatibles = referencia;  
        }
        public void setReferenciasDeMotoresCompatibles(string referencia)
        {
            this.ReferenciasDeMotoresCompatibles = referencia ;
        }
        public string getReferenciasDeMotoresCompatibles()
        {
            return "Referencia de motor compatible: "+ ReferenciasDeMotoresCompatibles;
        }
        public AutoHibrido()
        {
        }
    }   
}