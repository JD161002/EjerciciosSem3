using System;

namespace EjerciciosSem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista1 = new Lista();
            Lista lista2 = new Lista();
            Lista listaAleatoria;

            int valor1, valor2;
            string opcion;

            do
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("1. Ingresar nuevo dato lista 1");
                Console.WriteLine("2. Ingresar nuevo dato lista 2");
                Console.WriteLine("3. Listar elementos de la lista 1 (inicio al fin)");
                Console.WriteLine("4. Listar elementos de la lista 1 (fin al inicio)");
                Console.WriteLine("5. Listar elementos de la lista 2 (inicio al fin)");
                Console.WriteLine("6. Listar elementos de la lista 2 (fin al inicio)");
                Console.WriteLine("7. Unión, intersección y diferencia de dos listas");
                Console.WriteLine("8. Reporte de examinación de dos listas");
                Console.WriteLine("9. Invertir lista");
                Console.WriteLine("10. Cantidad de repeticiones de un elemento");
                Console.WriteLine("11. Eliminar numeros primos (lista aleatoria)");
                Console.WriteLine("12. Salir");
                Console.Write("Ingrese una opción: ");
                opcion = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------");

               

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el valor a ingresa a la lista 1: ");
                        valor1 = int.Parse(Console.ReadLine());
                        lista1.InsertarAlFinal(valor1);
                        break;
                    case "2":
                        Console.Write("Ingrese el valor a ingresa a la lista 2: ");
                        valor1 = int.Parse(Console.ReadLine());
                        lista2.InsertarAlFinal(valor1);
                        break;
                    case "3":
                        lista1.Listar(true);
                        break;
                    case "4":
                        lista1.Listar(false);
                        break;
                    case "5":
                        lista2.Listar(true);
                        break;
                    case "6":
                        lista2.Listar(false);
                        break;
                    case "7":
                        Console.WriteLine("Unión: ");
                        lista1.Union(lista2).Listar(true);
                        Console.WriteLine("Intersección: ");
                        lista1.Interseccion(lista2).Listar(true);
                        Console.WriteLine("Diferencia: ");
                        lista1.Diferencia(lista2).Listar(true);
                        break;
                    case "8":
                        Console.WriteLine("Reporte: ");
                        lista1.Reporte(lista2);
                        break;
                    case "9":
                        Console.WriteLine("Lista 1 invertida");
                        lista1.InvertirLista();
                        lista1.Listar(true);
                        break;
                    case "10":
                        Console.Write("Ingrese el valor a buscar en la lista 1: ");
                        valor1 = int.Parse(Console.ReadLine());
                        valor2 = lista1.CantidadRepeticiones(valor1);
                        if (valor2 != 0)
                            Console.WriteLine("La cantidad de repeticiones del número " + valor1 + " es: " + valor2);
                        else
                            Console.WriteLine("El número " + valor1 + " no se encuentra presente en la lista");
                        break;
                    case "11":
                        Console.WriteLine("Lista aleatoria: ");
                        listaAleatoria = lista1.GenerarListaAleatoria();
                        listaAleatoria.Listar(true);
                        Console.WriteLine("Lista aleatoria sin números primos: ");
                        listaAleatoria.EliminarNumerosPrimos();
                        listaAleatoria.Listar(true);
                        break;
                    case "12":
                        Console.WriteLine("Thanks for usyng this program");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta, ingrese una opción válida");
                        break;
                }

                if (opcion != "1" && opcion != "2")
                {
                    Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                    Console.ReadKey();
                }
                Console.Clear();

            } while (opcion != "12");
        }
    }
}
