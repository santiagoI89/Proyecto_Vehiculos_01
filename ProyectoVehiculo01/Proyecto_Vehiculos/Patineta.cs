﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Patineta:VehiculosDeTraccionHumana
    {
        public void TransportaUnaPersona()
        {

        }
        private string ReferenciaTabla;

        public Patineta(string referenciaTabla)
        {
            ReferenciaTabla = referenciaTabla;
        }
    }
}
