using System;

class Ex1{
    static void Main(){
        
         Console.WriteLine("Digite um numero:");

        int num = int.Parse(Console.ReadLine());

    
        if (num % 2 == 0){
            Console.WriteLine("O numero é par");

        } else {
            Console.WriteLine("O numero é impar");
        }

    }
}