# Script pra checar se uma lista de numeros é primo ou não

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
