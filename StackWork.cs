using System;
using System.Collections;

public class Pilas
{
    public static void Main()
    {
        // Definimos la pila
        Stack miPila = new Stack();

        // Creamos el menú
        Console.WriteLine("Bienvenido a la aplicación de las pilas.");
        Console.WriteLine("\nElija una opción");

        string opcion = "";
        do
        {
            Console.WriteLine("\n-------Menú-------");
            Console.WriteLine("1. Añadir elemento a la pila");
            Console.WriteLine("2. Sacar elemento de la pila");
            Console.WriteLine("3. Longitud de la pila");
            Console.WriteLine("4. Mostrar la pila");
            Console.WriteLine("5. Salir");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AddPila(ref miPila);
                    break;

                case "2":
                    SacarDeLaPila(ref miPila);
                    break;

                case "3":
                    LongitudPila(ref miPila);
                    break;

                case "4":
                    EscribirPila(ref miPila);
                    break;

                case "5":
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("\nOpción incorrecta. Introduzca una opción entre 1 y 5");
                    break;
            }
        } while (opcion != "5");
    }

    public static void LongitudPila(ref Stack pila)
    {
        Console.WriteLine("\nLongitud de la pila: " + pila.Count);
    }

    public static void AddPila(ref Stack pila)
    {
       if (pila.Count < 10)
       { 
                Console.Write("\nIngrese valor: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                pila.Push(valor);
                EscribirPila(ref pila);
            }
            catch
            {
                Console.WriteLine("Error: Solo se permiten números.");
            }
        }
            else
        {
            Console.WriteLine("La pila ya contiene 10 elementos. No se pueden agregar más elementos.");
        }
    }
    public static void SacarDeLaPila(ref Stack pila)
    {
        if (pila.Count > 0)
        {
            int valor = (int)pila.Pop();
            Console.WriteLine("Elemento " + valor + " eliminado");
        }
        else
        {
            Console.WriteLine("La pila está vacía.");
        }
        EscribirPila(ref pila);
    }

    public static void EscribirPila(ref Stack pila)
    {
        if (pila.Count > 0)
        {
            Console.WriteLine("\nElementos en la pila:");
            foreach (int dato in pila)
            {
                Console.WriteLine("| " + dato + " |");
            }
        }
        else
        {
            Console.WriteLine("La pila está vacía.");
        }
    }
}


