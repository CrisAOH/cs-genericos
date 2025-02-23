using System;
using System.Collections.Generic;

namespace EjemploDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string nombre;
            long numero;

            Dictionary<string, long> contactos = new Dictionary<string, long>();

            do
            {
                Console.Clear();

                Console.WriteLine("1. Añadir contacto");
                Console.WriteLine("2. Buscar contacto");
                Console.WriteLine("3. Eliminar contacto");
                Console.WriteLine("4. Mostrar contactos");
                Console.WriteLine("5. Actualizar contacto");

                Console.Write("\nEscoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();

                        Console.Write("Número: ");
                        numero = Convert.ToInt64(Console.ReadLine());

                        contactos.Add(nombre, numero);
                        Console.WriteLine("\n({0}) se ha agregado con éxito.", nombre);

                        Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Buscar contacto por nombre: ");
                        nombre= Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            Console.WriteLine("CONTACTO ENCONTRADO");
                            Console.WriteLine("{0}: {1}", nombre, contactos[nombre]);

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("No se ha encontrado ningún contacto.");
                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        Console.Write("Contacto a eliminar: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            contactos.Remove(nombre);
                            Console.WriteLine("\n{0} ha sido eliminado con éxito.", nombre);

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("No se ha encontrado ningún contacto.");
                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Contactos en tu agenda: \n");
                        foreach (KeyValuePair<string, long> elemento in contactos)
                        {
                            Console.WriteLine("{0}: {1}", elemento.Key, elemento.Value);
                        }
                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("Contacto a editar: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            Console.Write("Ingrese el nuevo número telefónico de {0}: ", nombre);
                            numero = Convert.ToInt64(Console.ReadLine());
                            contactos[nombre] = numero;

                            Console.WriteLine("\nEl número telefónico de {0} ha sido actualizado.", nombre);
                            Console.WriteLine("{0}: {1}", nombre, contactos[nombre]);

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("No se ha encontrado ningún contacto.");
                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        break;
                }
            }
            while (opcion >= 1 && opcion <= 5);
        }
    }
}
