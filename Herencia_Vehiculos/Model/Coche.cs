using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Vehiculos.Model
{
    class Coche : Vehiculo
    {

        public void Acelerar()
        {
            Console.WriteLine("Acelerando");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando");
        }

        public override void Conducir()
        {
            //Esto llama al metodo conducir de la clase padre 
            //base.Conducir();
            Console.WriteLine("Tomando las curvas");
        }
    }
}
