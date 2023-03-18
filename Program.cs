using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAhorcado
{
    class Program
    {
        static void Main()
        {
            const int CANT_MAX_PALABRAS = 20;
            string[] palabras = new string[CANT_MAX_PALABRAS];
            Random random = new Random();
            byte numeroPalabra, intentosRestantes = 8;
            char letra;
            bool salida = false;
            StringBuilder palabraAdivinar;
            StringBuilder palabraMostrar = new StringBuilder();
            StringBuilder letrasEquivocadas = new StringBuilder();

            RellenarPalabras(palabras);

            numeroPalabra = (byte) random.Next(0, 20);
            palabraAdivinar = new StringBuilder(palabras[numeroPalabra]);

            Presentacion(palabraAdivinar.Length, intentosRestantes); 
            
            for (int i = 0; i < palabraAdivinar.Length; i++)
            {
                palabraMostrar.Append("-");
            }

            while (!salida)
            {
                if (!palabraMostrar.ToString().Contains("-"))
                {
                    MostrarHorca(intentosRestantes);
                    Console.WriteLine($"¡Felicidades! Has acertado la palabra " +
                                      $"{palabraAdivinar}.");
                    salida = true;
                }
                else if (intentosRestantes == 0)
                {
                    MostrarHorca(intentosRestantes);
                    Console.WriteLine($"Lo siento, has perdido. " +
                                      $"La palabra era {palabraAdivinar}.");
                    salida = true;
                }
                else
                {
                    MostrarHorca(intentosRestantes);
                    Console.WriteLine($"Palabra oculta: {palabraMostrar}");
                    Console.WriteLine($"{intentosRestantes} intentos restantes. " +
                                      $"Letras equivocadas: {letrasEquivocadas}");

                    Console.Write("Ingrese una letra: ");
                    letra = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                    Console.WriteLine();

                    if (palabraAdivinar.ToString().Contains(letra))
                    {
                        StringBuilder siguienteMostrar = new StringBuilder("");

                        for (int i = 0; i < palabraAdivinar.Length; i++)
                        {
                            if (palabraAdivinar[i] == letra)
                            {
                                siguienteMostrar.Append(letra);
                            }
                            else
                            {
                                siguienteMostrar.Append(palabraMostrar[i]);
                            }
                        }
                        palabraMostrar = siguienteMostrar;
                        Console.Clear();
                    }
                    else
                    {
                        if (!letrasEquivocadas.ToString().Contains(letra))
                        {
                            letrasEquivocadas.Append(letra + " ");
                        }
                        intentosRestantes--;
                        Console.Clear();
                    }
                }
            }
            Console.WriteLine();
        }

        public static void RellenarPalabras(string[] palabrasAhorcado)
        {
            palabrasAhorcado[0] = "ESCANDINAVO";
            palabrasAhorcado[1] = "CRIMEN";
            palabrasAhorcado[2] = "CAMPANA";
            palabrasAhorcado[3] = "TRISTEZA";
            palabrasAhorcado[4] = "PROGENITOR";
            palabrasAhorcado[5] = "IMPUESTOS";
            palabrasAhorcado[6] = "BOSQUE";
            palabrasAhorcado[7] = "NERVIOSO";
            palabrasAhorcado[8] = "BRINDAR";
            palabrasAhorcado[9] = "MAQUINA";
            palabrasAhorcado[10] = "SENTENCIA";
            palabrasAhorcado[11] = "FICHAS";
            palabrasAhorcado[12] = "MINERO";
            palabrasAhorcado[13] = "SARDINA";
            palabrasAhorcado[14] = "TARJETA";
            palabrasAhorcado[15] = "TEMBLOR";
            palabrasAhorcado[16] = "CUADERNO";
            palabrasAhorcado[17] = "HELADERA";
            palabrasAhorcado[18] = "FLORERIA";
            palabrasAhorcado[19] = "EVAPORAR";
        }

        public static void MostrarHorca(int intentosRestantes)
        {
            switch (intentosRestantes)
            {
                case 7:
                    Console.WriteLine("----------");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("======");
                    Console.WriteLine();
                    break;

                case 6:
                    Console.WriteLine("----------");
                    Console.WriteLine("|      |  ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("======");
                    Console.WriteLine();
                    break;

                case 5:
                    Console.WriteLine("----------");
                    Console.WriteLine("|      |  ");
                    Console.WriteLine("|      0  ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("======");
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine("----------");
                    Console.WriteLine("|      |  ");
                    Console.WriteLine("|      0  ");
                    Console.WriteLine("|      |  ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("======");
                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine("----------");
                    Console.WriteLine("|      |  ");
                    Console.WriteLine("|      0  ");
                    Console.WriteLine("|     /|  ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("======");
                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine("----------");
                    Console.WriteLine("|      |  ");
                    Console.WriteLine("|      0  ");
                    Console.WriteLine("|     /|\\");
                    Console.WriteLine("|        ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("======");
                    Console.WriteLine();
                    break;

                case 1:
                    Console.WriteLine("----------");
                    Console.WriteLine("|      |  ");
                    Console.WriteLine("|      0  ");
                    Console.WriteLine("|     /|\\");
                    Console.WriteLine("|     /   ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("======");
                    Console.WriteLine();
                    break;

                case 0:
                    Console.WriteLine("----------");
                    Console.WriteLine("|      |  ");
                    Console.WriteLine("|      0  ");
                    Console.WriteLine("|     /|\\");
                    Console.WriteLine("|     / \\");
                    Console.WriteLine("|         ");
                    Console.WriteLine("======");
                    Console.WriteLine();
                    break;
            }
        }

        public static void Presentacion(int letras, int intentosRestantes)
        {
            Console.WriteLine("==================== El Ahoracado ====================\n");
            Console.WriteLine($"La palabra tiene {letras} letras y tienes " +
                              $"{intentosRestantes} intentos para adivinarla.");
            Console.WriteLine();
        }
    }
}
