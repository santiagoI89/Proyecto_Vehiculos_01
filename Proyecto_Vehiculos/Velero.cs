using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Velero:TransporteAcuatico
    {
        //Metodo de la clase
        public void IzarVelas()
        {
            Console.WriteLine("Debe izar las banderas");
        }
        //Constructor Get y Set
        private string PlanoDeVela;
        public Velero (string planoVelo)
	    {
            PlanoDeVela = planoVelo;
	    }
        public void setVelero(string planoVelo)
        {
            this.PlanoDeVela = planoVelo;
        }
        public string getVelero()
        {
            return " Plano de vela :  " + PlanoDeVela;
        }
        public Velero()
        {
        }
    }
}