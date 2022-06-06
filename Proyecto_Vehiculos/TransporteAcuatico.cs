using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class TransporteAcuatico : Vehiculos
    {
        //Metodo de la clase
        public void Navegar()
        {
            Console.WriteLine("Se moviliza por el agua");
        }
        //Constructor Get y Set
        private int Ancla;
        private int CantidadCubierta;
        private int Proa;
        private int Quilla;
        private int Popa;
        public TransporteAcuatico(int ancla,int cantidacubiertas,int proa,int quilla, int popa)
        {
            Ancla = ancla;
            CantidadCubierta = cantidacubiertas;
            Proa = proa;
            Quilla = quilla;
            Popa = popa;
        }

        public TransporteAcuatico()
        {
        }

        public void setTransporteAcuatico(int ancla, int cantidacubiertas, int proa, int quilla, int popa)
        {
            this.Ancla = ancla;
            this.CantidadCubierta = cantidacubiertas;
            this.Proa = proa;
            this.Quilla = quilla;
            this.Popa = popa;
        }
        public string getTransporteAcuatico()
        {
            return "Ancla: " + Ancla + "  Cantidad Cubierta:  " + CantidadCubierta+ " Proa: "+ Proa + " \n  Quilla: "+ Quilla+ "  Popa: " + Popa;
        }
    }
}