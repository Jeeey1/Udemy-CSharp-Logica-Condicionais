using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

       // BEECROWND  - ISSUE 1036 - FORMULA BHASKARA - MINHA RESOLUÇÃO
       
        double delta, x1, x2;
        
        string[] v = Console.ReadLine().Split(' ');

        double A = double.Parse(v[0], CultureInfo.InvariantCulture);
        double B = double.Parse(v[1], CultureInfo.InvariantCulture);
        double C = double.Parse(v[2], CultureInfo.InvariantCulture);

        if (A == 0){
            Console.WriteLine("Impossivel calcular");
        }    
        else if (A != 0.0){
            delta = Math.Pow(B, 2) - (4 * A * C);
            if (delta == 0 || delta < 0){
                Console.WriteLine("Impossivel calcular");
            }
            else {
                x1 = ((-B) + Math.Sqrt(delta)) / (2.0 * A);
                x2 = ((-B) - Math.Sqrt(delta)) / (2.0 * A);
                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
            
    }
}
