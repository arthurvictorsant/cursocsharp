using System;

class Ex3{
    static void Main(){

        char operacao;
        int v1 ;
        int v2 ;
        int res = 0;    

        Console.WriteLine("Digite a operação");

        operacao = Convert.ToChar(Console.ReadLine());

        v1 = Convert.ToInt32(Console.ReadLine());
        v2 = Convert.ToInt32(Console.ReadLine());

        if (operacao == '+'){
            res = v1 + v2;
        } else if (operacao == '-'){
            res = v1 - v2;
        } else if ( operacao == '*'){
            res = v1 * v2;
        } else if (operacao == '/'){
            res  = v1/v2;
        } else{
            Console.WriteLine("Operação inválida");
        }

        Console.WriteLine(res);


    }
}