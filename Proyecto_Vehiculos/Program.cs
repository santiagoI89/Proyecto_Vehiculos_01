using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                Vehiculos mivehiculo = new Vehiculos();
                mivehiculo.setVehiculos(" Publico", " negro", " 2021", " KIA", " 1525gg5f2f52");
                mivehiculo.setVehiculosCapacidades(2, 4);
                mivehiculo.setVehiculosExtras(12500, 1, 2.5 * 4, 180, 2);
                Console.WriteLine(mivehiculo.getVehiculos());
                Console.WriteLine(mivehiculo.getVehiculosCapacidades());
                Console.WriteLine(mivehiculo.getVehiculosExtras());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                TransporteAcuatico mitransporteAcuatico = new TransporteAcuatico();
                mitransporteAcuatico.setTransporteAcuatico(1, 3, 1, 1, 1);
                mitransporteAcuatico.setVehiculos(" Privado", " Blanco", " Bote halcon", " mobey", " 22ff25s2");
                mitransporteAcuatico.setVehiculosCapacidades(2, 26);
                mitransporteAcuatico.setVehiculosExtras(35000, 2, 20 * 25, 60, 1);
                Console.WriteLine(mitransporteAcuatico.getVehiculos());
                Console.WriteLine(mitransporteAcuatico.getVehiculosCapacidades());
                Console.WriteLine(mitransporteAcuatico.getVehiculosExtras());
                Console.WriteLine(mitransporteAcuatico.getTransporteAcuatico());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                TransporteAereo mitransporteaereo = new TransporteAereo();
                mitransporteaereo.setTransporteAereo(1, 1, 2, 4, 1);
                mitransporteaereo.setVehiculos(" Publico", " Blanco", " Boeing 737", " Boeing", " 1g52f5f2f");
                mitransporteaereo.setVehiculosCapacidades(2, 196);
                mitransporteAcuatico.setVehiculosExtras(120000, 2, 32 * 25, 380, 2);
                Console.WriteLine(mitransporteaereo.getVehiculos());
                Console.WriteLine(mitransporteaereo.getVehiculosCapacidades());
                Console.WriteLine(mitransporteaereo.getVehiculosExtras());
                Console.WriteLine(mitransporteaereo.getTransporteAereo());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                TransporteTerrestre mitranspórteterrestre = new TransporteTerrestre();
                mitranspórteterrestre.setTransporteTerrestre(4, 11);
                mitranspórteterrestre.setVehiculos(" Privado", " Rojo", " 2004", " Renault", " 15d42s4d8s5d");
                mitranspórteterrestre.setVehiculosCapacidades(1, 4);
                mitranspórteterrestre.setVehiculosExtras(6000, 1, 4 * 2.5, 150, 1);
                Console.WriteLine(mitranspórteterrestre.getVehiculos());
                Console.WriteLine(mitranspórteterrestre.getVehiculosCapacidades());
                Console.WriteLine(mitranspórteterrestre.getVehiculosExtras());
                Console.WriteLine(mitranspórteterrestre.getTransporteTerrestre());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                Barco mibarco = new Barco();
                mibarco.setTransporteAcuatico(1, 1, 1, 1, 1);
                mibarco.setForma(" Buque");
                mibarco.setCantidadHelicesBarcos(2);
                mibarco.setVehiculos(" Proviedad", " Blanco", " 2015", " Hyunday", " 5f5fg5g");
                mibarco.setVehiculosCapacidades(1, 13);
                mibarco.setVehiculosExtras(120500, 2, 32 * 25, 380, 2);
                Console.WriteLine(mibarco.getVehiculos());
                Console.WriteLine(mibarco.getVehiculosCapacidades());
                Console.WriteLine(mibarco.getVehiculosExtras());
                Console.WriteLine(mibarco.getCantidadHelicesBarcos());
                Console.WriteLine(mibarco.getForma());
                Console.WriteLine(mibarco.getTransporteAcuatico());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                Velero mivelero = new Velero();
                mivelero.setTransporteAcuatico(2, 1, 1, 1, 1);
                mivelero.setVelero(" Velico Tradicional");
                mivelero.setVehiculos(" Privado", " Blanco", " Yate mvb", " Boeing", " efef5ef5e2252525");
                mivelero.setVehiculosCapacidades(1, 10);
                mivelero.setVehiculosExtras(30000, 0, 2 * 15, 32, 0);
                Console.WriteLine(mivelero.getVehiculos());
                Console.WriteLine(mivelero.getVehiculosCapacidades());
                Console.WriteLine(mivelero.getVehiculosExtras());
                Console.WriteLine(mivelero.getVelero());
                Console.WriteLine(mivelero.getTransporteAcuatico());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                Avion miavion = new Avion();
                miavion.setTransporteAereo(2, 1, 2, 4, 1);
                miavion.setAlas(2);
                miavion.setVehiculos("Publico", "Blanco", "Boeing 737", "Boeing", "1g52f5f2f");
                miavion.setVehiculosCapacidades(2, 196);
                miavion.setVehiculosExtras(120000, 2, 32 * 25, 380, 2);
                Console.WriteLine(miavion.getVehiculos());
                Console.WriteLine(miavion.getVehiculosCapacidades());
                Console.WriteLine(miavion.getVehiculosExtras());
                Console.WriteLine(miavion.getAlas());
                Console.WriteLine(miavion.getTransporteAereo());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                Helicoptero mihelicoptero = new Helicoptero();
                mihelicoptero.setTransporteAereo(10, 2, 1, 8, 2);
                mihelicoptero.setHelicoptero(2, 2);
                mihelicoptero.setVehiculos("Publico", "negro", "Boeing", "Boeg", "gr3i3h3n3223");
                mihelicoptero.setVehiculosCapacidades(2, 12);
                mihelicoptero.setVehiculosExtras(19000, 1, 25 * 8, 100, 3);
                Console.WriteLine(mihelicoptero.getVehiculos());
                Console.WriteLine(mihelicoptero.getVehiculosCapacidades());
                Console.WriteLine(mihelicoptero.getVehiculosExtras());
                Console.WriteLine(mihelicoptero.getHelicoptero());
                Console.WriteLine(mihelicoptero.getTransporteAereo());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                VehiculosDeCombustion mivehiculodecombustion = new VehiculosDeCombustion();
                mivehiculodecombustion.setVehiculosCombustion(45);
                mivehiculodecombustion.setVehiculosCombustionExtras(2);
                mivehiculodecombustion.setVehiculos("Publico", "Blanco", "Boeing 737", "Boeing", "1g52f5f2f");
                mivehiculodecombustion.setVehiculosCapacidades(2, 196);
                mivehiculodecombustion.setVehiculosExtras(120000, 2, 32 * 25, 380, 2);
                Console.WriteLine(mivehiculodecombustion.getVehiculos());
                Console.WriteLine(mivehiculodecombustion.getVehiculosCapacidades());
                Console.WriteLine(mivehiculodecombustion.getVehiculosExtras());
                Console.WriteLine(mivehiculodecombustion.getVehiculosCombustion());
                Console.WriteLine(mivehiculodecombustion.getVehiculosCombustionExtras());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();


                VehiculoHibrido mivehiculohibrido = new VehiculoHibrido();
                mivehiculohibrido.setVehiculoHibrido(2);
                mivehiculohibrido.setVehiculos("Publico", "Negro", "Prius", "Toyota", "23gh434");
                mivehiculohibrido.setVehiculosCapacidades(1, 5);
                mivehiculohibrido.setVehiculosExtras(120000, 2, 32 * 25, 380, 2);
                Console.WriteLine(mivehiculohibrido.getVehiculos());
                Console.WriteLine(mivehiculohibrido.getVehiculosCapacidades());
                Console.WriteLine(mivehiculohibrido.getVehiculosExtras());
                Console.WriteLine(mivehiculohibrido.getVehiculoHibrido());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                VehiculosElectricos mivehiculoselectricos = new VehiculosElectricos();
                mivehiculoselectricos.setVehiculosElectricos(3, 1, 2, 1);
                mivehiculoselectricos.setVehiculosExtras(10.5500, 2, 12.89, 256.8, 2);
                mivehiculoselectricos.setVehiculos("Publico", "Rojo", "Model S", "Tesla", "js43k89");
                mivehiculoselectricos.setVehiculosCapacidades(1, 6);
                mivehiculoselectricos.setVehiculosExtras(120000, 2, 32 * 25, 380, 2);
                Console.WriteLine(mivehiculoselectricos.getVehiculos());
                Console.WriteLine(mivehiculoselectricos.getVehiculosCapacidades());
                Console.WriteLine(mivehiculoselectricos.getVehiculosExtras());
                Console.WriteLine(mivehiculoselectricos.getVehiculosElectricos());
                Console.WriteLine(mivehiculoselectricos.getVehiculosExtras());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();


                VehiculosDeTraccionHumana mivehiculosdetraccionhumana = new VehiculosDeTraccionHumana();
                mivehiculosdetraccionhumana.setFuerzaMuscularHumana(156);
                mivehiculosdetraccionhumana.setVehiculos("Publico", "Negra", "Skate Power", "Peralta", "dn12l32");
                mivehiculosdetraccionhumana.setVehiculosCapacidades(1, 1);
                mivehiculosdetraccionhumana.setVehiculosExtras(12000, 2, 32 * 25, 380, 2);
                Console.WriteLine(mivehiculosdetraccionhumana.getVehiculos());
                Console.WriteLine(mivehiculosdetraccionhumana.getVehiculosCapacidades());
                Console.WriteLine(mivehiculosdetraccionhumana.getVehiculosExtras());
                Console.WriteLine(mivehiculosdetraccionhumana.getFuerzaMuscularHumana());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                Bus mibus = new Bus();
                mibus.setRuta("Troncla americas");
                mibus.setParaderos("Banderas, Biblioteca el tintal");
                mibus.setNumeroVagones(4);
                mibus.setVehiculos("Publico", "Blanco", "LO 916", "Mercedes Benz", "8765dbds");
                mibus.setVehiculosCapacidades(1, 80);
                mibus.setVehiculosExtras(120000, 2, 32 * 25, 380, 2);
                Console.WriteLine(mibus.getVehiculos());
                Console.WriteLine(mibus.getVehiculosCapacidades());
                Console.WriteLine(mibus.getVehiculosExtras());
                Console.WriteLine(mibus.getParaderos());
                Console.WriteLine(mibus.getNumeroVagones());
                Console.WriteLine(mibus.getRuta());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                CarroDeCombustible micarrodecombustible = new CarroDeCombustible();
                micarrodecombustible.setNumeroDeRevoluciones(1800);
                micarrodecombustible.setVelocidadRespostaje(0);
                micarrodecombustible.setVehiculos("Publico", "Blanco", "Toyota Prado", "Toyota", "jdjd7w221");
                micarrodecombustible.setVehiculosCapacidades(1, 8);
                micarrodecombustible.setVehiculosExtras(120000, 2, 32 * 25, 380, 2);
                Console.WriteLine(micarrodecombustible.getVehiculos());
                Console.WriteLine(micarrodecombustible.getVehiculosCapacidades());
                Console.WriteLine(micarrodecombustible.getVehiculosExtras());
                Console.WriteLine(micarrodecombustible.getNumeroDeRevoluciones());
                Console.WriteLine(micarrodecombustible.getVelocidadRespostaje());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                Moto mimoto = new Moto();
                mimoto.setCilindraje(3);
                mimoto.setVehiculos("Publico", "Rosada", "Akt 125", "Akt", "hdy2367hd");
                mimoto.setVehiculosCapacidades(1, 2);
                mimoto.setVehiculosExtras(120000, 2, 32 * 25, 380, 2);
                Console.WriteLine(mimoto.getVehiculos());
                Console.WriteLine(mimoto.getVehiculosCapacidades());
                Console.WriteLine(mimoto.getVehiculosExtras());
                Console.WriteLine(mimoto.getCilindraje());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                VehiculoDeCarga mivehiculodecarga = new VehiculoDeCarga();
                mivehiculodecarga.setVehiculoDeCarga(120);
                mivehiculodecarga.setVehiculos("Publico", "Blanco", "Delibery 197", "Volkswagen", "kdj32f2f");
                mivehiculodecarga.setVehiculosCapacidades(1, 2);
                mivehiculodecarga.setVehiculosExtras(120000, 2, 32 * 25, 380, 2);
                Console.WriteLine(mivehiculodecarga.getVehiculos());
                Console.WriteLine(mivehiculodecarga.getVehiculosCapacidades());
                Console.WriteLine(mivehiculodecarga.getVehiculosExtras());
                Console.WriteLine(mivehiculodecarga.getVehiculoDeCarga());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                AutoHibrido miautohibrido = new AutoHibrido();
                miautohibrido.setReferenciasDeMotoresCompatibles("Biocumbustibles");
                miautohibrido.setVehiculos("Publico", "Blanco", "Accord", "Honda", "32f5f2f");
                miautohibrido.setVehiculosCapacidades(1, 5);
                miautohibrido.setVehiculosExtras(120000, 2, 32 * 25, 380, 2);
                Console.WriteLine(miautohibrido.getVehiculos());
                Console.WriteLine(miautohibrido.getVehiculosCapacidades());
                Console.WriteLine(miautohibrido.getVehiculosExtras());
                Console.WriteLine(miautohibrido.getReferenciasDeMotoresCompatibles());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                CarroElectrico micarroelectrico = new CarroElectrico();
                micarroelectrico.setCantidadCamaras360Grados(2);
                micarroelectrico.setVehiculos("Publico", "Azul", "Model S", "Tesla", "f2f");
                micarroelectrico.setVehiculosCapacidades(1, 8);
                micarroelectrico.setVehiculosExtras(120000, 2, 32 * 25, 380, 2);
                Console.WriteLine(micarroelectrico.getVehiculos());
                Console.WriteLine(micarroelectrico.getVehiculosCapacidades());
                Console.WriteLine(micarroelectrico.getVehiculosExtras());
                Console.WriteLine(micarroelectrico.getCantidadCamaras360Grados());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                ScotterElectrico miscotterelectrico = new ScotterElectrico();
                miscotterelectrico.setScotter("Plegado Simple", "Uniciclo autobalanceado");
                miscotterelectrico.setVehiculos("Publico", "Blanco", "Mi Scooter Escencial", "Xiaomi", "f5f2f");
                miscotterelectrico.setVehiculosCapacidades(1, 1);
                miscotterelectrico.setVehiculosExtras(120000, 2, 32 * 25, 380, 2);
                Console.WriteLine(miscotterelectrico.getVehiculos());
                Console.WriteLine(miscotterelectrico.getVehiculosCapacidades());
                Console.WriteLine(miscotterelectrico.getVehiculosExtras());
                Console.WriteLine(miscotterelectrico.getScotter());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                Bicicleta mibicicleta = new Bicicleta();
                mibicicleta.setReferenciaMarco("558ff5d5d");
                mibicicleta.setGuardabarros(12030);
                mibicicleta.setVehiculos("Publico", "Blanco", "Shimano 232", "Shimano", "2f5f2f");
                mibicicleta.setVehiculosCapacidades(1, 1);
                mibicicleta.setVehiculosExtras(120000, 2, 32 * 25, 380, 2);
                Console.WriteLine(mibicicleta.getVehiculos());
                Console.WriteLine(mibicicleta.getVehiculosCapacidades());
                Console.WriteLine(mibicicleta.getVehiculosExtras());
                Console.WriteLine(mibicicleta.getReferenciaMarco());
                Console.WriteLine(mibicicleta.getGuardabarros());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();

                Patineta mipatineta = new Patineta();
                mipatineta.setReferenciaTabla("5H5F6F2F");
                mipatineta.setVehiculos("Publico", "Naranja", "Mi Patinteta 780", "Xiaomi", "1g52");
                mipatineta.setVehiculosCapacidades(1, 11);
                mipatineta.setVehiculosExtras(120000, 2, 32 * 25, 380, 2);
                Console.WriteLine(mipatineta.getVehiculos());
                Console.WriteLine(mipatineta.getVehiculosCapacidades());
                Console.WriteLine(mipatineta.getVehiculosExtras());
                Console.WriteLine(mipatineta.getReferenciaTabla());
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();
            }
        }
    }
}