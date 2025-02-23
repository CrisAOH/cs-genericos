using System;
using System.Collections.Generic;

namespace EjemploList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion, indice;
            string alumno;

            List<string> Alumnos = new List<string>();

            do
            {
                Console.Clear();

                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Eliminar estudiante");
                Console.WriteLine("3. Mostrar estudiantes");
                Console.WriteLine("4. Buscar por nombre");

                Console.Write("Escoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingresa el nombre del alumno: ");
                        alumno = Console.ReadLine();

                        Alumnos.Add(alumno);
                        break;
                    case 2:
                        Console.Write("Ingrese el número del estudiante que quiera eliminar: ");
                        indice = Convert.ToInt32(Console.ReadLine());

                        indice--;

                        if (indice >= Alumnos.Count  || indice < 0)
                        {
                            Console.WriteLine("El Alumno no existe.");
                        } 
                        else
                        {
                            string alumnoEliminado = Alumnos[indice];
                            Alumnos.RemoveAt(indice);
                            Console.WriteLine("{0} se ha eliminado correctamente.", alumnoEliminado);
                        }

                        Console.Write("\nPresione cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;
                    case 3:
                        int i = 1;
                        foreach (string elemento in Alumnos)
                        {
                            Console.WriteLine("{0}. {1}", i++, elemento);
                        }

                        Console.Write("\nPresione cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;
                    case 4:
                        string encontrarAlumno;
                        int j;

                        Console.Write("Ingrese el nombre del estudiante a buscar: ");
                        alumno = Console.ReadLine();

                        if (Alumnos.IndexOf(alumno) >= 0)
                        {
                            encontrarAlumno = Alumnos[Alumnos.IndexOf(alumno)];
                            j = Alumnos.IndexOf(alumno) + 1;

                            Console.WriteLine("El estudiante {0} se encuentra en el número {1} de la lista.", encontrarAlumno, j);
                        } 
                        else
                        {
                            Console.WriteLine("El estudiante {0} no se encuentra en el sistema.");
                        }
                        Console.Write("\nPresione cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion >= 1 && opcion <= 4);
        }
    }
}
