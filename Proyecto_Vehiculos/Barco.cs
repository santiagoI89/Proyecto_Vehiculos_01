using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Barco:TransporteAcuatico
    {
        //Metodo de la clase
        public void PrenderMotor()
        {
            Console.WriteLine("Puede encender el motor dando paso al movimiento de aspas");
        }
        private string Forma;
        private int CantidadHelicesBarcos;
        //Constructor Get y Set Forma 
        public Barco(string forma)
        {
            Forma = forma;
        }
        public void setForma(string forma)
        {
            this.Forma = forma;
        }
        public string getForma()
        {
            return " Forma: "+this.Forma;
        }
        //Constructor Get y Set Cantidad de helices 
        public Barco(int cantidadHelicesBarcos)
        {
            CantidadHelicesBarcos = cantidadHelicesBarcos;
        }
        public void setCantidadHelicesBarcos(int cantidadHelicesBarcos)
        {
            this.CantidadHelicesBarcos = cantidadHelicesBarcos;
        }
        public string getCantidadHelicesBarcos()
        {
            return " Cantidad de eleces del barco: "+CantidadHelicesBarcos;
        }
        public Barco()
        {
        }
    }
}
