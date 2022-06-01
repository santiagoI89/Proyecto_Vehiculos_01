using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class TransporteAcuatico:Vehiculos
    {
        public void Navegar()
        {

        }
        private int Ancla;

        public TransporteAcuatico(int ancla,int cantidacubiertas,int proa,int quilla, int popa)
        {
            Ancla = ancla;
            CantidadCubierta = cantidacubiertas;
            Proa = proa;
            Quilla = quilla;
            Popa = popa;
        }

        private int CantidadCubierta;
        private int Proa;
        private int Quilla;
        private int Popa;
        

    }
}
