using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IF + ELSE IF + ELSE STATEMENTS
            Console.WriteLine("Introduce un número: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro un número: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("X es mayor que Y");
            }
            else if (x == y)
            {
                Console.WriteLine("X e Y son iguales");
            }
            else
            {
                Console.WriteLine("Y es mayor que X");
            }

            Console.WriteLine("Introduce una edad: ");
            int edad_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otra edad: ");
            int edad_2 = Convert.ToInt32(Console.ReadLine());

            if (edad_1 >= 18 && edad_2 >= 18)
            {
                Console.WriteLine("Ambos son mayores de edad, pueden igresar.");
            }
            else if (edad_1 < 18 && edad_2 < 18)
            {
                Console.WriteLine("Ambos son menores, no pueden ingresar.");
            }
            else
            {
                Console.WriteLine("Uno de los dos es menor, solo puede ingresar la persona mayor de 18 años.");
            }
        }
    }
}
