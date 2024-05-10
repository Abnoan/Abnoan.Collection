using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Collection.Exercicios
{
public class Pedido
{
    #region Ex1
    public string Item { get; set; }
    public int Quantidade { get; set; }
    public double Preço { get; set; }

    public Pedido(string item, int quantidade, double preço)
    {
        Item = item;
        Quantidade = quantidade;
        Preço = preço;
    }

    public double CalcularTotal()
    {
        return Quantidade * Preço;
    }

    #endregion

    #region Ex 2
    public bool Preparado { get; set; } = false;
    public void Preparar()
    {
        Preparado = true;
        Console.WriteLine($"Preparando: {Item} - {Quantidade}x");
    }
    #endregion
}
}