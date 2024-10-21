using System;

class Program
{
    static void Main()
    {
        int numero;

        do
        {
            Console.Write("Ingrese un número entre 1 y 10 (0 para salir): ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 1 && numero <= 10)
            {
                Console.WriteLine("Tabla de multiplicar del " + numero);
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(numero + " x " + i + " = " + (numero * i));
                }
            }
            else if (numero != 0)
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }

        } while (numero != 0);

        Console.WriteLine("Programa terminado.");
    }
}