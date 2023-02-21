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