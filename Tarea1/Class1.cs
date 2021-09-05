using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Capitulo1
    {
        public void ImprimirNombre()
        {
            Console.WriteLine("Nombre: Frankelyn García");
        }

        public void ImprimirNombre(string otroNombre)
        {
            Console.WriteLine("Mas cosas: {0}\n", otroNombre);
        }
        
        public void ImprimirMasCosas()
        {
            ImprimirNombre();
            ImprimirNombre("Nelson");
            ImprimirNombre("Universidad Catolica Nordestana");
            ImprimirNombre("Quiero aprender a Programar");
            ImprimirNombre("Aplicada es una asignatura interesante");

        }
    }
}
