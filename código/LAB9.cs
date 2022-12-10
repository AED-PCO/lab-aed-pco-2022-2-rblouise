// PILHA ESTATICA INVERTIDA

namespace lab9_pilhainvertida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 0, valor = 0, QuantVetor = 6;
            int[] vetor = new int[QuantVetor];
            int[] VetorInversoVa = new int[QuantVetor];


            for (int x = 0; x < QuantVetor; x++)
            {
                Console.WriteLine("Digite um número para inserir no Vetor:");
                valor = int.Parse(Console.ReadLine());

                if (pos < QuantVetor)
                {
                    Pilha(vetor, pos, valor);
                    pos += 1;
                }
                else
                {
                    Console.WriteLine("Sem espaço, remova os números para incluir.");
                }
            }

            Console.Write("Pilha Original: ");
            VetorAmostra(vetor);

            VetorInversoVa = PilhaInvertida(vetor, QuantVetor);

            Console.Write("Pilha Inversa: ");
            VetorAmostra(VetorInversoVa);
        }
        static void VetorAmostra(int[] Vet)
        {
            for (int x = 0; x < Vet.Length; x++)
            {
                Console.Write($"{Vet[x]} ");
            }
        }

        static int[] Pilha(int[] vetor, int ValAux, int valor)
        {
            vetor[ValAux] = valor;
            return vetor;
        }
        static int[] PilhaInvertida(int[] vetor, int QuantVetor)
        {
            int[] VetorInverso = new int[QuantVetor];

            for (int y = 0; y < QuantVetor; y++)
            {
                for (int z = QuantVetor - 1; z >= 0; z--)
                {
                    VetorInverso[z] = vetor[y];
                    y++;
                }
            }
            return VetorInverso;
        }
        
    }
}

//FILA ESTATICA INVERTIDA

namespace Lab9_FilaInvertida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 0, valor = 0, TamVetor = 5;
            int[] vetor = new int[TamVetor];
            int[] VetorInvertido = new int[TamVetor];


            for (int i = 0; i < TamVetor; i++)
            {
                Console.WriteLine("Digite o número que deseja inserir no Vetor");
                valor = int.Parse(Console.ReadLine());
                if (pos < TamVetor)
                {
                    InsereFila(vetor, pos, valor);
                    pos += 1;
                }
                else
                    Console.WriteLine("Vetor não possui espaço livre!");
            }

            Console.Write("Fila Inicial: ");
            MostraVetor(vetor);

            VetorInvertido = FilaInvertida(vetor, TamVetor);

            Console.Write("Fila Inversa: ");
            MostraVetor(VetorInvertido);
            Console.ReadKey();
        }
        static void MostraVetor(int[] V)
        {
            for (int j = 0; j < V.Length; j++)
            {
                Console.Write($"{V[j]} ");
            }
        }
        static int[] FilaInvertida(int[] vetor, int TamVetor)
        {
            int[] VetInvertido = new int[TamVetor];

            for (int k = 0; k < TamVetor; k++)
            {
                for (int l = TamVetor - 1; l >= 0; l--)
                {
                    VetInvertido[l] = vetor[k];
                    k++;
                }
            }
            return VetInvertido;
        }
        static int[] InsereFila(int[] vetor, int VarAuxiliar, int valor)
        {
            vetor[VarAuxiliar] = valor;
            return vetor;
        }
    }
}

// LISTA METADE INVERTIDA ESTATICA

namespace Lab9_ListaCopiadaInvertida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 0, valor = 0, TamVetor = 4;
            int[] vetor = new int[TamVetor];
            int[] VetInvertidoVar = new int[TamVetor / 2];

            for (int k = 0; k < TamVetor; k++)
            {
                Console.WriteLine("Digite o número que deseja incluir no Vetor:");
                valor = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a posição que deseja incluir no Vetor:");
                pos = int.Parse(Console.ReadLine());

                if (pos < TamVetor)
                {
                    ListaInserida(TamVetor, vetor, pos, valor);
                    pos += 1;
                    for (int i = 0; i < pos; i++)
                        ListaInserida(TamVetor, vetor, pos, valor);
                }
                Console.Write("Lista Inicial: ");
                MosVetor(vetor);

                VetInvertidoVar = ListaInvertida(vetor, TamVetor);

                Console.Write("Lista Inicial Metade: ");
                MosVetor(vetor);

                Console.ReadKey();
            }
            static void MosVetor(int[] V)
            {
                for (int i = 0; i < V.Length; i++)
                {
                    Console.Write($"{V[i]} ");
                }
            }
            static int[] ListaInserida(int LimitePos, int[] vetor, int pos, int valor)
            {
                if (LimitePos < 0)
                {
                    vetor[pos] = valor;
                    return vetor;
                }
                if (LimitePos > pos)
                    LimitePos = pos;
                for (int j = pos; LimitePos > pos; j--)

                {
                    vetor[j] = vetor[j - 1];
                }
                vetor[LimitePos] = valor;
                return vetor;
            }
            static int[] ListaInvertida(int[] vetor, int TamVetor)
            {
                int[] VetInvertido = new int[TamVetor];

                for (int l = TamVetor / 2; l < TamVetor; l++)
                {
                    for (int k = (TamVetor - 1) / 2; k >= 0; k--)
                    {
                        VetInvertido[k] = vetor[l];
                        l++;
                    }
                }
                return VetInvertido;
            }
        }
    }
}
