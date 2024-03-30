using System;

class URI {

    static void Main(string[] args) {

        string[] v = Console.ReadLine().Split(' ');
        int A = int.Parse(v[0]);
        int B = int.Parse(v[1]);

        if (B % A == 0 || A % B == 0){
            Console.WriteLine("Sao Multiplos");
        }
        else{
            Console.WriteLine("Nao sao Multiplos");
        }

    }

}

/*

    dif = B / A; // Se for multiplos = resultado inteiro

    if (dif * A == B){ // Multiplicando resultado dif, se for multiplo irá resultar na variavel B, se der numero decimal a multiplicação não resultará na variável B

        Console.WriteLine("Sao Multiplos");
    }
    else {
        Console.WriteLine("Nao sao Multiplos");
    }
    MINHA RESOLUÇÃO PRIMÁRIA

*/