using System;
using System.Collections.Generic;

namespace Exercicio8_OrdenaNumeros
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("*********** ORDENA NUMEROS ******");
            OrdenaValores();
        }

        static void ImprimeListaOrdenada(List<int> lista)
        {

            Console.WriteLine("ORDENANDO...");
            //List<int> listaOrdenada = new List<int>();

            //listaOrdenada = OrdenaValores();

            lista.Sort();

            foreach (int valor in lista)
            {
                Console.Write(valor + " ");
            }

        }

        static void OrdenaValores()
        {
            int a, b, c, d, e, f, g, h, i, j;

            Console.WriteLine("Digite o primeiro valor: ");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Digit um valor inteiro, por favor");

            Console.WriteLine("Digite o segundo valor: ");
            while (!int.TryParse(Console.ReadLine(), out b))
                Console.WriteLine("Digit um valor inteiro, por favor");

            Console.WriteLine("Digite o terceiro valor: ");
            while (!int.TryParse(Console.ReadLine(), out c))
                Console.WriteLine("Digit um valor inteiro, por favor");

            Console.WriteLine("Digite o quarto valor: ");
            while (!int.TryParse(Console.ReadLine(), out d))
                Console.WriteLine("Digit um valor inteiro, por favor");

            Console.WriteLine("Digite o quinto valor: ");
            while (!int.TryParse(Console.ReadLine(), out e))
                Console.WriteLine("Digit um valor inteiro, por favor");

            Console.WriteLine("Digite o sexto valor: ");
            while (!int.TryParse(Console.ReadLine(), out f))
                Console.WriteLine("Digit um valor inteiro, por favor");

            Console.WriteLine("Digite o sétimo valor: ");
            while (!int.TryParse(Console.ReadLine(), out g))
                Console.WriteLine("Digit um valor inteiro, por favor");

            Console.WriteLine("Digite o oitavo valor: ");
            while (!int.TryParse(Console.ReadLine(), out h))
                Console.WriteLine("Digit um valor inteiro, por favor");

            Console.WriteLine("Digite o nono valor: ");
            while (!int.TryParse(Console.ReadLine(), out i))
                Console.WriteLine("Digit um valor inteiro, por favor");

            Console.WriteLine("Digite o decimo valor: ");
            while (!int.TryParse(Console.ReadLine(), out j))
                Console.WriteLine("Digit um valor inteiro, por favor");

            List<int> listaValores = new List<int>();
            listaValores.Add(a);
            listaValores.Add(b);
            listaValores.Add(c);
            listaValores.Add(d);
            listaValores.Add(e);
            listaValores.Add(f);
            listaValores.Add(g);
            listaValores.Add(h);
            listaValores.Add(i);
            listaValores.Add(j);

            ImprimeListaOrdenada(listaValores);
        }
    }
}
