using System.Globalization;

double A, B, C;

string[] v = Console.ReadLine().Split(' ');

A = double.Parse(v[0]);
B = double.Parse(v[1]);
C = double.Parse(v[2]);

if (A <= B) {
    Console.WriteLine("MENOR = " + A);
}
else if (B <= C) {
    Console.WriteLine("MENOR = "+ B);
}

else if (C <= A) {
    Console.WriteLine("Menor = " + C);
}
Console.ReadLine();