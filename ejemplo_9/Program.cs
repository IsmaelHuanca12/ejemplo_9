using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;
            int mayor;

            // Solicitar al usuario que ingrese los tres números
            Console.Write("Ingrese el primer número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            numero3 = int.Parse(Console.ReadLine());

            // Verificar si los tres números son diferentes
            if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
            {
                // Calcular el número mayor mediante comparaciones
                if (numero1 > numero2 && numero1 > numero3)
                {
                    mayor = numero1;
                }
                else if (numero2 > numero1 && numero2 > numero3)
                {
                    mayor = numero2;
                }
                else
                {
                    mayor = numero3;
                }

                // Mostrar el resultado
                Console.WriteLine($"El número mayor es: {mayor}");
            }
            else
            {
                // Mostrar mensaje de error si los números no son diferentes
                Console.WriteLine("Los tres números deben ser diferentes.");
            }

            // Esperar a que el usuario presione una tecla antes de cerrar
            Console.ReadKey();
        }
    }
}
