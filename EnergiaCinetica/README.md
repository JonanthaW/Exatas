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

Para calcular a energia cinética de um objeto com massa “m” e velocidade “v” devemos aplicar a fórmula Ec = mv²/2, onde:

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

Os moinhos de vento são uma excelente ilustração das aplicações da energia cinética.
O vento que atinge as pás do moinho de vento faz com que elas girem, resultando na geração de energia. O movimento das moléculas de ar desenvolve energia cinética que gira a lâmina e se transforma em energia mecânica.

<p align="center">
  <img src="https://raw.githubusercontent.com/JonanthaW/Exatas/main/EnergiaCinetica/images/windmill.gif"/>
</p>

# Exemplos de problemas

1. *Um carro e uma bicicleta estão viajando com a mesma velocidade, qual tem mais energia cinética?*
* O carro já que tem mais massa.

2. *Uma bola pesa cerca de 1 kg e se desloca a 20 metros por segundo, qual é a sua energia cinética?*
* Ec = mv²/2
* Ec = 1 * (20)² / 2
* Ec = 200J

# Programando: Energia cinética

*Python:*
```
massa = float(input())
velocidade = float(input())
def energia_cinetica(massa, velocidade):
    Ec = (1/2) * massa * (velocidade ** 2)
    print('Energia cinética em Joules: ', Ec)
    return Ec

energia_cinetica(massa, velocidade)
```

# Referencias:

* https://en.wikipedia.org/wiki/Kinetic_energy [WEB PAGE]
* https://www.google.com/search?client=firefox-b-d&q=kinetic+energy [WEB PAGE]
* https://www.softschools.com/facts/energy/kinetic_energy_facts/394/ [WEB PAGE]
* https://brasilescola.uol.com.br/fisica/energia-cinetica.htm [WEB PAGE]
* https://mundoeducacao.uol.com.br/fisica/energia-cinetica.htm [WEB PAGE]
