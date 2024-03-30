using System;
using System.Globalization;

class URI {

    static void Main(string[] args) {

    string[] v = Console.ReadLine().Split(' ');
    
    int codigo = int.Parse(v[0]);
    int qtd = int.Parse(v[1]);

    double total;

    switch (codigo){
        case 1:
        total = 4.0 * qtd;
        break;
        case 2:
        total = 4.5 * qtd;
        break;
        case 3:
        total = 5.0 * qtd;
        break;
        case 4:
        total = 2.0 * qtd;
        break;
        default:
        total = 1.5 * qtd;
        break;
    }
    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

    }

}