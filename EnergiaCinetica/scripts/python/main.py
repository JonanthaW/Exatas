massa = float(input())
velocidade = float(input())
def energia_cinetica(massa, velocidade):
    Ec = (1/2) * massa * (velocidade ** 2)
    print('Energia cinética em Joules: ', Ec)
    return Ec

energia_cinetica(massa, velocidade)
