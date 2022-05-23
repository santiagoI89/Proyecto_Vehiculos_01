using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class VehiculosElectricos:TransporteTerrestre
    {
        public void ImplusoElectrico()
        {

        }
        int Baterias { get; set; }
        int MotorElectrico { get; set; }
        int Controlador { get; set; }
        char ConectividadMovil { get; set; }
        int Cargador { get; set; }
    }
}
