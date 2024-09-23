using System;

namespace Tarea_1
{
    public class Estudiante
    {


        public int cantidad;

        public static void inicio()
        {
            int cantidad;

            Console.WriteLine("Ingrese la cantidad de Estudiantes que desea registrar:");
            cantidad = int.Parse(Console.ReadLine());

            string[] alumnos = new string[cantidad];
            int[] edad = new int[cantidad];
            Double[] promedio = new Double[cantidad];


            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el nombre de los Estudiantes:");
                alumnos[i] = Console.ReadLine();
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese la edad de: " + alumnos[i]);
                edad[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el promedio de: " + alumnos[i]);
                promedio[i] = Double.Parse(Console.ReadLine());
            }


            Console.WriteLine("+---------------------+--------------+");
            Console.WriteLine("|      --- Mostrando Datos ---       |");
            Console.WriteLine("+---------------------+--------------+");
            Console.WriteLine("Los Estudiantes Ingresados son los siguientes: ");
            Console.WriteLine(" ");

            for (int i = 0; i < cantidad; i++)
            {
                if (edad[i] >= 18)
                {
                    Console.WriteLine(alumnos[i] + " Tiene: " + edad[i] + " Años" + " Es mayor de edad " + " y su promedio es de: " + promedio[i]);
                }
                else
                {
                    Console.WriteLine(alumnos[i] + " Tiene: " + edad[i] + " Años" + " Es menor de edad " + " y su promedio es de: " + promedio[i]);
                }

            }

            Console.ReadLine();

        }

        public static void Menu()
        {
            bool salir = false;

            Console.WriteLine("1. INGRESAR DATOS DEL ESTUDIANTE");
            Console.WriteLine("2. MOSTRAR INFORMACION");
            Console.WriteLine("3. SALIR");

            Console.WriteLine("Elige una de las opciones");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Has elegido la opción 1");
                    inicio();
                    break;

                case 2:
                    Console.WriteLine("Has elegido la opción 2");
                    MostrarInfo();
                    break;
                case 3:
                    Console.WriteLine("Has elegido salir de la aplicación");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Elige una opcion entre 1 y 3");
                    break;
            }
        }

        public static void MostrarInfo()
        {

            Console.WriteLine("+---------------------+--------------+");
            Console.WriteLine("|      --- Mostrando Datos ---       |");
            Console.WriteLine("+---------------------+--------------+");
            Console.WriteLine("Los Estudiantes Ingresados son los siguientes: ");
            Console.WriteLine(" ");

            Console.ReadLine();
        }

    }
}