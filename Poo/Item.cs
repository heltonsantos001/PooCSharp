using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Item
    {

        private const int Padrao_quantidade = 1;

        private string _name;

        public string Name
        {
            get { return _name; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                   throw new ArgumentNullException("Nome esta vazio");
                }

                _name = value; 
            }
        }

        private int _quantidade;

        public int Quantidade
        {
            get { return _quantidade; }
            set 
            {
                if (value > 0) 
                { 
                    _quantidade = value; 
                }
            }
        }

        private decimal _preco;

        public decimal Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

        public Item()
        {
            this.Quantidade = Padrao_quantidade;
        }

        public Item(string name, decimal preco) : base()
        {
            this.Name = name;
            this.Preco = preco;
        }

        public static Item CriarBola() 
        {
            var bola = new Item();
            bola.Name = "futebol";
            bola.Preco = 150M;
            bola.Quantidade = 1;
            return bola;
        }

        


    }
}
