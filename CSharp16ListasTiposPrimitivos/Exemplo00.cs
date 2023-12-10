using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp16ListasTiposPrimitivos
{
    internal class Exemplo00
    {
        public void Executar()
        {
            /*
             * Tipos primitivos:
             * string
             * int
             * double
             * char
             * bool
             */

            // Criar um vetor de 4 posições
            //int[] numeros = new int[4];
            //numeros[0] = 5;
            //numeros[1] = 7;
            //numeros[2] = 9;
            //numeros[3] = 3;

            // Criar uma lista de números inteiros
            List<int> numeros = new List<int>();
            numeros.Add(5); // Adicionado o número 5 na primeira(0) posição da lista
            numeros.Add(7); // Adicionado o número 7 na segunda(1) posição da lista
            numeros.Add(9); // Adicionado o número 9 na terceira(2) posição da lista
            numeros.Add(3); // Adicionado o número 3 na quarta(3) posição da lista
            numeros.Add(10); // Adicionado o número 10m na quinta posição da lista

            // Remover um número da lista
            numeros.Remove(9); // Removido o número 9 da posição 2 => [5,7,3,10]

            // Verificar se número 10 existe na lista
            bool numero10ExisteNaLista = numeros.Contains(10);
            Console.WriteLine("Lista contém número 10: " + numero10ExisteNaLista);

            // Alterar o número 5 da primeria(0) posição para o número 6
            numeros[0] = 6;

            Console.WriteLine("Números: ");
            Console.WriteLine(numeros[0]); // 6
            Console.WriteLine(numeros[1]); // 7
            Console.WriteLine(numeros[2]); // 3
            Console.WriteLine(numeros[3]); // 10

            // Somar os números da lista e apresentar
            int soma = numeros[0] + numeros[1] + numeros[2] + numeros[3];
            Console.WriteLine("Soma: " + soma);
        }
    }
}
