/*

    Programa tem que ler duas entradas que são respectivamente nota 1 e nota 2 de um aluno. Se for menor que 60.00 (reprovado)
    
    Duas entradas double

*/
using System;
using System.Globalization;


// MINHA RESOLUÇÃO

double nota1, nota2, total_nota;

nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

total_nota = nota1 + nota2;

if (total_nota > 60.00) {
    Console.WriteLine("NOTA FINAL = " + total_nota.ToString("F1", CultureInfo.InvariantCulture));
}
else {
    Console.WriteLine("NOTA FINAL = " + total_nota.ToString("F1", CultureInfo.InvariantCulture));
    Console.WriteLine("REPROVADO");
}
// ------------------------------------------------------------------------------------------------

// RESOLUÇÃO PROFESSOR

nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

total_nota = nota1 + nota2;

Console.WriteLine("NOTA FINAL = " + total_nota.ToString("F1", CultureInfo.InvariantCulture));

if (total_nota < 60.00){
    Console.WriteLine("REPROVADO");
}


Console.ReadLine();