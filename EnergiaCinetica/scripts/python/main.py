def EnergiaCinetica(M, V):
    EnergiaCinetica = 0.5 * M * V * V
    return EnergiaCinetica
  
if __name__ == "__main__":
    M = 5.5
    H = 23.5
    V = 10.5

    print("Energia cinética = ", EnergiaCinetica(M, V))
