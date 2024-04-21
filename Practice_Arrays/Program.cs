using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-----> Menu de opciones <-----");
            Console.WriteLine("1. El abecedario.");
            Console.WriteLine("2. Matriz de promedio de notas.");
            Console.WriteLine("3. Numeros pares e impares.");
            Console.WriteLine("4. Matriz de 5x5.");
            Console.WriteLine("5. Tabla de multiplicar.");
            Console.WriteLine("6. Salir.");
            Console.WriteLine("Elige una opcion: ...");
            int input_user_opcion= int.Parse(Console.ReadLine());
            Dictionary<int, Action> menu_app = new Dictionary<int, Action>();
            menu_app[1] = Alphabeth;
            menu_app[2] = PointAverage;
            menu_app[3] = EvenAndOddNumbers;
            menu_app[4] = Matrix5x5;
            menu_app[5] = TableMultiplication;
            menu_app[0] = ExitApp;
            menu_app[input_user_opcion]();
            if (input_user_opcion != 0) Menu();
        }
        static void Alphabeth()
        {
            Console.Clear();
            Console.WriteLine("-----> Abecedario <-----");
            string[] abecedario = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Console.WriteLine("Las letras del abecedario son: ");
            for(int i =0; i< abecedario.Length; i++)
            {
                if (i < abecedario.Length - 1 ) Console.Write($"{abecedario[i]}, ");
                else Console.Write($"{abecedario[i]}.");
            }
            Console.ReadKey();
        }
        static void PointAverage() // Promedio de notas de cursos
        {
            Console.Clear();
            Console.WriteLine("-----> Promedio de notas en 3 cursos <-----");
            string[] cursos = { "Curso 1", "Curso 2", "Curso 3", "Curso 4", "Curso 5"};
            double[] promedio = new double[cursos.Length];
            int[,] notas_usuario_por_curso = new int[cursos.Length - 1 , cursos.Length];
            for(int i=0; i<cursos.Length; i++)
            {
                for(int j=0; j< cursos.Length - 1; j++)
                {
                    Console.WriteLine("Ingrese las 4 notas del " + cursos[i] );
                   int value = int.Parse(Console.ReadLine());
                   notas_usuario_por_curso[j, i] = value;
                }
            }

            for (int i = 0; i < cursos.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j < cursos.Length - 1; j++)
                {
                    sum += notas_usuario_por_curso[j, i];
                }
                promedio[i] = sum / 4;
            }
            for (int i = 0; i < cursos.Length; i++)
            {
                Console.WriteLine($"El promedio del {cursos[i]} es de: {promedio[i]}");
            }
            Console.ReadKey();
        }
        static void EvenAndOddNumbers() // Numeros pares e impares
        {
            Console.Clear();
            Console.WriteLine("-----> Numeros pares/impares <-----");
            int[] pares = new int[50];
            int[] impares = new int[50];
            int contadorPares = 0;
            int contadorImpares = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    pares[contadorPares] = i;
                    contadorPares++;
                }
                else
                {
                    impares[contadorImpares] = i;
                    contadorImpares++;
                }
            }

            Console.WriteLine("Numeros pares: ");
            for (int i = 0; i < contadorPares; i++)
            {
                Console.Write(pares[i] + ", ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Numeros impares: ");
            for (int i = 0; i < contadorImpares; i++)
            {
                Console.Write(impares[i] + ", ");
            }

            Console.ReadKey();
        }
        static void Matrix5x5()
        {
            Console.Clear();
            Console.WriteLine("-----> Suma de filas y columnas <-----");
            int[,] matriz = new int[5, 5];
            for(int i =0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    int input_user = int.Parse(Console.ReadLine());
                    matriz[i, j] = input_user;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                int fila = 0;
                for (int j = 0; j < 5; j++)
                {
                    // ? Sumamos las filas
                    fila += matriz[i, j];
                }
                Console.WriteLine($"La suma de la fila {i + 1} {fila}");
            }
            for (int j = 0; j < 5; j++)
            {
                int columna = 0;
                for (int i = 0; i < 5; i++)
                {
                    // ? Sumamos las columnas
                    columna += matriz[i, j];
                }
                Console.WriteLine($"La suma de la fila {j + 1} {columna}");
            }
            Console.ReadKey();
        }
        static void TableMultiplication()
        {
            Console.Clear();
            Console.WriteLine("Tabla de multiplicacion");
            int[,] tablaMultiplicar = new int[10, 10];

            // Llenar la matriz con las tablas de multiplicar
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tablaMultiplicar[i, j] = (i + 1) * (j + 1);
                }
            }

            // Imprimir la matriz
            Console.WriteLine("Tabla de multiplicar del 1 al 10:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tablaMultiplicar[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void ExitApp()
        {
            Console.Clear();
            Console.WriteLine("Gracias por utilizar la app!!!");
            Console.WriteLine("Persione cualquier letra para salir");
            Console.ReadKey();
        }
    }
}
