using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class ScotterElectrico:VehiculosElectricos
    {
        //Metodos de la clase
        public void TransporteRapidoEficaz()
        {
            Console.WriteLine("Transporte ligero y rapido");
        }
        public void EvitarTrafico()
        {
            Console.WriteLine("No debe andar por las avenidas y evita trafico");
        }
        //Constructor Get y Set
        private string SistemaDePlegado;
        private string SistemaAutoequlibrado;
        public ScotterElectrico(string sistemaDePlegado, string sistemaautoequilibrado)
        {
            SistemaDePlegado = sistemaDePlegado;
            SistemaAutoequlibrado = sistemaautoequilibrado;
        }

        public ScotterElectrico()
        {
        }

        public void setScotter(string sistemaDePlegado, string sistemaautoequilibrado)
        {
            this.SistemaDePlegado = sistemaDePlegado;
            this.SistemaAutoequlibrado = sistemaautoequilibrado; ;
        }
        public string getScotter()
        {
            return " Sistema de plegado: " + SistemaDePlegado + " Sistema Auto Equlibrado: " + SistemaAutoequlibrado;
        }
    }
}
