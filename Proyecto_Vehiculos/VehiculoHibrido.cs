using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class VehiculoHibrido:TransporteTerrestre
    {
        //Metodo de la clase
        public void MotorElectricoConCombustion()
        {
            Console.WriteLine("Posee dos o mas motores de distinta alimentacion");
        }
        //Constructor Get y Set
        private int CantidadDeMotores;
        public VehiculoHibrido(int cantidadmotores)
        {
         CantidadDeMotores = cantidadmotores;
        }
        public void setVehiculoHibrido(int cantidadmotores)
        {
            this.CantidadDeMotores = cantidadmotores;
        }
        public string getVehiculoHibrido()
        {
            return " Cantidad de motores:  "+ CantidadDeMotores;
        }
        public VehiculoHibrido()
        {
        }
    }
}