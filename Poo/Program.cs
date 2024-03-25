using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Cesta cesta = new Cesta();

            Item camisa = new Item("camisa da nike", 150M);
            Item bola = new Item("bola de futebol", 50M);
           
            cesta.Itens.Add(bola);
            cesta.Itens.Add(camisa);

            foreach (var C in cesta.Itens)
            {
                Console.WriteLine($"{C.Name}: {C.Quantidade * C.Preco} ");
            }
            Console.ReadKey();
        }
    }
}
