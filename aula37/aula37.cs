using System;

// Ordem de execução de construtores, a ordem é : Base -> Derivada1 -> Derivada2
// Ou seja da Base para as derivadas

class Base{
    public Base(){
        Console.WriteLine("Construtor da classe base");
    }
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada1");
    }
}

class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada2 ");
    }
}

class Aula37{
    static void Main(){
        Derivada2 derivada2 = new Derivada2();

    }
}