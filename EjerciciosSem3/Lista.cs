using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSem3
{
    internal class Lista
    {
        public Nodo Primero { get; set; }
        public Nodo Ultimo { get; set; }

        public Lista()
        {
            this.Primero = null;
            this.Ultimo = null;
        }

        public void InsertarAlFinal(int dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = dato;
            nuevo.Siguiente = null;

            if (this.Primero == null)
            {
                nuevo.Anterior = null;
                this.Primero = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                nuevo.Anterior = Ultimo;
            }

            Ultimo = nuevo;
        }

        public void MostrarListaInicioAFin()
        {
            Nodo iterador = this.Primero;

            Console.WriteLine("Elemetos de la lista (inicio a fin): ");
            Console.Write("null->");
            while (iterador != null)
            {
                
                Console.Write(iterador.Dato);
                if (iterador.Siguiente != null)
                {
                    Console.Write("<->");
                }
                else
                {
                    Console.Write("->null");
                }
                iterador = iterador.Siguiente;
            }
            Console.WriteLine();
        }

        public void MostrarListaFinAInicio()
        {
            Nodo iterador = this.Ultimo;
            Console.WriteLine("Elemetos de la lista (fin a inicio): ");
            Console.Write("null->");
            while (iterador != null)
            {
                
                Console.Write(iterador.Dato);
                if (iterador.Anterior != null)
                {
                    Console.Write("<->");
                }
                else
                {
                    Console.Write("->null");
                }
                iterador = iterador.Anterior;
            }
            Console.WriteLine();
        }

        // EJERCICIO N°1
        public void Listar(bool esInicioAFin)
        {
            if (esInicioAFin)
                this.MostrarListaInicioAFin();
            else
                this.MostrarListaFinAInicio();
        }

        // EJERCICIO N°2
        public Lista Union(Lista lista2)
        {
            Nodo iterador = Primero;
            Lista union = new Lista();

            while (iterador != null)
            {
                union.InsertarAlFinal(iterador.Dato);
                iterador = iterador.Siguiente;
            }

            iterador = lista2.Primero;
            while (iterador != null)
            {
                union.InsertarAlFinal(iterador.Dato);
                iterador = iterador.Siguiente;
            }

            return union;
        }

        public bool ElementoPresente(int dato)
        {
            Nodo iterador = Primero;

            while (iterador != null)
            {
                if (dato == iterador.Dato)
                    return true;
                iterador = iterador.Siguiente;
            }

            return false;
        }

        public Lista Interseccion(Lista lista2)
        {
            Nodo iterador = Primero;
            Lista interseccion = new Lista();

            while (iterador != null)
            {
                if (lista2.ElementoPresente(iterador.Dato))
                    interseccion.InsertarAlFinal(iterador.Dato);
                iterador = iterador.Siguiente;
            }

            return interseccion;
        }

        public Lista Diferencia(Lista lista2)
        {
            Nodo iterador = Primero;
            Lista diferencia = new Lista();

            while (iterador != null)
            {
                if (!lista2.ElementoPresente(iterador.Dato))
                    diferencia.InsertarAlFinal(iterador.Dato);
                iterador = iterador.Siguiente;
            }

            iterador = lista2.Primero;
            while (iterador != null)
            {
                if (!ElementoPresente(iterador.Dato))
                    diferencia.InsertarAlFinal(iterador.Dato);
                iterador = iterador.Siguiente;
            }

            return diferencia;
        }

        // EJERCICIO N°3
        public int CantidadElementos()
        {
            Nodo iterador = this.Primero;
            int contador = 0;

            while (iterador != null)
            {
                contador++;
                iterador = iterador.Siguiente;
            }

            return contador;
        }

        public bool IgualdadListas(Lista lista2)
        {
            Nodo iteradorI = this.Primero;
            Nodo iteradorJ = lista2.Primero;

            while (iteradorI != null && iteradorJ != null)
            {
                if (iteradorI.Dato != iteradorJ.Dato)
                    return false;
                iteradorI = iteradorI.Siguiente;
                iteradorJ = iteradorJ.Siguiente;
            }

            return true;
        }

        public void Reporte(Lista lista2)
        {
            int cantidadElementosI = this.CantidadElementos();
            int cantidadElementosJ = lista2.CantidadElementos();

            if (cantidadElementosI == cantidadElementosJ)
            {
                if (this.IgualdadListas(lista2))
                    Console.WriteLine("Las listas son iguales en tamaño y contenido");
                else
                    Console.WriteLine("Las listas son iguales en tamaño, pero no en contenido");
            }
            else
            {
                Console.WriteLine("Las listas no tienen el mismo tamaño ni contenido");
            }
        }

        // EJERCICIO N°4
        public void InvertirLista()
        {
            Nodo iteradorI = this.Primero;
            Nodo iteradorJ = this.Ultimo;
            int i = 0, temporal;
            int cantidadElementos = this.CantidadElementos();

            if (cantidadElementos % 2 != 0)
            {
                while (iteradorI != iteradorJ)
                {
                    temporal = iteradorI.Dato;
                    iteradorI.Dato = iteradorJ.Dato;
                    iteradorJ.Dato = temporal;
                    iteradorI = iteradorI.Siguiente;
                    iteradorJ = iteradorJ.Anterior;
                }
            }
            else
            {
                while (i < cantidadElementos / 2)
                {
                    temporal = iteradorI.Dato;
                    iteradorI.Dato = iteradorJ.Dato;
                    iteradorJ.Dato = temporal;
                    iteradorI = iteradorI.Siguiente;
                    iteradorJ = iteradorJ.Siguiente;
                    i++;
                }
            }
        }

        // EJERCICIO N°5
        public int CantidadRepeticiones(int dato)
        {
            Nodo iterador = this.Primero;
            int contador = 0;

            while (iterador != null)
            {
                if (dato == iterador.Dato)
                    contador++;
                iterador = iterador.Siguiente;
            }

            return contador;
        }

        // EJERCICIO N°6
        public bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }

        public Lista GenerarListaAleatoria()
        {
            Lista listaAleatoria = new Lista();
            Random ran = new Random();

            for (int i = 0; i < 50; i++)
                listaAleatoria.InsertarAlFinal(ran.Next(1, 1001));

            return listaAleatoria;
        }

        public void EliminarElementoPosicionX(int posicionAEliminar)
        {
            Nodo iterador;
            int posicionActual = 1;
            int cantidadElementos = this.CantidadElementos();

            if (cantidadElementos != 1)
            {
                if (posicionActual == posicionAEliminar)
                {
                    if (cantidadElementos != 1)
                    {
                        this.Primero = this.Primero.Siguiente;
                        this.Primero.Anterior = null;
                    }
                    else
                    {
                        this.Primero = null;
                        this.Ultimo = null;
                    }
                }
                else
                {
                    iterador = this.Primero.Siguiente;
                    while (iterador != null)
                    {
                        posicionActual++;
                        if (posicionActual == posicionAEliminar)
                        {
                            if (posicionActual != cantidadElementos)
                            {
                                iterador.Anterior.Siguiente = iterador.Siguiente;
                                iterador.Siguiente.Anterior = iterador.Anterior;
                            }
                            else
                            {
                                iterador.Anterior.Siguiente = null;
                            }
                            break;
                        }
                        iterador = iterador.Siguiente;
                    }
                }
            }
            else
            {
                this.Primero = null;
                this.Ultimo = null;
            }
        }

        public void EliminarNumerosPrimos()
        {
            Nodo iterador = this.Primero;
            int posicion = 1;

            while (iterador != null)
            {
                if (this.EsPrimo(iterador.Dato))
                {
                    this.EliminarElementoPosicionX(posicion);
                }
                iterador = iterador.Siguiente;
                posicion++;
            }
        }
    }
}

