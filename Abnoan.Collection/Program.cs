using Abnoan.Collection.Exercicios;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Ex 1
        Restaurante restaurante = new Restaurante();       

        restaurante.AdicionarPedido(1, new Pedido("Hamburger", 2, 28.99));
        restaurante.AdicionarPedido(1, new Pedido("Coca-Cola", 2, 5.50));
        restaurante.AdicionarPedido(2, new Pedido("Pizza Mussarela Grande", 1, 59));

        Console.WriteLine("Total da Mesa 1: $" + restaurante.CalcularTotalMesa(1));
        restaurante.ModificarPedido(1, 0, new Pedido("Cheeseburger", 2, 39.49));
        Console.WriteLine("Total da Mesa 1 após modificação: $" + restaurante.CalcularTotalMesa(1));

        #endregion

        #region Ex 2
        Cozinha cozinha = new Cozinha();

        var pedido1 = new Pedido("Hamburger", 2, 8.99);
        var pedido2 = new Pedido("Pizza", 1, 12.75);

        //Mesa 99 = Delivery
        restaurante.AdicionarPedido(99, new Pedido("Barca de Sushi", 1, 168.99));
        restaurante.AdicionarPedido(99, new Pedido("Hot Dog 60cm", 2, 50));

        cozinha.AdicionarPedidoNaFila(pedido1);
        cozinha.AdicionarPedidoNaFila(pedido2);

        cozinha.ProcessarPedido();
        cozinha.ProcessarPedido();

        cozinha.EntregarPedido();
        cozinha.EntregarPedido();

        #endregion

        #region Ex 3
        // Cria uma instância do sistema de análise de vendas
        SistemaDeAnaliseDeVendas sistema = new SistemaDeAnaliseDeVendas();

        // Populando a lista de produtos
        sistema.produtos.Add(new Produto { Id = 1, Nome = "Café", Categoria = "Bebidas", Preço = 2.50 });
        sistema.produtos.Add(new Produto { Id = 2, Nome = "Chá", Categoria = "Bebidas", Preço = 1.50 });
        sistema.produtos.Add(new Produto { Id = 3, Nome = "Bolo de Chocolate", Categoria = "Sobremesas", Preço = 3.00 });
        sistema.produtos.Add(new Produto { Id = 4, Nome = "Suco de Laranja", Categoria = "Bebidas", Preço = 3.00 });
        sistema.produtos.Add(new Produto { Id = 5, Nome = "Torta de Limão", Categoria = "Sobremesas", Preço = 2.75 });

        // Populando a lista de vendas
        sistema.vendas.Add(new Venda { ProdutoId = 1, Quantidade = 10, Data = new DateTime(2024, 5, 1) });
        sistema.vendas.Add(new Venda { ProdutoId = 1, Quantidade = 5, Data = new DateTime(2024, 5, 2) });
        sistema.vendas.Add(new Venda { ProdutoId = 2, Quantidade = 7, Data = new DateTime(2024, 5, 1) });
        sistema.vendas.Add(new Venda { ProdutoId = 3, Quantidade = 4, Data = new DateTime(2024, 5, 3) });
        sistema.vendas.Add(new Venda { ProdutoId = 4, Quantidade = 8, Data = new DateTime(2024, 5, 4) });
        sistema.vendas.Add(new Venda { ProdutoId = 5, Quantidade = 6, Data = new DateTime(2024, 5, 1) });

        // Chamando os métodos de análise
        Console.WriteLine("Produtos Vendidos:");
        sistema.ListarProdutosVendidos();

        Console.WriteLine("Produtos Mais Vendidos:");
        sistema.ListarProdutosMaisVendidos();

        Console.WriteLine("Vendas Por Categoria:");
        sistema.ListarVendasPorCategoria();

        Console.WriteLine("Filtrar Vendas por Data (1º de Maio de 2024 a 3 de Maio de 2024):");
        sistema.FiltrarVendasPorData(new DateTime(2024, 5, 1), new DateTime(2024, 5, 3));
        #endregion
    }
}