using System;
// Métodos virtuais, são métodos que tem o mesmo nome, em classes diferentes.

class Base{
    public Base(){
        Console.WriteLine("Construtor da classe base");
    }
    virtual public void info(){
        Console.WriteLine("Base");
    }
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada1");
    }
    override public void info(){
        Console.WriteLine("Derivada1");
    }
}

class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada2 ");
    }
    override public void info()
    {
        Console.WriteLine("Derivada2");
    }
}

class Aula38{
    static void Main(){
        
        Base Ref ; 
        Base b = new Base();
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        
        Ref = derivada1;
        Ref.info();
    }
}