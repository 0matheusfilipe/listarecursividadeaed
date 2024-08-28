using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRecursividadeAED
{
    internal class Program
    {
        static int CalculaPotenciacao(int a, int n)
        {
            if(n == 1)
            {
                return a;
            }
            return CalculaPotenciacao(a, n - 1) * a;
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
        static void ConverteDecimalEmBinario(int numeroDecimal)
        {
            //caso-base: a recursão vai parar quando o numero for 0
            if(numeroDecimal == 0) { return; }   
            
            //caso-recursivo: a recursão funciona dividindo o número por 2
            ConverteDecimalEmBinario(numeroDecimal / 2);

            //imprime os restos das divisões por 2
            Console.Write(numeroDecimal%2);

        }
        static int CalculaMDC(int x, int y)
        {
            if (x == y)
            {
                return x;
            }
            else if (x > y)
            {
                return CalculaMDC(x - y, y);
            }
            else
            {
                return CalculaMDC(x, y - x);
            }
        }
        static int ObterNegativos(int[] arrayInteiros, int tamanhoArray)
        {
            if (tamanhoArray == 1)
            {
                if (arrayInteiros[0] < 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            int qtdNegativos = ObterNegativos(arrayInteiros, tamanhoArray - 1);
            if (arrayInteiros[tamanhoArray - 1] < 0)
            {
                qtdNegativos++;
            }
            return qtdNegativos;
        }
        static void Main(string[] args)
        {
            //Console.Write("Digite um número decimal: ");
            //int numero = int.Parse(Console.ReadLine());
            //ConverteDecimalEmBinario(numero);

            // Console.WriteLine(SomaIntervalo(1, 10));

            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int mdc = CalculaMDC(num1, num2);
            //Console.WriteLine(mdc);

            //int[] num = { -3, 10, 4, 2, 6, 8, -9 };
            //int tamanho = num.Length;

            //int quantidadeNegativos = ObterNegativos(num, tamanho);
            //Console.WriteLine(quantidadeNegativos);

            //int a = int.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());
            //int resultado = CalculaPotenciacao(a, n);
            //Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}

