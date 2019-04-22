using System;
using System.Collections;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilaEnteros = new Stack();

            pilaEnteros.Push(13);
            pilaEnteros.Push(80);
            pilaEnteros.Push(06);
            pilaEnteros.Push(45);
            pilaEnteros.Push(67);
            pilaEnteros.Push(345);
            pilaEnteros.Push(765);
            pilaEnteros.Push(2345);
            pilaEnteros.Push(346);

            foreach (Object item in pilaEnteros)
            {
                Console.WriteLine(item);
            }

            Queue colaEnteros = new Queue();

            colaEnteros.Enqueue(567);
            colaEnteros.Enqueue(876);
            colaEnteros.Enqueue(234);
            colaEnteros.Enqueue(765);
            colaEnteros.Enqueue(123);
            colaEnteros.Enqueue(987);
            colaEnteros.Enqueue(987);
            colaEnteros.Enqueue(543);
            colaEnteros.Enqueue(567);
            colaEnteros.Enqueue(345);

            foreach (Object items in colaEnteros)
            {
                Console.WriteLine(items);
            }

            Stack pilaCadena = new Stack();
            pilaCadena.Push("Ada");
            pilaCadena.Push("Eva");
            pilaCadena.Push("Ines");
            pilaCadena.Push("Juliana");
            pilaCadena.Push("Carolina");
            pilaCadena.Push("Maria");
            pilaCadena.Push("Camila");
            pilaCadena.Push("Verónica");
            pilaCadena.Push("Anabel");
            pilaCadena.Push("Ludmila");

            foreach (Object itemCadena in pilaCadena)
            {
                Console.WriteLine(itemCadena);
            }

            Queue colaCadena = new Queue();
            colaCadena.Enqueue("Aldo");
            colaCadena.Enqueue("Cristian");
            colaCadena.Enqueue("Marcos");
            colaCadena.Enqueue("Facundo");
            colaCadena.Enqueue("Mariano");
            colaCadena.Enqueue("Lucas");
            colaCadena.Enqueue("Leonardo");
            colaCadena.Enqueue("Marcelo");
            colaCadena.Enqueue("Pablo");
            colaCadena.Enqueue("Daniel");

            foreach (Object item in colaCadena)
            {
                Console.WriteLine(item);
            }






        }
    }
}
