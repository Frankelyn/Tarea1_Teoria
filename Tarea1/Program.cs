using System;

namespace Tarea1
{

    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int opcion = 0;

            
            do
            {
                Console.WriteLine("Tarea 1 - Programación Aplicada I\n\n");
                Console.WriteLine("Elija la opcion:\n");
                Console.WriteLine("1) Ejercicios Capitulo 1");
                Console.WriteLine("2) Ejercicios Capitulo 2");
                Console.WriteLine("3) Ejercicios Capitulo 3");
                Console.WriteLine("4) Salir");

                entrada = Console.ReadLine();
                opcion = Convert.ToInt32(entrada);


                switch (opcion)
                {
                    case 1:
                        {
                            string entrada2;
                            int opcion2 = 0;

                            do
                            {                      
                                Console.WriteLine("Elija la opcion:\n");
                                Console.WriteLine("1) Ejercicio 1");
                                Console.WriteLine("2) Ejercicio 5");
                                Console.WriteLine("3) Atrás");

                                entrada2 = Console.ReadLine();
                                opcion2 = Convert.ToInt32(entrada2);

                                switch (opcion2)
                                {
                                    case 1:
                                        {
                                            Capitulo1 ejercicio1 = new Capitulo1();
                                            ejercicio1.ImprimirNombre();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Capitulo1 ejercicio5 = new Capitulo1();
                                            ejercicio5.ImprimirMasCosas();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Opcion no válida");
                                            Console.Beep();
                                            break;
                                        }
                                }
                            } while (opcion2 != 3);
                            break;
                        }                        

                    case 2:
                        {
                            string entrada3;
                            int opcion3 = 0;

                            do
                            {                                
                                Console.WriteLine("Elija la opcion:\n");
                                Console.WriteLine("1) Ejercicio 1");
                                Console.WriteLine("2) Ejercicio 3");
                                Console.WriteLine("3) Ejercicio 4");
                                Console.WriteLine("4) Ejercicio 5");
                                Console.WriteLine("5) Atrás");

                                entrada3 = Console.ReadLine();
                                opcion3 = Convert.ToInt32(entrada3);

                                switch (opcion3)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Capitulo2 ejercicio1 = new Capitulo2();
                                            float numLados;
                                            float logitudDeLado;
                                            float perimetro;
                                            string valor;

                                            Console.WriteLine("Ejercicio 1 - Calcular el perimetro de un poligono regular\n");
                                            
                                            Console.Write("Digite el numero de lados del poligono: ");
                                            valor = Console.ReadLine();
                                            numLados = Convert.ToSingle(valor);

                                            Console.Write("Digite la logitud de un lado del poligino: ");
                                            valor = Console.ReadLine();
                                            logitudDeLado = Convert.ToSingle(valor);

                                            perimetro = ejercicio1.perimetroPoligonoRegular(numLados, logitudDeLado);

                                            Console.WriteLine("\nEl perimetro del poligono es igual a {0}\n", perimetro);

                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Capitulo2 ejercicio3 = new Capitulo2();
                                            float angulo;
                                            float radianes;
                                            string valor2;

                                            Console.WriteLine("Ejercicio 3 - Convertir de grados a radianes\n");

                                            Console.Write("Digite el angulo a convertir: ");
                                            valor2 = Console.ReadLine();
                                            angulo = Convert.ToSingle(valor2);                                           

                                            radianes = ejercicio3.convertirGradosARadianes(angulo);

                                            Console.WriteLine("\nEl resultado en radianes es igual a {0} PI RAD \n", radianes);
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            Capitulo2 ejercicio4 = new Capitulo2();
                                            float grados;
                                            float farenheit;
                                            string valor3;

                                            Console.WriteLine("Ejercicio 4 - Convertir de grados Celsius a grados Farenheit\n");

                                            Console.Write("Digite la cantidad de grados Celsius a convertir: ");
                                            valor3 = Console.ReadLine();
                                            grados = Convert.ToSingle(valor3);

                                            farenheit = ejercicio4.convertirCelsiusAFarenheit(grados);

                                            Console.WriteLine("\nEl resultado en grados Farenheit es igual a {0} \n", farenheit);

                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.Clear();
                                            Capitulo2 ejercicio5 = new Capitulo2();
                                            double cantidadDolares;
                                            double euros;
                                            double parametroConversion;
                                            string valor4;

                                            Console.WriteLine("Ejercicio 5 - Convertir de Dólares a Euros\n");

                                            Console.Write("Digite la cantidad en Dólares a convertir: ");
                                            valor4 = Console.ReadLine();
                                            cantidadDolares = Convert.ToSingle(valor4);

                                            Console.Write("Digite la Tasa de cambio del día: ");
                                            valor4 = Console.ReadLine();
                                            parametroConversion = Convert.ToDouble(valor4);

                                            euros = ejercicio5.convertirDolaresAEuros(cantidadDolares, parametroConversion);

                                            Console.WriteLine("\nEl resultado en Euros es igual a {0} \n", euros);
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.Clear();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Opcion no válida");
                                            Console.Beep();
                                            break;
                                        }
                                }
                            } while (opcion3 != 5);
                            break;
                        }
                    case 3:
                        {
                            string entrada4;
                            int opcion4 = 0;

                            do
                            {
                                Console.WriteLine("Elija la opcion:\n");
                                Console.WriteLine("1) Ejercicio 1");
                                Console.WriteLine("2) Ejercicio 4");                               
                                Console.WriteLine("3) Atrás");

                                entrada4 = Console.ReadLine();
                                opcion4 = Convert.ToInt32(entrada4);

                                switch (opcion4)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Capitulo3 ejercicio1 = new Capitulo3();
                                            int numero;
                                            string tipoDeNumero;
                                            string valor5;

                                            Console.WriteLine("Ejercicio 1 - Hacer un programa que diga al usuario si un numero es par o impar\n");
                                            Console.Write("Digite el numero a evaluar: ");
                                            valor5 = Console.ReadLine();
                                            numero = Convert.ToInt32(valor5);

                                            tipoDeNumero = ejercicio1.esParOImpar(numero);

                                            Console.WriteLine("El numero {0} es {1}", numero, tipoDeNumero);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Capitulo3 ejercicio4 = new Capitulo3();
                                            int numero;
                                            string dia;
                                            string valor6;

                                            Console.WriteLine("Ejericio 4 - Introducir un numero entre 1 y 7 y devuelva el dia de la semana que conrresponde a ese numero\n");
                                            Console.Write("Digite un numero entre 1 y 7: ");
                                            valor6 = Console.ReadLine();
                                            numero = Convert.ToInt32(valor6);

                                            dia = ejercicio4.diaDelaSemana(numero);

                                            Console.WriteLine("El dia de la semana que conrresponde al numero {0} es {1}", numero, dia);
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Opcion no válida");
                                            Console.Beep();
                                            break;
                                        }
                                }
                            } while (opcion4 != 3);
                            break;
                        }
                    case 4:
                        {
                            break;
                        }

                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Opcion no valida");
                            Console.Beep();
                            break;
                        }

                }
            } while (opcion != 4);
            
        }
    }
}
