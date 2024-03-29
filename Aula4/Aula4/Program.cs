using System.Globalization;

int minutos;
double conta;

minutos = int.Parse(Console.ReadLine());

conta = 50.0;

if (minutos > 100)
{
    //conta = conta + (minutos - 100) * 2.0;
    conta += (minutos - 100) * 2.0; // Mesmo processo - atribuição cumulativa

    /*
       a += b (a = a + b)
       a -= b (a = a - b)
       a /= b (a = a / b)
       a *= b (a = a * b)
       a %= b (a = a % b)

    */

}

Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
Console.ReadLine();