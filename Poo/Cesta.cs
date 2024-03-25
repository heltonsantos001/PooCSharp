using System.Collections.Generic;

namespace Poo
{
    internal class Cesta
    {
       public List<Item> Itens { get; set; }

        public Cesta()
        {
             Itens = new List<Item>();   
        }

    }
}
 