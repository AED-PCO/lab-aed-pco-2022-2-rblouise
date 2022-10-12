// ordenação binária com pos

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
