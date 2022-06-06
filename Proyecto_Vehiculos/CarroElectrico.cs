using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class CarroElectrico:VehiculosElectricos
    {
        //Metodo de la clase
        public void ConduccionAutomatica()
        {
            Console.WriteLine("Permite una conduccion automatica");
        }
        //Constructor Get y Set
        private int CantidadCamaras360Grados;
        public CarroElectrico(int cantidadCamaras360Grados)
        {
            CantidadCamaras360Grados = cantidadCamaras360Grados;
        }

        public CarroElectrico()
        {
        }

        public void setCantidadCamaras360Grados(int cantidadCamaras360Grado)
        {
            this.CantidadCamaras360Grados = cantidadCamaras360Grado;
        }
        public string getCantidadCamaras360Grados()
        {
            return " Numero de camaras 360°: "+ CantidadCamaras360Grados;
        }
    }
}
