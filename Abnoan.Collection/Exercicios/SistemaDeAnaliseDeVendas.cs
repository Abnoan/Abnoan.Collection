using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Collection.Exercicios
{
    public class SistemaDeAnaliseDeVendas
    {
        public List<Produto> produtos = new List<Produto>();
        public List<Venda> vendas = new List<Venda>();

        public void ListarProdutosVendidos()
        {
            var produtosVendidos = vendas.Select(v => v.ProdutoId).Distinct().ToList();
            foreach (var produtoId in produtosVendidos)
            {
                var produto = produtos.FirstOrDefault(p => p.Id == produtoId);
                Console.WriteLine($"Produto: {produto.Nome}");
            }
        }

        public void ListarProdutosMaisVendidos()
        {
            var rankingProdutos = vendas.GroupBy(v => v.ProdutoId)
                                        .Select(g => new { ProdutoId = g.Key, Quantidade = g.Sum(v => v.Quantidade) })
                                        .OrderByDescending(r => r.Quantidade)
                                        .ToList();
            foreach (var item in rankingProdutos)
            {
                var produto = produtos.FirstOrDefault(p => p.Id == item.ProdutoId);
                Console.WriteLine($"Produto: {produto.Nome}, Quantidade: {item.Quantidade}");
            }
        }

        public void ListarVendasPorCategoria()
        {
            var vendasCategoria = vendas.Join(produtos, v => v.ProdutoId, p => p.Id, (v, p) => new { p.Categoria, v.Quantidade })
                                        .GroupBy(vp => vp.Categoria)
                                        .ToList();
            foreach (var categoria in vendasCategoria)
            {
                Console.WriteLine($"Categoria: {categoria.Key}, Vendas: {categoria.Sum(x => x.Quantidade)}");
            }
        }

        public void FiltrarVendasPorData(DateTime inicio, DateTime fim)
        {
            var vendasFiltradas = vendas.Where(v => v.Data >= inicio && v.Data <= fim).ToList();
            foreach (var venda in vendasFiltradas)
            {
                var produto = produtos.FirstOrDefault(p => p.Id == venda.ProdutoId);
                Console.WriteLine($"Data: {venda.Data.ToShortDateString()}, Produto: {produto.Nome}, Quantidade: {venda.Quantidade}");
            }
        }
    }
}