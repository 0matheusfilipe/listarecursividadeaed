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
        static int SomaIntervalo(int m, int n)
        {
            if (m == n)
            {
                return m;
            }
            else
            {
                return SomaIntervalo(m, n - 1) + n;
            }
        }
        static void Main(string[] args)
        {         
            //Console.Write("Digite um número decimal: ");
            //int numero = int.Parse(Console.ReadLine());
            //ConverteDecimalEmBinario(numero);

            // Exemplo de uso da função SomaIntervalo
            // Console.WriteLine(SomaIntervalo(1, 10));

            Console.ReadKey();
        }
    }
}
