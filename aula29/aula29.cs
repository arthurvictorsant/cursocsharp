using System;

//Método construtor e destrutor

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;
    
    public Jogador(string n){  // Poderia usar o mesmo nome de variavel nos parametros porque são de escopos diferentesu
        energia = 100;
        vivo = true;
        nome = n;

    }
    ~Jogador(){
        Console.WriteLine("Jogador {0} foi destruido",nome);

    }

}

class Aula28{
    static void Main(){
        
        string nome1;
        Console.WriteLine("Digite o nome do jogador 1: ");
        nome1 = Console.ReadLine();

        Jogador j1 = new Jogador(nome1);  // O new vai reservar memória e alocar na variavel.
        Jogador j2 = new Jogador("Neymar");
        
        
        Console.WriteLine("Energia do jogador1: {0}. Nome do Jogador: {1}",j1.energia,j1.nome);
        Console.WriteLine("Energia do jogador1: {0}. Nome do Jogador: {1}",j2.energia,j2.nome);
    }
}