using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Capitulo2
    {

        public float perimetroPoligonoRegular(float NLados, float longitudLado)
        {
            return NLados * longitudLado;
        }

        public float convertirGradosARadianes(float grados)
        {
            return grados / 180;
        }

        public float convertirCelsiusAFarenheit(float celsius)
        {
            return (celsius * 1.8f) + 32;
        }

        public double convertirDolaresAEuros(double dolares, double tasaDeCambio)
        {
            return dolares * tasaDeCambio;
        }

    }
}
