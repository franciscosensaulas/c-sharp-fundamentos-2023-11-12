using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos
{
    internal class Pedido
    {
        // Propriedades do Pedido
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }

        // Método: para calcular o total do pedido, desta forma, centralizando o cálculo da quantidade * preço
        public double CalcularTotalPedido()
        {
            double total = Quantidade * PrecoUnitario;

            // Retorna o valor calculado do total, para que seja possível obter
            // o valor calculado por quem chamar este método
            return total;
        }
    }
}
