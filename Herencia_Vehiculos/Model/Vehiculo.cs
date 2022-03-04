using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Vehiculos.Model
{
    public class Vehiculo
    {
        public void ArrancaMotor(string sonidoVehiculoArranque)
        {
            Console.WriteLine($"Arranca el motor: {sonidoVehiculoArranque}");
        }

        public void PararMotor(string sonidoVehiculoParar)
        {
            Console.WriteLine($"Parando el motor: {sonidoVehiculoParar}");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Este es el codigo generico para el metodo conducir");
        }
    }
}
