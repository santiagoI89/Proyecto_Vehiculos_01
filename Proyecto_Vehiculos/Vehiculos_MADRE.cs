using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Vehiculos
    {
        //Metodo de la clase
        public void Transportar()
        {
            Console.WriteLine("Permite transportar personas o cosas");
        }
        public Vehiculos()
        {
        }
        //Constructor Get y Set
        private String NumeroDeSerie;
        private String Marca;
        private String Modelo;
        private String Color;
        private String TipoDeServicio;
        public Vehiculos(String tipoDeServicio, String color, String modelo, String marca, String numerodeserie)
        {
            TipoDeServicio = tipoDeServicio;
            Marca = marca;  
            Modelo = modelo;    
            Color = color;   
            NumeroDeSerie = numerodeserie;
        }
        public void setVehiculos(String tipoDeServicio, String color, String modelo, String marca, String numerodeserie)
        {
            this.TipoDeServicio = tipoDeServicio;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
            this.NumeroDeSerie = numerodeserie;
        }
        public String getVehiculos()
        {
            return " Tipo de servicio: "+ TipoDeServicio+" Marca: "+ Marca+ " Modelo: "+ Modelo+ "\n  Color: "+ Color+" Numero de serie: "+ NumeroDeSerie;
        }
        //Constructor Get y Set
        private int CapacidadPasajeros;
        private int CantidadConductores;
        public Vehiculos(int cantidadConductores, int Capacidadpasajeros)
        {
            CantidadConductores = cantidadConductores;
            CapacidadPasajeros = Capacidadpasajeros;
        }
        public void setVehiculosCapacidades(int cantidadConductores, int Capacidadpasajeros)
        {
            CantidadConductores = cantidadConductores;
            CapacidadPasajeros = Capacidadpasajeros;
        }
        public String getVehiculosCapacidades()
        {
            return " Cantidad de conductores:  " + CantidadConductores + " Capacidad de pasajeros:  " + CapacidadPasajeros;
        }
        //Constructor Get y Set
        private double Velocimetro;
        private double VelocidadMaxima;
        private double Tamaño; 
        private double Acelerador;
        private double Precio;
        public Vehiculos(double precio, double acelerador, double tamaño, double velocidadmaxima, double velocimetro)
        {
            Precio = precio;
            Acelerador = acelerador;
            Tamaño = tamaño;
            VelocidadMaxima = velocidadmaxima;
            Velocimetro = velocimetro;
        }
        public void setVehiculosExtras(double precio, double acelerador, double tamaño, double velocidadmaxima, double velocimetro)
        {
            Precio = precio;
            Acelerador = acelerador;
            Tamaño = tamaño;
            VelocidadMaxima = velocidadmaxima;
            Velocimetro = velocimetro;
        }
        public string getVehiculosExtras()
        {
            return " Precio:  " + Precio + " Acelerador:  " + Acelerador+ " Tamaño: "+Tamaño+" METROS"+" Velocidad Maxima: "+ VelocidadMaxima+" Velocimetro: "+ Velocimetro;
        }
    }
}