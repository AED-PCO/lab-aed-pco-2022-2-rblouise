// Bubble Sort

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 78, 55, 45, 98, 13 };
            int temp;

            for (int j = 0; j <= vetor.Length - 2; j++)
            {
                for (int i = 0; i <= vetor.Length - 2; i++)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        temp = vetor[i + 1];
                        vetor[i + 1] = vetor[i];
                        vetor[i] = temp;
                    }
                }
            }
            Console.WriteLine("Vetor Ordenado:");
            foreach (int p in vetor)
                Console.Write(p + " ");
        }
    }
 }

// Selection Sort

namespace Sellection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
            int n = 10;

            Console.WriteLine("Selection Sort");
            Console.Write("Vetor Inicial: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            int temp, MenorValor;

            for (int i = 0; i < n - 1; i++)
            {
                MenorValor = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (vetor[j] < vetor[MenorValor])
                    {
                        MenorValor = j;
                    }
                }
                temp = vetor[MenorValor];
                vetor[MenorValor] = vetor[i];
                vetor[i] = temp;
            }
            Console.WriteLine();
            Console.Write("Vetor Ordenado: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(vetor[i] + " ");
            }
        }
    }
}

// Insertion Sort

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("\n Vetor Inicial:");
            ImprimeVetor(vetor);
            Console.WriteLine("\nVetor Ordenado:");
            ImprimeVetor(InsertionSort(vetor));
            Console.WriteLine("\n");
        }

        static int[] InsertionSort(int[] VetImput)
        {
            for (int i = 0; i < VetImput.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (VetImput[j - 1] > VetImput[j])
                    {
                        int temp = VetImput[j - 1];
                        VetImput[j - 1] = VetImput[j];
                        VetImput[j] = temp;
                    }
                }
            }
            return VetImput;
        }
        public static void ImprimeVetor (int[] V)
        {
            foreach (int i in V)
            {
                Console.Write(i.ToString() + "  ");
            }
        }
    }
}

// Quick Sort
namespace Quick_Sort
{
    internal class Program
    {
        private static void QuickSort(int[] vetor, int esquerda, int direita)
        {
            if (esquerda < direita)
            {
                int pivo = Particao(vetor, esquerda, direita);

                if (pivo > 1)
                {
                    QuickSort(vetor, esquerda, pivo - 1);
                }
                if (pivo + 1 < direita)
                {
                    QuickSort(vetor, pivo + 1, direita);
                }
            }

        }

        private static int Particao(int[] vetor, int esquerda, int direita)
        {
            int pivo = vetor[esquerda];
            while (true)
            {

                while (vetor[esquerda] < pivo)
                {
                    esquerda++;
                }

                while (vetor[direita] > pivo)
                {
                    direita--;
                }

                if (esquerda < direita)
                {
                    if (vetor[esquerda] == vetor[direita]) return direita;

                    int temp = vetor[esquerda];
                    vetor[esquerda] = vetor[direita];
                    vetor[direita] = temp;


                }
                else
                {
                    return direita;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] vetor = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("Vetor Inicial ");
            foreach (var item in vetor)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            QuickSort(vetor, 0, vetor.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Vetor Ordenado ");

            foreach (var item in vetor)
            {
                Console.Write(" " + item);
            }

        }
    }
}

// Shell Sort
namespace ShellSort
{
    internal class Program
    {
        static void ShellSort(int[] vetor, int n)
        {
            int i, j, pos, temp;
            pos = 3;
            while (pos > 0)
            {
                for (i = 0; i < n; i++)
                {
                    j = i;
                    temp = vetor[i];
                    while ((j >= pos) && (vetor[j - pos] > temp))
                    {
                        vetor[j] = vetor[j - pos];
                        j = j - pos;
                    }
                    vetor[j] = temp;
                }
                if (pos / 2 != 0)
                    pos = pos / 2;
                else if (pos == 1)
                    pos = 0;
                else
                    pos = 1;
            }
        }
        static void Main(string[] args)
        {
            int[] vetor = new int[] { 56, 12, 99, 32, 1, 95, 25, 5, 100, 84 };
            int n = vetor.Length;
            int i;
            Console.Write("Vetor Inicial:");
            for (i = 0; i < n; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            ShellSort(vetor, n);
            Console.Write("Vetor Ordenado:");
            for (i = 0; i < n; i++)
            {
                Console.Write(vetor[i] + " ");

            }
        }
    }
}

// Counting Sort
namespace CoutingSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10]
            { 2, 5, -4, 11, 0, 8, 22, 67, 51, 6};

            Console.WriteLine("\nVetor Inicial:");
            foreach (int aa in vetor)
                Console.Write(aa + " ");

            int[] CoutingSort = new int[vetor.Length];

            int ValorMinimo = vetor[0];
            int ValorMaximo = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < ValorMinimo) ValorMinimo = vetor[i];
                else if (vetor[i] > ValorMaximo) ValorMaximo = vetor[i];
            }

            int[] contador = new int[ValorMaximo - ValorMinimo + 1];

            for (int i = 0; i < vetor.Length; i++)
            {
                contador[vetor[i] - ValorMinimo]++;
            }

            contador[0]--;
            for (int i = 1; i < contador.Length; i++)
            {
                contador[i] = contador[i] + contador[i - 1];
            }

            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                CoutingSort[contador[vetor[i] - ValorMinimo]--] = vetor[i];
            }

            Console.WriteLine("\nVetor Ordenado:");
            foreach (int aa in CoutingSort)
                Console.Write(aa + " ");
        }
    }
}
