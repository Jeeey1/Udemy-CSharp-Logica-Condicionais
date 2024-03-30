      /*
        Condições verdadeiras
        B > C
        D > A
        C + D > A + B
        C && D > 0
        A % 2 = 0
      */

using System; 

class URI {

    static void Main(string[] args) { 


        string[] v = Console.ReadLine().Split(' ');
        int A = int.Parse(v[0]);
        int B = int.Parse(v[1]);
        int C = int.Parse(v[2]);
        int D = int.Parse(v[3]);

        if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0){
          Console.WriteLine("Valores aceitos");
        }
        else {
          Console.WriteLine("Valores nao aceitos");
        }
    }

}

/*

       if (B > C && D > A){
          if ((C + D) > (A + B)){
            if (C > 0 && D > 0){
              if (A % 2 == 0){
                Console.WriteLine("Valores aceitos");
              }
            }
          }
        }
        else {
          Console.WriteLine("Valores nao aceitos");
        }

        MINHA RESOLUÇÃO - POR ALGUM MOTIVO AQUI RODOU CERTO COM O QUE PEDIU A QUESTÃO POREM DEU COMO ERRADO "20% WRONG AWNSER"
*/