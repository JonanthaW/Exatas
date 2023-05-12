# Energia cinética
<p align="center">
  <img src="https://github.com/JonanthaW/Exatas/blob/main/EnergiaCinetica/images/cradle.gif"/>
</p>

Energia cinética é a forma de energia que um corpo qualquer possui em razão de seu movimento, em outras palavras, é a forma de energia associada à velocidade de um corpo. Quando aplicamos uma força resultante não nula sobre algum corpo, estamos realizando trabalho sobre ele, desse modo, ele adquire energia cinética na medida em que sua velocidade aumenta. A energia cinética não depende exclusivamente da velocidade de um corpo mas também de sua massa.

Energia ocorre de várias formas, incluindo energia química, energia térmica, radiação eletromagnética, energia gravitacional, energia elétrica, energia elástica, energia nuclear, e energia de descanso. Estas podem ser categorizadas em duas classes principais: energia potencial e energia cinética. Energia cinética é a energia de movimento de um objeto. Energia cinética pode ser transferida entre objetos e transformada em outros tipos de energia.

**A energia cinética pode ser melhor compreendida por exemplos que demonstram como ela é transformada de uma para outras formas de energia. Por exemplo, um ciclista usa energia química fornecida por alimentos para acelerar uma bicicleta a uma velocidade arbitrária. Em uma superfície nivelada, esta velocidade pode ser mantida sem trabalho adicional, excepto para superar a resistência do ar e fricção. A energia química foi convertida em energia cinética, a energia do movimento, mas o processo não é completamente eficiente e o ciclista produz calor.**

* O termo cinética teve sua origem na palavra grega *κίνησις kinesis*, cujo significado é movimento.
* A unidade padrão da energia cinética é o joule. 

# Fórmula: Energia cinética

Para calcular a energia cinética de um objeto devemos aplicar a fórmula Ec = mv²/2, onde:

* Ec – energia cinética em joules;
* m – massa em kg;
* v – velocidade em m/s.

<p align="center">
  <img src="https://raw.githubusercontent.com/JonanthaW/Exatas/main/EnergiaCinetica/images/kinetic.jpg"/>
</p>


* A energia cinética não é um vetor. Assim, uma bola de tênis lançada para a direita com velocidade de 5 m/s tem exatamente a mesma energia cinética que uma bola de tênis lançada para baixo com velocidade de 5 m/s.
* A energia cinética deve ser sempre zero ou um valor positivo. Embora a velocidade possa ter um valor positivo ou negativo, a velocidade ao quadrado é sempre positiva.
* A energia cinética depende da velocidade do objeto ao quadrado. Isso significa que quando a velocidade de um objeto dobra, sua energia cinética quadruplica. Um carro viajando a 60 mph tem quatro vezes a energia cinética de um carro idêntico viajando a 30 mph e, portanto, o potencial para quatro vezes mais mortes e destruição em caso de colisão.
* Quando um objeto colide com outro objeto, ele transfere sua energia cinética para o outro objeto.

# Exemplos de problemas

1. *Um carro e uma bicicleta estão viajando com a mesma velocidade, qual tem mais energia cinética?*
* O carro já que tem mais massa.

2. *Uma bola pesa cerca de 1 kg e se desloca a 20 metros por segundo, qual é a sua energia cinética?*
* Ec = mv²/2
* Ec = 1 * (20)² / 2
* Ec = 200J


## Transformando energia cinética em energia elétrica

A lei da conservação da energia afirma que a energia não pode ser criada nem destruída - apenas convertida de uma forma de energia para outra. Isso significa que um sistema sempre tem a mesma quantidade de energia, a menos que seja adicionado de fora.

A energia cinética pode ser convertida em eletricidade através de um processo conhecido como indução eletromagnética. Esse processo envolve o movimento de um campo magnético próximo a um material condutor, como um fio, que induz uma corrente elétrica a fluir no fio.

Uma aplicação comum desse princípio é o uso de um dínamo, que é um dispositivo que converte a energia mecânica de um eixo giratório em energia elétrica. O dínamo contém um ímã rotativo que se move próximo a uma bobina estacionária de fio, induzindo uma corrente elétrica a fluir no fio. A energia elétrica resultante pode ser usada para alimentar luzes, motores ou outros dispositivos elétricos.

<p align="center">
  <img src="https://raw.githubusercontent.com/JonanthaW/Exatas/main/EnergiaCinetica/images/dynamo.jpg"/>
</p>

Outro exemplo são nas usinas hidrelétricas, a água do rio faz a turbina girar, transformando a energia cinética em eletricidade.

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/JonanthaW/Exatas/main/EnergiaCinetica/images/hidreletrica.png"/>
</p>

Os moinhos de vento são uma excelente ilustração das aplicações da energia cinética.
O vento que atinge as pás do moinho de vento faz com que elas girem, resultando na geração de energia. O movimento das moléculas de ar desenvolve energia cinética que gira a lâmina e se transforma em energia mecânica.

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/JonanthaW/Exatas/main/EnergiaCinetica/images/eolica.png"/>
</p>




# Programando: Energia cinética

*Python: calculando a energia cinética de um objeto utilizando funções simples*
```
massa = float(input())
velocidade = float(input())
def energia_cinetica(massa, velocidade):
    Ec = (1/2) * massa * (velocidade ** 2)
    print('Energia cinética em Joules: ', Ec)
    return Ec

energia_cinetica(massa, velocidade)
```

*Python:*
```
def EnergiaCinetica(M, V):
    EnergiaCinetica = 0.5 * M * V * V
    return EnergiaCinetica
  
if __name__ == "__main__":
    M = 5.5
    H = 23.5
    V = 10.5

    print("Energia cinética = ", EnergiaCinetica(M, V))
````

<p align="center">
  <img src="https://raw.githubusercontent.com/JonanthaW/Exatas/main/EnergiaCinetica/images/carSimulation.gif"/>
</p>


### Quanto Joules são necessários para matar um humano?

Objetos que possam parecer inofensivos podem causar a morte de uma pessoa, se caírem de uma certa altura. Vamos tomar como primeiro exemplo uma moeda de R$0,50 (a nossa moeda mais pesada), se jogada em uma altura de **160** metros ela atingiria uma velocidade de **94,3 km/h**, gerando **energia de 2,3 joules** em seu impacto, o que causaria apenas um machucado em seu impacto já que para perfurar o crânio de uma pessoa seria necessário uma força de **45 joules**. 
Agora vamos partir para outro exemplo, uma cabeça de alho. Se tomarmos como base a mesma altura em que usamos para a moeda, seria obtida uma velocidade de **142 km/h**, que produziria uma energia de **46,8 joules**, ou seja, conseguiria perfurar o crânio de uma pessoa, levando-a à morte.

Dropped Objects, ou “Objetos Caídos” em uma tradução bem livre, é um risco bem comum nas plataformas petrolíferas, em que trabalhadores tem que usar ferramentas manuais enquanto estão realizando atividades em altura. Deixar cair alguma ferramenta e atingir alguém lá embaixo é um tipo de acidente bem provável. Tanto que existe até uma associação para prevenir este tipo de acidente, a DROPS – Dropped Objects Prevention Scheme. Dentre os diversos recursos fornecidos pela DROPS, existe uma calculadora de riscos ligados a objetos caídos, que leva em consideração o peso do objeto e a altura da qual cai e fornece como resultado a possível consequência caso atinja uma pessoa.

* www.dropsonline.org
* www.dropsonline.org/resources-and-guidance/drops-calculator/

<p align="center">
  <img src="https://raw.githubusercontent.com/JonanthaW/Exatas/main/EnergiaCinetica/images/DROPS.png"/>
</p>

Para nível de comparação, uma carabina de chumbinho possui em torno de 15 a 20 joules de energia. Já uma arma de fogo, uma pistola calibre 9mm, por exemplo, possui uma energia de mais de 500 joules. Uma arma de airsoft tem uma energia média de 1 a 2,5 joules.



### Simulando energia em ação utilizando a Unity:

``` Para uma melhor visualização criei uma pequena simulação utilizando as fisicas da Unity. (Os arquivos estão disponíveis no diretório padrão, usem a vontade)```
Nesta simulação do Unity, um canhão acaba de ser disparado e estamos calculando sua energia cinética. Podemos ver a bala de canhão voando pelo ar, À medida que aterra à distância, obtemos uma leitura da sua energia cinética (E outros fatores) - uma exibição impressionante da física em ação. A precisão da simulação nos permite entender melhor as forças em ação quando um canhão é disparado, e os cálculos fornecem informações valiosas sobre como os objetos se movem pelo mundo.

<p align="center">
  <img src="https://raw.githubusercontent.com/JonanthaW/Exatas/main/EnergiaCinetica/images/simulation.png"/>
</p>

# Referencias:

* https://en.wikipedia.org/wiki/Kinetic_energy [WEB PAGE]
* https://www.google.com/search?client=firefox-b-d&q=kinetic+energy [WEB PAGE]
* https://www.softschools.com/facts/energy/kinetic_energy_facts/394/ [WEB PAGE]
* https://brasilescola.uol.com.br/fisica/energia-cinetica.htm [WEB PAGE]
* https://mundoeducacao.uol.com.br/fisica/energia-cinetica.htm [WEB PAGE]
* https://lambdageeks.com/kinetic-energy-to-electrical-energy/ [WEB PAGE]
* https://www.epe.gov.br/pt/abcdenergia/formas-de-energia [WEB PAGE]
* https://www.youtube.com/watch?v=QqaQFyutNKk [VIDEO]
* https://www.geeksforgeeks.org/program-to-calculate-kinetic-energy-and-potential-energy/ [WEB PAGE]
* https://www.seucondominio.com.br/noticias/pequenos-objetos-atirados-pela-janela-podem-matar-seu-condominio [WEB PAGE]
* https://blog.actionadventure.com.br/2021/12/airsoft-quantos-metros-alcanca-um-tiro/ [WEB PAGE]
