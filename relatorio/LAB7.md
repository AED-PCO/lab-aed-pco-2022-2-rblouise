LAB7 - PROVA

1- Modele, projete e calcule a complexidade de um programa que:

a) Leia as linhas de um arquivo chamado "arq1.txt".

b) Peça para o usuário inserir um texto no terminal/console.

c) Compare o texto escrito pelo usuário e o texto lido no arquivo, e escreva na tela quantos termos "IGUAIS" e "DIFERENTES".

d) Descreva quais as operações relevantes.

2a) Quantos e quais casos base/condições de parada para a função funcRec1()?
 
    Há condição de parada so se o A for menor ou igual a 1.

b) Explique com suas palavras o que a função funcRec1() calcula.

    A função calcula a Recursividade do If que se menor ou igual a 1 retorna 0, se não ela retorna a função.

c) Represente a pilha de execução para a chamada funcRec1(6).

   ![image](https://user-images.githubusercontent.com/101759423/197077406-87105e9a-38c1-4837-b517-831e94ba78fc.png)

3- Modele, projete e calcule a complexidade de um programa que:

a) Leia a primeira linha de um arquivo chamado "entrada.txt".

b) Escreva em um arquivo chamado "saida.txt" o conteúdo lido no arquivo de entrada ao contrário.

c) Descreva quais as operações relevantes.

4- Um banco famoso enfrenta problemas de consulta em seu banco de registros. Dentre os problemas identificados pela gerência está a localização das contas dos seus titulares nas listagens e nos relatórios impressos em diferentes situações. Um especialista de TI sugeriu ordenar as contas por meio do CPF dos seus titulares antes das impessões. Dentre alguns algoritmos pré-selecionados para essa ordenação, o especialista escolheu o algoritmo de ordenação por Inserção. Se você fosse o especialista, responda:

a) O especialista escolheu um bom algoritmo? Justique

    Não. Pois a ordenação por Inserção geraria um custo alto tratando-se de ordernar CPF.
  
b) Qual algoritmo de ordenação usaria?

    Merge Sort. Porque primeiro ele divide o vetor para depois ordenar e sua complexidade log elevado a n.

c) Descreva quais operações relevantes.

    Atribuição e Comparação.
  
d) Demonstre a viabilidade da sua solução para 10 registros.

5-O código a seguir implementa uma função recursiva. Analise-o e indique o que será retornado pela função, caso os parâmetros possuam os seguintes dados: V = {10, 5, 7, 15, 22, 9, 30} e A = 6.
