using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class AutoHibrido:VehiculoHibrido
    {
        public void EscogerMotorPropulsor()
        {

        }
        
        private string ReferenciasDeMotoresCompatibles;
        //Constructor
        public  AutoHibrido(string referencia)
        {
            ReferenciasDeMotoresCompatibles = referencia;  
        }
        //Get y Set
        public void setReferenciasDeMotoresCompatibles(string referencia)
        {
            this.ReferenciasDeMotoresCompatibles = referencia;
        }

        public string getReferenciasDeMotoresCompatibles()
        {
            return this.ReferenciasDeMotoresCompatibles;
        }


    }   
    
}
