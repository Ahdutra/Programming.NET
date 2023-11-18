namespace Prog_.NET_Exercícios
{
    class Program
    {

        static void Main()
        {
            //Produto
            Produto meuProduto = new Produto
            {
                Nome = "caderno",
                Preço = 20.00,
                Descrição = "caderno universitário 20 matérias",
            };
            //detalhes
            Console.WriteLine("Detalhes do Produto: \n" + meuProduto.ImprimirDetalhes);

            double percentualDesconto = 5.0;
            double precoComDesconto = meuProduto.AplicarDesconto(percentualDesconto);

            Console.WriteLine($"(\nDetalhes do Produto com {percentualDesconto}% de desconto:\n + $Preço com desconto: {precoComDesconto}:)");

        }
    }
}
