using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos.Exemplos
{
    internal class Exemplo02
    {
        public void Executar()
        {
            Pedido pedidoFrancisco = new Pedido();
            pedidoFrancisco.Nome = "X-Calabresa com o dobro de calabresa";
            pedidoFrancisco.Quantidade = 2;
            pedidoFrancisco.PrecoUnitario = 29.90;

            Pedido pedidoEnzo = new Pedido();
            pedidoEnzo.Nome = "X-Salada";
            pedidoEnzo.Quantidade = 1;
            pedidoEnzo.PrecoUnitario = 25.90;

            Pedido pedidoJonathan = new Pedido();
            pedidoJonathan.Nome = "Bauru";
            pedidoJonathan.Quantidade = 2;
            pedidoJonathan.PrecoUnitario = 27.90;

            Pedido pedidoJoao = new Pedido();
            pedidoJoao.Nome = "caixa de cerveja";
            pedidoJoao.Quantidade = 3;
            pedidoJoao.PrecoUnitario = 46.00;

            double totalPedidoFrancisco = pedidoFrancisco.CalcularTotalPedido();
            double totalPedidoEnzo = pedidoEnzo.CalcularTotalPedido();
            double totalPedidoJonathan = pedidoJonathan.CalcularTotalPedido();
            double totalPedidoJoao = pedidoJoao.CalcularTotalPedido();

            double total = totalPedidoFrancisco + totalPedidoEnzo + totalPedidoJonathan + totalPedidoJoao;

            Console.WriteLine("Total Pedido Francisco: " + totalPedidoFrancisco);
            Console.WriteLine("Total Pedido Enzo: " + totalPedidoEnzo);
            Console.WriteLine("Total Pedido Jonathan: " + totalPedidoJonathan);
            Console.WriteLine("Total Pedido Joao: " + totalPedidoJoao);
            Console.WriteLine("Total dos pedidos: " + total);
        }
    }
}
