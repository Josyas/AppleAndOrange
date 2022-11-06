# AppleAndOrange

SABER A QUANTIDADE DE FRUTAS QUE CAI NA CASA DE SAM.

S - INICIO DA CASA DE SAM 
T - FINAL DA CASA DE SAM

A - MAÇÃ - ONDE ESTA LOCALIZADA
B - LARANJA - ONDE ESTA LOCALIZADA

D - VALOR NEGATIVO CAI NA ESQUERDA DA ARVORE
D - VALOR POSITIVO CAI NA DIREITA DA ARVORE

TOTAL DE MAÇÃ QUE CAIU NA CASA DE SAM [S,T]

M - MAÇÃ
N - LARANJA

Macieira está à esquerda da casa e a laranjeira à direita

1 - s: inteiro, ponto inicial da localização da casa de Sam.
2 - t: inteiro, localização final da localização da casa de Sam.
3 - a: integer, localização da macieira.
4 - b: inteiro, localização da laranjeira.
5 - maçãs: array inteiro, distâncias em que cada maçã cai da árvore.
6 - oranges : array inteiro, distâncias em que cada laranja cai da árvore.

Formato de entrada

A primeira linha contém dois inteiros separados por espaços denotando os respectivos valores de S e T.
A segunda linha contém dois inteiros separados por espaços denotando os respectivos valores de A e B.
A terceira linha contém dois inteiros separados por espaços denotando os respectivos valores de M e N.
A quarta linha contéminteiros separados por espaço denotando as respectivas distâncias que cada maçã cai do ponto A.
A quinta linha contéminteiros separados por espaço denotando as respectivas distâncias que cada laranja cai do ponto B.

FORMATO DE SAIDA
Imprima dois inteiros em duas linhas diferentes:

O primeiro inteiro: o número de maçãs que caem na casa de Sam.
O segundo número inteiro: o número de laranjas que caem na casa de Sam.


Resolução:

1: criar uma variavel para armazenar os valores de maçã e laranja;
2: criar um for ou um foreach para passar em um loop de repetição para contar o total de frutas;
3: pegar a distancia que sera A onde esta localizado a MAÇÃ e somar junto com a fruta e saber se é MAIOR OU IGUAL a posição inicial da casa;
4: pegar a distancia que sera B onde esta localizado a LARANJA e somar junto com a fruta e saber se é MENOR OU IGUAL a posição final da casa, pois o que estiver maior não contara;
5: se cumprir todos os requisitos armazenar a informação na variavel e exibir;



            int s = 7, a = 4;
            int t = 10, b = 12;

            int[] apples = { 2, 3, -4 };
            int[] oranges = { 3, -2, -4 };

            int resultMaca = 0;
            int resultLaranja = 0;

            for (int i = 0; i < apples.Length; i++)
            {
                if(a + apples[i] >= s && a + apples[i] <= t)
                {
                   resultMaca++;
                }
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                if (b + oranges[i] <= t && b + oranges[i] >= s)
                {
                   resultLaranja++;
                }
            }

            Console.WriteLine(resultMaca +"=> maçã ");
            Console.WriteLine(resultLaranja + " => Laranja ");

		
COMPORTAMENTO DO FOR NA REPETIÇÃO | int[] apples = { 2, 3, -4 } 

"a + apples[i] >= s" | a = 4 + apples = 2 RESULTADO = 6 |RESULTADO = 6 e maior ou igual a s = 7 distancia inicial"  &&  "a + apples[i] >= t" | a = 4 + apples = 2| 6 e menor ou igual a t = 12 distancia inicial" -> NÃO CUMPRIU O REQUISITO     
"a + apples[i] >= s" | a = 4 + apples = 3 RESULTADO = 7 |RESULTADO = 7 e maior ou igual a s = 7 distancia inicial"  &&  "a + apples[i] >= t" | a = 4 + apples = 3| 7 e menor ou igual a t = 12 distancia inicial" -> CUMPRIU O REQUISITO  	
"a + apples[i] >= s" | a = 4 + apples =-4 RESULTADO = 0 |RESULTADO = 0 e maior ou igual a s = 7 distancia inicial"  &&  "a + apples[i] >= t" | a = 4 + apples =-4| 0 e menor ou igual a t = 12 distancia inicial" -> NÃO CUMPRIU O REQUISITO     

