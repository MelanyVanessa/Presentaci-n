using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDADES.EJERCICIOS
{
    internal class GeneradorDeCorreosCorporativos
    {
        static void Main()
        {
            // Solicitar nombre y apellido
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            string apellido = Console.ReadLine();

            // Generar correo en minúsculas
            string correo = $"{nombre.ToLower()}.{apellido.ToLower()}@empresa.com";

            // Mostrar resultado
            Console.WriteLine("\n====================================");
            Console.WriteLine($"Su correo corporativo es: {correo}");
            Console.WriteLine("====================================");
        }

    }
}
