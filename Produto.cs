using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_.NET_Exercícios
{
        //classe produto
        public class Produto
        {
            public string? Nome { get; set; }
            public double Preço { get; set; }
            public string? Descrição { get; set; }

        }
    // criando o method Imprimir detalhes
    public static class ProdutoDetalhes
    {
        public static string ImprimirDetalhes(this Produto produto)
        {
            return $"Nome:{produto.Nome}\nPreço:{produto.Preço}\nDescrição: {produto.Descrição}";
        }


        //aplicando desconto
        public static double AplicarDesconto(this Produto produto, double percentualDesconto)
        {
            double desconto = produto.Preço * (percentualDesconto / 100);
            return produto.Preço - desconto;
        }



    }
}