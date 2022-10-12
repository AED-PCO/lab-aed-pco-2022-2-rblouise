// ordenação binária com pos

namespace OrdenacaoBinaria
{
    internal class Program
    {
        static public void PrincipalOrdenação(int[] numeros, int esquerda, int meio, int direita)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (meio - 1);
            pos = esquerda;
            num = (direita - esquerda + 1);

            while ((esquerda <= eol) && (meio <= direita))
            {
                if (numeros[esquerda] <= numeros[meio])
                    temp[pos++] = numeros[esquerda++];
                else
                    temp[pos++] = numeros[meio++];
            }
            while (esquerda <= eol)
                temp[pos++] = numeros[esquerda++];
            while (meio <= direita)
                temp[pos++] = numeros[meio++];
            for (i = 0; i < num; i++)
            {
                numeros[direita] = temp[direita];
                direita--;
            }
        }

        static public void MergeSort(int[] numeros, int esquerda, int direita)
        {
            int meio;
            if (direita > esquerda)
            {
                meio = (direita + esquerda) / 2;
                MergeSort(numeros, esquerda, meio);
                MergeSort(numeros, (meio + 1), direita);
                PrincipalOrdenação(numeros, esquerda, (meio + 1), direita);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Digite quantidade de elementos do vetor que deseja ordenar:");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[max];
            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Vetor Inicial:");
            Console.Write("\n");
            for (int k = 0; k < max; k++)
            {
                Console.Write(numeros[k] + " ");
                Console.Write("\n");
            }
            Console.WriteLine("Vetor Ordenado:");
            MergeSort(numeros, 0, max - 1);
            for (int i = 0; i < max; i++)
                Console.WriteLine(numeros[i]);

        }
    }
}

// ordenação binária sem pos

// busca binária sem pos

namespace BuscaComPos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] V = { 2,10,16,20,28,32,68,86,102,120 };
            int N, Result;

            Vetor(V);

            Console.WriteLine("");

            Console.WriteLine("Buscar:");
            N = int.Parse(Console.ReadLine());

            Result = BuscaBinaria(V, N, 0, (V.Length - 1));

            Console.WriteLine($"O {N} está localizado na posição {Result + 1} do vetor");
        }
        static void Vetor(int[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }
        }
        static int BuscaBinaria(int[] Vet, int Num, int Inicio, int Fim)
        {
            int Meio = (Fim + Inicio) / 2;

            if (Fim < 0)
            {
                return 0;
            }
            if (Vet[Meio] < Num)
            {
                return BuscaBinaria(Vet, Num, (Meio + 1), Inicio);
            }
            else if (Vet[Meio] > Num)
            {
                return BuscaBinaria(Vet, Num, Inicio, (Meio - 1));
            }
            else
                return Meio;
        }
    }
}

// busca binária com pos
