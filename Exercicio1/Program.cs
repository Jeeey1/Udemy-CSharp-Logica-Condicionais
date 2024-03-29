using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

       // BEECROWD  - ISSUE 1036 - FORMULA BHASKARA - MINHA RESOLUÇÃO
       
       double A, B, C, delta, x1, x2;

        string[] vet = Console.ReadLine().Split(' ');
        A = double.Parse(vet[0], CultureInfo.InvariantCulture);
        B = double.Parse(vet[1], CultureInfo.InvariantCulture);
        C = double.Parse(vet[2], CultureInfo.InvariantCulture);

        if (A == 0){
            Console.WriteLine("Impossível calcular");
        }    
        else if (A != 0.0){
            delta = Math.Pow(B, 2) - (4 * A * C);
            if (delta <= 0){
                Console.WriteLine("Impossível calcular");
            }
            else {
                x1 = ((-B) + Math.Sqrt(delta)) / (2.0 * A);
                x2 = ((-B) - Math.Sqrt(delta)) / (2.0 * A);
                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
        Console.ReadLine();

        // Resolução funcionou porém poderia fazer de uma forma bem mais reduzida colocando o primeiro if a == 0 || delta <= 0
        // nao mudei para poder deixar minha primeira resolução e futuramente poder melhorar minha skill e comparar
            
    }
}


