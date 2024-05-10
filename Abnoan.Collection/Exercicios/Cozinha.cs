using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Collection.Exercicios
{
    public class Cozinha
    {
        public Queue<Pedido> filaDePedidos = new Queue<Pedido>();
        public Stack<Pedido> pilhaDePedidosProntos = new Stack<Pedido>();

        public void AdicionarPedidoNaFila(Pedido pedido)
        {
            filaDePedidos.Enqueue(pedido);
        }

        public void ProcessarPedido()
        {
            if (filaDePedidos.Count > 0)
            {
                var pedido = filaDePedidos.Dequeue();
                pedido.Preparar();
                pilhaDePedidosProntos.Push(pedido);
            }
            else
            {
                Console.WriteLine("Nenhum pedido para processar.");
            }
        }

        public void EntregarPedido()
        {
            if (pilhaDePedidosProntos.Count > 0)
            {
                var pedido = pilhaDePedidosProntos.Pop();
                Console.WriteLine($"Entregando: {pedido.Item} - {pedido.Quantidade}x");
            }
            else
            {
                Console.WriteLine("Nenhum pedido pronto para entregar.");
            }
        }
    }
}