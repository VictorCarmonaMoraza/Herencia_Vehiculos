using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Vehiculos.Model
{
    class Avion : Vehiculo
    {
        public void Aterrizar()
        {
            Console.WriteLine("Aterrizando");
        }

        public void Despegar()
        {
            Console.WriteLine("Despegando");
        }

        public override void Conducir()
        {
            //Esto llama al metodo conducir de la clase padre 
            //base.Conducir();
            Console.WriteLine("Surcando los cielos del globo");
        }
    }
}
