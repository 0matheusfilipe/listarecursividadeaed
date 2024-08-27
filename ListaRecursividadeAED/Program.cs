using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRecursividadeAED
{
    internal class Program
    {
        static void ConverteDecimalEmBinario(int numeroDecimal)
        {
            //caso-base: a recursão vai parar quando o numero for 0
            if(numeroDecimal == 0) { return; }   
            
            //caso-recursivo: a recursão funciona dividindo o número por 2
            ConverteDecimalEmBinario(numeroDecimal / 2);

            //imprime os restos das divisões por 2
            Console.Write(numeroDecimal%2);

        }
        static void Main(string[] args)
        {
            /*Implemente um método recursivo para converter um número decimal para binário (isto é, converter um número do
            Sistema Decimal para o Sistema Binário). O método deve receber como parâmetro um número decimal positivo e
            deve imprimir na tela esse número convertido para binário (Obs: o método não deve ter retorno, deve ser void).
            Uma maneira simples de resolver o problema é dividir o número decimal sucessivamente por 2 e pegar o resto da
            i-ésima divisão, da direita para esquerda.
            Exemplo1 - Para o número 12 temos:
            12/2 = 6, resto 0
            6/2 = 3, resto 0
            3/2 = 1, resto 1
            1/2 = 0, resto 1
            Portanto, o número 12 em binário é 1100
            Exemplo 2 - Para o número 8 temos:
            8/2 = 4, resto 0
            4/2 = 2, resto 0
            2/2 = 1, resto 0
            1/2 = 0, resto 1
            Portanto, o número 8 em binário é 1000*/

            int numero = int.Parse(Console.ReadLine());
            ConverteDecimalEmBinario(numero);

            Console.ReadKey();
        }
    }
}
