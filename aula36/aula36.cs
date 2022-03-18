using System;

//Protected

class Veiculo{ //Base

    public int velAtual;
    private int velMax;  // SOMENTE pela classe BASE
    protected bool ligado; // Permite acesso ao membros pelas classes derivadas, mas SOMENTE pelas classes.

    public Veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }
    public bool getLigado(){
        return ligado;
    }
    public int getVelMax(){
        return velMax;
    }
}

class Carro:Veiculo{ // Derivada de veiculo
    public string nome;
    public Carro(string nome, int vm):base(vm){ // vm vai para velMax do construtor
        this.nome = nome;
        ligado = true;


    }
}

class Aula36{
    static void Main(){

          Carro carro = new Carro("Bonitão",120); 

          Console.WriteLine("Nom: {0}", carro.nome);
          Console.WriteLine("Vel.Maxima: {0}",carro.getVelMax()); 
          Console.WriteLine("Ligado: {0}",carro.getLigado());


    }
}