using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Collection.Exercicios
{
    public class Restaurante
    {
        public List<Pedido> pedidos = new List<Pedido>();
        public Dictionary<int, List<Pedido>> pedidosPorMesa = new Dictionary<int, List<Pedido>>();

        public void AdicionarPedido(int mesa, Pedido pedido)
        {
            if (!pedidosPorMesa.ContainsKey(mesa))
                pedidosPorMesa[mesa] = new List<Pedido>();
            pedidosPorMesa[mesa].Add(pedido);
            pedidos.Add(pedido);
        }

        public void ModificarPedido(int mesa, int indicePedido, Pedido novoPedido)
        {
            if (pedidosPorMesa.ContainsKey(mesa) && indicePedido < pedidosPorMesa[mesa].Count)
            {
                pedidosPorMesa[mesa][indicePedido] = novoPedido;
            }
        }

        public double CalcularTotalMesa(int mesa)
        {
            double total = 0;
            if (pedidosPorMesa.ContainsKey(mesa))
            {
                foreach (var pedido in pedidosPorMesa[mesa])
                {
                    total += pedido.CalcularTotal();
                }
            }
            return total;
        }
    }
}