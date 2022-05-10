using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResposability
{
    public class Orcamento
    {
        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public double Valor { get; set; }
        public IList<Item> Itens { get; set; }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
