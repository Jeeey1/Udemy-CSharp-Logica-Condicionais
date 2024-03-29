/*

    Sintaxe da Estrutura Condicional

    Simples:

    if (<condição>) {
        <comando1>
        <comando2>
    }

    Composta:

     if (<condição>) {
        <comando1>
        <comando2>
    }
    else {
        <comando3>
        <comando4>
    }

*/
int horas;

Console.WriteLine("Quantas horas são?: ");

horas = int.Parse(Console.ReadLine());



if (horas < 12){ 
    Console.WriteLine("Bom dia!");
}
else if (horas < 18) {
    Console.WriteLine("Boa tarde!");
}
else{
    Console.WriteLine("Boa noite!");
}


Console.ReadLine();
