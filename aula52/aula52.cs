using System;

// Exeções pt1


class Aula52{
    static void Main(){

        int n1,n2,res;
        res = n1 = n2 =0 ; // inicializando todas a variaveis na mesma linha

        n1 = 10;
        n2 = 0;

        try {
        res = n1/n2; // Ao captar um erro, o "try" automaticament chama o "catch"
        Console.WriteLine("{0}/{1} = {2}",n1,n2,res);
        }catch(Exception e){ //Captura o erro em "e"
            Console.WriteLine("ERRO: {0}",e.Message);
            Console.WriteLine("Ex: {0}",e);
            Console.WriteLine("Ex: {0}",e.GetType());
        }

        


    }
}