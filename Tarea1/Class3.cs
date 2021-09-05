using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Capitulo3
    {
        public string esParOImpar(int numero)
        {
            if (numero % 2 > 0)
                return "Impar";
            else
                return "Par";
        }

        public string diaDelaSemana(int numero)
        {
            switch (numero)
            {
                case 1:
                    return "Domingo";
                case 2:
                    return "Lunes";
                case 3:
                    return "Martes";
                case 4:
                    return "Miércoles";
                case 5:
                    return "Jueves";
                case 6:
                    return "Viernes";
                case 7:
                    return "Sábado";
                default:
                    return "El numero digitado debe estar entre 1 y 7";

            }
        }
    }
}
