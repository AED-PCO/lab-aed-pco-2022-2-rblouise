// FILA
namespace lab8_fila
{
    internal class Program
    {
        static int [] InserirFila(int[] Vetor, int pos, int valor)
        {
            Vetor[pos] = valor;
            return Vetor;
        }

        static int [] TirarFila(int[] Vetor)
        {
            int aux =  Vetor[0];
            for(int i = 1; i<Vetor.Length; i++)
            {
                Vetor[i - 1] = Vetor[i];
            }
            Console.WriteLine("O elemento retirado foi: " + aux);

            return Vetor;

        }
        static void Main(string[] args)
        {
            int Pos = 0, valor = 0, tam = 10;
            int [] Vetor = new int[tam];
            
            for(int j=0; j<tam;j++)
            {
                valor = j * j;
                if (Pos < tam)
                {
                    InserirFila(Vetor, Pos, valor);
                    Pos += 1;
                }
                else
                    Console.WriteLine("vetor não tem espaço livre! \n Retire elementos antes de tentar inserir");
            }

            TirarFila(Vetor);
            Pos -= 1;

            Console.WriteLine("A posição de referência é: " + Pos);

            if (Pos > 0)
            {
                Console.WriteLine("Os valores na Fila são: ");
                int aux_retira = Pos;
                for (int k = 0; k < aux_retira; k++)
                {
                    TirarFila(Vetor);
                    Pos -= 1;
                }
            }
            else
                Console.WriteLine("A fila esta vazia");
            
        }
    }
}

// PILHA
namespace Lab8_Pilhaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Pos = 0, Valor = 0, TamanhoVetor = 10;
            int[] Vetor = new int[TamanhoVetor];

            for (int B = 0; B < TamanhoVetor; B++)
            {
                Console.WriteLine("Digite o número que deseja incluir no Vetor: ");
                Valor = int.Parse(Console.ReadLine());
                if (Pos < TamanhoVetor)
                {

                    InserirPilha(Vetor, Pos, Valor);
                    Pos += 1;
                }
                else
                {
                    Console.WriteLine("Vetor não possui espaço.");
                }
                TirarPilha(Pos, Vetor);
                Pos -= 1;
                if (Pos > 0)
                {
                    int Aux_Retira = Pos;
                    for (int k = 0; k < Aux_Retira; k++)
                    {
                        TirarPilha(Pos, Vetor);
                        Pos -= 1;
                    }
                }

            }
            static int[] InserirPilha(int[] Vetor, int VarAux, int Valor)
        {
            Vetor[VarAux] = Valor;
            return Vetor;
        }
        static int TirarPilha(int aux, int[] Vetor)
        {
            aux -= 1;
            Console.WriteLine("Removendo da Pilha o número " + Vetor[aux]);

            return aux;
        }
        
        }
    }
}

// LISTA
namespace lab8_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Pos = 0, Valor = 0, TamVetor = 10, Opcao;
            int[] Vetor = new int[TamVetor];

            for (int B = 0; B < TamVetor; B++)
            {
                Console.WriteLine("Qual valor que deseja incluir no Vetor");
                Valor = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o a posição que deseja incluir no Vetor");
                Pos = int.Parse(Console.ReadLine());

                if (Pos < TamVetor)
                {
                    InsereLista(TamVetor, Vetor, Pos, Valor);
                    Pos += 1;
                    for (int i = 0; i < Pos; i++)
                        Console.WriteLine("Os itens da Lista: " + Vetor[i] + " está em suas respectivas posições = " + i);
                    InsereLista(TamVetor, Vetor, Pos, Valor);
                }
                else
                    Console.WriteLine("Vetor não tem espaço ou posição está errada!");
                Console.WriteLine("Deseja remover itens da Lista? 1 - SIM 2 - NÃO");
                Opcao = int.Parse(Console.ReadLine());

                if (Opcao == 1)
                {

                    Console.WriteLine("Qual posição deseja remover?");
                    Pos = int.Parse(Console.ReadLine());
                    RemoveLista(Vetor, Pos);
                }
                else
                {
                    if (Pos < TamVetor)
                    {
                        InsereLista(TamVetor, Vetor, Pos, Valor);
                        Pos += 1;
                        for (int i = 0; i < Pos; i++)
                            Console.WriteLine("Os itens da Lista: " + Vetor[i] + " está em suas respectivas posições = " + i);
                        InsereLista(TamVetor, Vetor, Pos, Valor);
                    }
                }
            }
        }
        static int[] RemoveLista(int[] Vetor, int Pos)
        {

            Vetor[Pos] = 0;
            return Vetor;
        }
        static int[] InsereLista(int PosLimite, int[] Vetor, int Pos, int Valor)
        {
            if (PosLimite < 0)
            {
                Vetor[Pos] = Valor;
                return Vetor;
            }
            if (PosLimite > Pos)
                PosLimite = Pos;
            for (int i = Pos; i > PosLimite; i--)

            {
                Vetor[i] = Vetor[i - 1];
            }
            Vetor[PosLimite] = Valor;
            return Vetor;
        }
    }
}
