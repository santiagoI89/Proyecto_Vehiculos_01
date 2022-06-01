using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class CarroElectrico:VehiculosElectricos
    {
        public void ConduccionAutomatica()
        {

        }
        private int CantidadCamaras360Grados { get; set; }

        public CarroElectrico(int cantidadCamaras360Grados)
        {
            CantidadCamaras360Grados = cantidadCamaras360Grados;
        }
    }
}
