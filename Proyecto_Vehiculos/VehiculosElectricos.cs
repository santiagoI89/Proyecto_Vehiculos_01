using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class VehiculosElectricos:TransporteTerrestre
    {
        //Metodo de la clase
        public void ImplusoElectrico()
        {
            Console.WriteLine("Su alimentacion es dada por la electricidad ");
        }
        //Constructor Get y Set
        private int Baterias;
        private int MotorElectrico;
        private int Controlador;
        private int Cargador;
        public VehiculosElectricos(int baterias, int motorelectrico, int controlador, int cargador)
        {
            Baterias = baterias;
            MotorElectrico = motorelectrico;
            Controlador= controlador;
            Cargador=cargador;
        }
        public void setVehiculosElectricos(int baterias, int motorelectrico, int controlador, int cargador)
        {
            this.Baterias = baterias;
            this.MotorElectrico = motorelectrico;
            this.Controlador = controlador;
            this.Cargador = cargador; 
        }
        public string getVehiculosElectricos()
        {
            return " Baterias :  " + Baterias+ " Motor electrico: "+ MotorElectrico+ " Controlador: "+ Controlador+ " Cargador: "+ Cargador;
        }
        //Constructor Get y Set
        private string ConectividadMovil;
        public VehiculosElectricos(string conectividadMovil)
        {
            ConectividadMovil = conectividadMovil;
        }
        public void setVehiculosElectricosExtras(string conectividadMovil)
        {
            this.ConectividadMovil = conectividadMovil;
        }
        public string getVehiculosElectricosextras()
        {
            return " Conectividad movil:  " + ConectividadMovil ;
        }
        public VehiculosElectricos()
        {
        }
    }
}