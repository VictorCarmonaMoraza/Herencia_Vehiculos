using Herencia_Vehiculos.Model;
using System;

namespace Herencia_Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Avion
            Console.WriteLine("Probando el Avion");
            Avion miAvion = new Avion();
            miAvion.ArrancaMotor("tracatataadjgjsd");
            miAvion.Despegar();
            miAvion.Conducir();
            miAvion.Aterrizar();
            miAvion.PararMotor("Pudhfkjdfkh");

            Console.WriteLine("Probando el Coche");
            Console.WriteLine("");
            Coche miCoche = new Coche();
            miCoche.ArrancaMotor("tuuuuuuuuuuuttututututu");
            miCoche.Acelerar();
            miCoche.Conducir();
            miCoche.Frenar();
            miCoche.PararMotor("ppppppppp");

            Console.WriteLine("Polimorfismo");
            Vehiculo miVehiculo = miCoche;

            miVehiculo.Conducir();

            miVehiculo = miAvion;

            miVehiculo.Conducir();

        }
    }
}
