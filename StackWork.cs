using System;
namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Opcion = "";
            //Creamos el array
            string[] Pila = new string[10];
            string Cadena = "";
            // Se inicializa la pila para poder trabajar con ella
            InicializarPila(Pila);
            do
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("MENÚ DE OPERACIONES CON UNA PILA DE DATOS");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1. Añadir elemento a la pila");
                Console.WriteLine("2. Sacar elemento de la pila");
                Console.WriteLine("3. Longitud de la pila");
                Console.WriteLine("4. Mostrar pila");
                Console.WriteLine("5. Salir");
                Console.WriteLine("");
                Console.Write("Opción seleccionada: ");
                Opcion = Console.ReadLine();
                switch (Opcion)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("");
                            Console.Write("Cadena: ");
                            Cadena = Console.ReadLine();
                        } while (Cadena == "");
                        AddPila(Cadena, Pila);
                        Console.WriteLine("");
                        break;
                    case "2":
                        Console.WriteLine("Cadena: " + SacarDeLaPila(Pila));
                        Console.WriteLine("");
                        break;
                    case "3":
                        Console.WriteLine("La pila contiene: " + LongitudPila(Pila) + " cadenas");
                        Console.WriteLine("");
                        break;
                    case "4":
                        EscribirPila(Pila);
                        Console.WriteLine("");
                        break;
                    default:
                        break;
                }
            } while (Opcion != "5");
        }
        public static void InicializarPila(string[] Pila)
        {
            for (int i = 0; i < Pila.Length; i++)
            {
                Pila[i] = "*";
            }
        }
        public static int LongitudPila(string[] Pila)
        {
            int contador = 0;
            foreach (string p in Pila)
            {
                if (p != "*")
                {
                    contador++;
                }
                else
                {
                    break;
                }
            }
            return contador;
        }
        public static bool EstaVaciaPila(string[] Pila)
        {
            return Pila[0] == "*";
        }
        public static bool EstaLlenaPila(string[] Pila)
        {  //Para saber cual es la ultima posicion y notificar que está llena. Lo hacemos con un length.
            return Pila[Pila.Length - 1] != "*";
        }
        public static void AddPila(string cadena, string[] Pila)
        {   //Aquí usamos la funcíón anterior para saber si está llena la pila.
            if (EstaLlenaPila(Pila))
            {   //Si es True, ponemos mensaje
                Console.WriteLine("Error.La pila esta llena.");
            }
            else
            {   //Si es false, tiramos de LongitudPila para saber cuál es la siguiente que tiene que escribir.
                Pila[LongitudPila(Pila)] = cadena;
            }
        }
        public static string SacarDeLaPila(string[] Pila)
        {
            string resultado = "";
            if (EstaVaciaPila(Pila))
            {   //Aquí vamos a mirar también si está vacía pila.
                Console.WriteLine("Error.La pila esta vacía.");
                return "";
            }
            else
            {
                resultado = Pila[LongitudPila(Pila) - 1];
                Pila[LongitudPila(Pila) - 1] = "*";
                return resultado;
            }
        }
        public static void EscribirPila(string[] Pila)
        {
            foreach (string p in Pila)
            {
                if (p != "*")
                {
                    Console.WriteLine(p);
                }
                else
                {
                    break;
                }
            }
        }
    }
}

/* Explicación Copilot:
 * ¡Por supuesto! Vamos a analizar tu código paso a paso para que puedas comprender cómo funciona y realizar cualquier mejora si es necesario.

Estructura General:
Inicialización de la Pila:

Se crea una pila con capacidad para 10 elementos.

Se inicializa la pila con el valor "*", indicando posiciones vacías.

Menú Interactivo:

Presenta opciones para añadir, eliminar, mostrar y medir la longitud de la pila.

Desglose de Funciones:
Función InicializarPila:
Inicializa la pila con el valor "*".

csharp
public static void InicializarPila(string[] Pila)
{
    for (int i = 0; i < Pila.Length; i++)
    {
        Pila[i] = "*";
    }
}
Función LongitudPila:
Cuenta el número de elementos en la pila que no son "*".

csharp
public static int LongitudPila(string[] Pila)
{
    int contador = 0;
    foreach (string p in Pila)
    {
        if (p != "*")
        {
            contador++;
        }
        else
        {
            break;
        }
    }
    return contador;
}
Función EstaVaciaPila:
Verifica si la pila está vacía.

csharp
public static bool EstaVaciaPila(string[] Pila)
{
    return Pila[0] == "*";
}
Función EstaLlenaPila:
Verifica si la pila está llena.

csharp
public static bool EstaLlenaPila(string[] Pila)
{
    return Pila[Pila.Length - 1] != "*";
}
Función AddPila:
Añade un elemento a la pila si hay espacio disponible.

csharp
public static void AddPila(string cadena, string[] Pila)
{
    if (EstaLlenaPila(Pila))
    {
        Console.WriteLine("Error. La pila está llena.");
    }
    else
    {
        Pila[LongitudPila(Pila)] = cadena;
    }
}
Función SacarDeLaPila:
Elimina el último elemento de la pila y lo devuelve.

csharp
public static string SacarDeLaPila(string[] Pila)
{
    string resultado = "";
    if (EstaVaciaPila(Pila))
    {
        Console.WriteLine("Error. La pila está vacía.");
        return "";
    }
    else
    {
        resultado = Pila[LongitudPila(Pila) - 1];
        Pila[LongitudPila(Pila) - 1] = "*";
        return resultado;
    }
}
Función EscribirPila:
Muestra los elementos de la pila.

csharp
public static void EscribirPila(string[] Pila)
{
    foreach (string p in Pila)
    {
        if (p != "*")
        {
            Console.WriteLine(p);
        }
        else
        {
            break;
        }
    }
}
Comentarios:
Estructura y Flujo: El código está bien estructurado y proporciona un buen flujo para manejar operaciones básicas de pila mediante un menú interactivo.

Posibles Mejoras: Podrías considerar manejar posibles excepciones cuando el usuario introduce datos no válidos para mejorar la robustez del programa.

¿Te gustaría que profundicemos en alguna función específica o añadir alguna característica adicional? 🚀

si por favor, no termino de entender esto: public static void AddPila(string cadena, string[] Pila) { if (EstaLlenaPila(Pila)) { Console.WriteLine("Error. La pila está llena."); } else { Pila[LongitudPila(Pila)] = cadena; } }
¡Claro! Vamos a desglosar la función AddPila paso a paso para que entiendas cómo funciona.

Función AddPila
La función AddPila tiene dos parámetros:

cadena: El elemento (una cadena de texto) que deseas añadir a la pila.

Pila: El array que representa la pila donde se van a almacenar las cadenas.

Código y Explicación:
csharp
public static void AddPila(string cadena, string[] Pila)
{
    if (EstaLlenaPila(Pila))
    {
        Console.WriteLine("Error. La pila está llena.");
    }
    else
    {
        Pila[LongitudPila(Pila)] = cadena;
    }
}
Verificación de si la pila está llena:

csharp
if (EstaLlenaPila(Pila))
{
    Console.WriteLine("Error. La pila está llena.");
}
La función EstaLlenaPila(Pila) se llama para comprobar si la pila ha alcanzado su capacidad máxima.

Si la pila está llena, se imprime un mensaje de error: "Error. La pila está llena." y no se añade el nuevo elemento.

Añadir un elemento a la pila:

csharp
else
{
    Pila[LongitudPila(Pila)] = cadena;
}
Si la pila no está llena (else), se llama a LongitudPila(Pila) para determinar la cantidad actual de elementos en la pila.

LongitudPila(Pila) devuelve el número de elementos no vacíos en la pila.

El nuevo elemento (cadena) se añade en la posición siguiente al último elemento no vacío.

Ejemplo:
Supongamos que Pila es una array de tamaño 10 y actualmente contiene 3 elementos: ["a", "b", "c", "*", "*", "*", "*", "*", "*", "*"].

Llamas a AddPila("d", Pila).

La función EstaLlenaPila(Pila) devuelve false porque la pila no está llena.

LongitudPila(Pila) devuelve 3 (ya que hay 3 elementos no vacíos).

Entonces, Pila[3] se establece en "d".

El array Pila se convierte en ["a", "b", "c", "d", "*", "*", "*", "*", "*", "*"].

Espero que esto aclare cómo funciona la función AddPila. ¿Te gustaría revisar alguna otra parte del código o profundizar en algún concepto adicional? 🚀

pero cómo pasa de Pila [2] a Pila [3]?
¡Buena pregunta! Vamos a desglosar cómo el código hace esa transición de Pila[2] a Pila[3] cuando se añade un nuevo elemento.

Estado inicial de la pila: Supongamos que Pila tiene tres elementos actualmente:

csharp
string[] Pila = { "a", "b", "c", "*", "*", "*", "*", "*", "*", "*" };
Llamada a AddPila: Queremos añadir el elemento "d" a la pila:

csharp
AddPila("d", Pila);
Verificación si la pila está llena:

csharp
if (EstaLlenaPila(Pila))
{
    Console.WriteLine("Error. La pila está llena.");
}
else
{
    Pila[LongitudPila(Pila)] = cadena;
}
Función EstaLlenaPila: Verifica si la última posición de la pila está ocupada. En nuestro ejemplo, la última posición es "*" por lo que la pila no está llena.

Función LongitudPila: Cuenta cuántos elementos no vacíos ("*") hay en la pila:

csharp
public static int LongitudPila(string[] Pila)
{
    int contador = 0;
    foreach (string p in Pila)
    {
        if (p != "*")
        {
            contador++;
        }
        else
        {
            break;
        }
    }
    return contador;
}
Iteración en LongitudPila:

Iteración 1: p = "a", contador = 1.

Iteración 2: p = "b", contador = 2.

Iteración 3: p = "c", contador = 3.

Iteración 4: p = "*", se encuentra un "*" y se rompe el bucle.

LongitudPila(Pila) devuelve 3.

Añadir el nuevo elemento:

csharp
Pila[LongitudPila(Pila)] = cadena;
Resultado: Pila[3] = "d".

Esto añade el elemento "d" en la posición Pila[3], pasando del estado:

csharp
{ "a", "b", "c", "*", "*", "*", "*", "*", "*", "*" }
al estado:

csharp
{ "a", "b", "c", "d", "*", "*", "*", "*", "*", "*" }
Resumen:
La función LongitudPila(Pila) cuenta cuántos elementos no vacíos hay en la pila. Luego, AddPila utiliza este valor para determinar la posición donde debe insertar el nuevo elemento, avanzando de Pila[2] a Pila[3] de manera eficiente.

¿Te ha quedado más claro ahora? ¿Te gustaría explorar algo más en el código? 🚀

entiendo eso, que está ocupada las tres primeras posiciones, pero no entiendo cómo se le ha indicado que pase a la siguiente
Perfecto, vamos a desglosarlo un poco más para entender cómo se determina que debe pasar a la siguiente posición:

Punto clave: Uso de LongitudPila
La clave está en la función LongitudPila(Pila). Esta función cuenta cuántos elementos no vacíos ("*" indica vacío) hay en la pila, y retorna este número.

Ejemplo detallado:
Estado inicial de Pila:

csharp
string[] Pila = { "a", "b", "c", "*", "*", "*", "*", "*", "*", "*" };
Llamada a AddPila("d", Pila):

csharp
AddPila("d", Pila);
Verificación si la pila está llena:

csharp
if (EstaLlenaPila(Pila))
{
    Console.WriteLine("Error. La pila está llena.");
}
else
{
    Pila[LongitudPila(Pila)] = cadena;
}
Cálculo en LongitudPila(Pila):

Primer ciclo: p = "a", contador = 1.

Segundo ciclo: p = "b", contador = 2.

Tercer ciclo: p = "c", contador = 3.

Cuarto ciclo: p = "*", se encuentra el * y se rompe el bucle.

csharp
public static int LongitudPila(string[] Pila)
{
    int contador = 0;
    foreach (string p in Pila)
    {
        if (p != "*")
        {
            contador++;
        }
        else
        {
            break;
        }
    }
    return contador;
}
La función LongitudPila devuelve 3, que es la cantidad de elementos ocupados en la pila antes del *.

Añadir el nuevo elemento:

csharp
Pila[3] = "d";
Cómo se determina la posición:
LongitudPila(Pila) devuelve 3, que es la primera posición vacía en la pila.

Añadir el nuevo elemento: La línea Pila[LongitudPila(Pila)] = cadena usa este valor (3) para determinar la posición en la que debe añadirse el nuevo elemento "d".

Resumen:
La función LongitudPila cuenta los elementos ocupados en la pila, devolviendo el índice de la siguiente posición disponible. Esta posición se utiliza luego en AddPila para añadir el nuevo elemento a la primera posición vacía.

Espero que esta explicación te aclare cómo se gestiona la transición a la siguiente posición en la pila. ¿Hay algo más que te gustaría discutir o algún otro aspecto que necesites aclarar? 🚀

entonces la instruccion de añadir, Cadena, está todo aquí: do { Console.WriteLine(""); Console.Write("Cadena: "); Cadena = Console.ReadLine(); } while (Cadena == ""); AddPila(Cadena, Pila); Console.WriteLine(""); break;
Exactamente, lo has entendido bien. La instrucción de añadir una nueva cadena a la pila se encuentra en ese bloque de código. Vamos a desglosarlo paso a paso:

Bloque de Código para Añadir una Cadena
csharp
do
{
    Console.WriteLine("");
    Console.Write("Cadena: ");
    Cadena = Console.ReadLine();
} while (Cadena == "");
AddPila(Cadena, Pila);
Console.WriteLine("");
break;
Explicación:
Bucle do-while para leer la cadena:

csharp
do
{
    Console.WriteLine("");
    Console.Write("Cadena: ");
    Cadena = Console.ReadLine();
} while (Cadena == "");
Entrada del usuario: Se solicita al usuario que introduzca una cadena.

Validación: El bucle do-while asegura que el usuario no introduzca una cadena vacía. Si el usuario introduce una cadena vacía, se le volverá a pedir que ingrese una cadena hasta que ingrese una válida.

Llamada a la función AddPila:

csharp
AddPila(Cadena, Pila);
Agregar la cadena a la pila: Una vez que se tiene una cadena válida, se llama a la función AddPila pasando la cadena introducida y la pila.

Internamente: AddPila verifica si la pila está llena. Si no está llena, añade la cadena en la siguiente posición vacía.

Salida de la operación:

csharp
Console.WriteLine("");
break;
Separación visual: Imprime una línea en blanco para separar visualmente la operación en la consola.

Salir del switch: El break finaliza el caso actual del switch, permitiendo que el flujo del programa continúe.

Resumen del Proceso:
Se solicita una cadena al usuario.

Se asegura que la cadena no esté vacía.

Se añade la cadena a la pila utilizando AddPila.

Se imprime una línea en blanco y se finaliza el caso en el menú.

Este bloque de código maneja de forma eficiente la entrada del usuario y la añade a la pila si la entrada es válida y la pila no está llena.

¿Hay algo más que te gustaría analizar o aclarar sobre este código? 🚀*/