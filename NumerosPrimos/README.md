# Números primos

<p align="center">
  <img src="https://github.com/JonanthaW/Exatas/blob/main/NumerosPrimos/images/anime-prime.webp">
</p>

Os números primos são números naturais maiores do que 1 que possuem somente dois divisores, ou seja, são divisíveis por 1 e por ele mesmo. A propriedade de ser um primo é chamada "primalidade".
O Teorema Fundamental da Aritmética garante que todo número natural maior que 1 é primo, ou pode ser escrito como um produto de números primos.

**OBS: Como "dois" é o único número primo par, o termo "primo ímpar" refere-se a todo primo maior do que dois.**

* 5 é um número primo, pois ele é divisível somente por 1 e por 5.

* 8 não é um número primo, pois, além de ser divisível por 1 e por 8, também é divisível por 2 e 4.

**Antes de saber mais sobre o número primo, é importante relembrar algumas regras de divisibilidade, que ajudam na identificação de quais números não são primos.**

* Divisibilidade por **2**: todo número par é divisível por 2. Os números pares são aqueles terminados em 0, 2, 4, 6 e 8.

* Divisibilidade por **3**: um número é divisível por 3 se a soma dos seus algarismos der um número divisível por 3.

* Divisibilidade por **4**: um número é divisível por 4 se ele for divisível duas vezes por 2 ou, então, se seus dois últimos algarismos forem divisíveis por 4.

* Divisibilidade por **5**: todo número terminado em 0 ou 5 é divisível por cinco.

* Divisibilidade por **6**: se um número for par e também divisível por 3, será divisível por 6.

* Divisibilidade por **7**: um número é divisível por 7 se a diferença entre o dobro do último algarismo e o restante do número resultar em um número múltiplo de 7.

## Crivo de Erastóstenes

<p align="center">
  <img src="https://github.com/JonanthaW/Exatas/blob/main/NumerosPrimos/images/eratostenes.png">
</p>

Eratóstenes (285 – 194 a.C.) foi um matemático grego que descobriu um esquema para encontrar os números primos que ficou conhecido como “Crivo de Eratóstenes”.
Esse esquema é representado por uma tabela composta de números naturais. Na tabela a seguir, iremos cancelar os números que não são primos seguindo esta ordem:

* O número 1 estará fora, pois, pela condição inicial, os números primos são maiores que um (será destacado de preto);

* Os números terminados em 0, 2, 4, 6 e 8 estarão fora porque são divisíveis por dois (serão destacados vermelho);

* Os números terminados em 5 estarão fora porque são divisíveis por 5 (serão destacados de azul). Os números terminados em zero já foram cortados;

* Os números cuja soma dos algarismos for 3 estarão fora por serem divisíveis por três (serão destacados de laranja);

* Os números que são divisíveis por 7 serão retirados também (serão destacados de verde).

<p align="center">
  <img src="https://github.com/JonanthaW/Exatas/blob/main/NumerosPrimos/images/crivo-tabela.webp">
</p>

*Os números destacados em amarelo são aqueles que só são divisíveis por 1 e por eles mesmos, isto é, não obedecem a nenhum dos critérios de divisibilidade que comentamos acima. Portanto, pelo “Crivo de Eratóstenes”, os números 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47,53, 59, 61, 67, 71, 73, 79, 83, 89 e 97 são os únicos números primos menores que 100.*

# Maior número primo conhecido atualmente (2023)

<p align="center">
  <img src="https://github.com/JonanthaW/Exatas/blob/main/NumerosPrimos/images/bigger-prime.jpeg">
</p>

O maior deles foi descoberto por um norte-americano e conta com 23.249.425 dígitos. Para ser encurtado, o número recebeu o nome M77232917. O número foi “descoberto” pelo engenheiro eletricista Jonathan Pace, que mantem um computador voltado apenas para isso no estado norte-americano do Tennessee há 14 anos. Foram seis dias de computação ininterrupta, tendo o resultado verificado pelo projeto “Great Internet Mersenne Prime Search” (GIMPS), projeto iniciado em 1996, que tem como função buscar por numerais do tipo. A descoberta de Pace possui aproximadamente 1 milhão de dígitos a mais que o recorde anterior, achado no ano de 2016. 

<p align="center">
  <img width="480" src="https://github.com/JonanthaW/Exatas/blob/main/NumerosPrimos/images/GIMPS.png">
</p>

“Eu fiquei muito surpreso por ter sido descoberto tão rápido. Nós esperávamos que levasse mais tempo”, afirmou Chris Caldwell, professor de matemática da Universidade do Tennessee e dono de um site sobre os maiores números primos, em entrevista ao jornal britânico The Guardian. O número descoberto é chamado de primo de Mersenne, que consiste em um número primo resultado de uma potência de base 2 subtraído por 1. Os primos de Mersenne apresentam uma facilidade em se verificar se são primos ou não.

Site: https://www.mersenne.org/

# Números primos na biologia

<p align="center">
  <img width="480" src="https://github.com/JonanthaW/Exatas/blob/main/NumerosPrimos/images/cicada.JPG">
</p>
A estratégia evolutiva utilizada pelas cigarras do gênero Magicicada faz uso de números primos. Esses insetos passam a maior parte de suas vidas como larvas no subsolo. Eles apenas se transformam em pupas e emergem de suas tocas após 7, 13 ou 17 anos, quando voam, se reproduzem e morrem após algumas semanas no máximo. Os biólogos teorizam que esses ciclos de reprodução de números primos evoluíram para evitar que os predadores se sincronizem com esses ciclos.


# Programando

Existem diversos meios de checar se um número é primo usando alguma linguagem de programação. Alguns mais performáticos que outros. Aqui estão alguns exemplos mais simples:

**Python usando um simples LOOP para checar uma faixa de números específicos:**
```
low = 0
high = 1000

for num in range (low, high + 1):
    if num > 1:
       for i in range(2, num):
           if (num % i) == 0:
               break
       else:
           print(num)
print("Script fianlizado.")
```

**C#:**

```
using System;
namespace PrimeNumbers {
    public class Program {
        static void Main(string[] args) {

            int low = 0;
            int high = 1000;

            for (int i = low; i <= high; i++) {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++) {
                    if (i % j == 0) {
                        counter++;
                        break;
                    }
                }
                if (counter == 0 && i != 1) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
```



## Projetos legais usando números primos

* PRIMIFY (Transforma uma imagem em art ASCII usando números primos) - https://github.com/LeviBorodenko/primify
* isthisprime.com (Um simples site que te diz se um número é primo ou não) - [https://isthisprime.com/about.html](https://github.com/christianp/isthisprime.com)


### Referências

* https://escolakids.uol.com.br/matematica/numeros-primos.htm [WEB PAGE]
* https://www.todamateria.com.br/numeros-primos/ [WEB PAGE]
* https://pt.wikipedia.org/wiki/N%C3%BAmero_primo [WEB PAGE]
* https://www.techtarget.com/whatis/definition/prime-number [WEB PAGE]
* https://en.wikipedia.org/wiki/Prime_number [WEB PAGE]
* https://www.edureka.co/blog/python-program-prime-number/ [WEB PAGE]
* https://www.programiz.com/python-programming/examples/prime-number [WEB PAGE]
* https://www.youtube.com/watch?v=6pgeQtwC5e0 [VIDEO]
