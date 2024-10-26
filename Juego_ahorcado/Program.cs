using System;
using System.Collections.Generic;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        string[] palabras = { "programacion", "computadora", "desarrollador", "csharp", "software" };
        Random random = new Random();
        string palabra = palabras[random.Next(palabras.Length)];
        HashSet<char> letrasAdivinadas = new HashSet<char>();
        int intentosRestantes = 6;

        //Loop principal del juego
        while (intentosRestantes > 0)
        {
            Console.Clear();
            MostrarDibujo(intentosRestantes);
            MostrarProgreso(palabra, letrasAdivinadas);

            Console.Write("\nIntroduce una letra: ");
            char letra = Console.ReadKey().KeyChar;

            if (letrasAdivinadas.Contains(letra))
            {
                Console.WriteLine("\nYa has adivinado esa letra");
                Console.ReadKey();
                continue;
            }

            letrasAdivinadas.Add(letra);

            if (!palabra.Contains(letra))
            {
                intentosRestantes--;
                Console.WriteLine($"\nLetra incorrecta. Intentos restantes: {intentosRestantes}");
            }

            if (PalabraAdivinada(palabra, letrasAdivinadas))
            {
                Console.Clear();
                MostrarDibujo(intentosRestantes);
                Console.WriteLine($"\n¡Felicidades!  Has adivinado la palabra; {palabra}");
                break;
            }

            if (intentosRestantes == 0)
            {
                Console.Clear();
                MostrarDibujo(intentosRestantes);
                Console.WriteLine($"\nLo siento, has perdido. La palabra era: {palabra}");
            }

        }

        static void MostrarDibujo(int intentosRestantes)
        {
            string[] dibujo = {
                " +----+\n      |\n      |\n      |\n      ===",
                " +----+\n  O   |\n      |\n      |\n      ===",
                " +----+\n  O   |\n  |   |\n      |\n      ===",
                " +----+\n  O   |\n /|   |\n      |\n      ===",
                " +----+\n  O   |\n /|\\  |\n      |\n      ===",
                " +----+\n  O   |\n /|\\  |\n /    |\n      ===",
                " +----+\n  O   |\n /|\\  |\n / \\  |\n      ==="
            };
            Console.WriteLine(dibujo[6 - intentosRestantes]);
        }

        static void MostrarProgreso(string palabra, HashSet<char> letrasAdivinadas)
        {
            foreach (char c in palabra)
            {
                if (letrasAdivinadas.Contains(c))
                    Console.Write(c + " ");
                else
                    Console.Write("_ ");
            }
        }

        static bool PalabraAdivinada(string palabra, HashSet<char> letrasAdivinadas)
        {
            foreach (char c in palabra)
            {
                if (!letrasAdivinadas.Contains(c))
                    return false;
            }
            return true;
        }
    }
}
