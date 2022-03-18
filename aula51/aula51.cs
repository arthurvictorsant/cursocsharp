using System;

// Argumento de entrada do programa


class Aula51{
    static void Main(string[] args){

        int res = 0;

        if(args.Length > 0){
            Console.WriteLine("Qntde de argumentos {0}", args.Length);
            for (int i = 0; i < args.Length; i++){
            
            Console.WriteLine("Argumento {0} : {1}", i, args[i]);

            res += int.Parse(args[i]); 
    
            }
            Console.WriteLine("Soma: {0}",res);
        } else {
            Console.WriteLine("Não foram passados argumentos");
        }

    }
}