using System;
//Classes
// Se não usar nenhum modificador, ela é public
public class Jogador{
    public int energia = 100;
    public bool vivo = true;

}

class Aula28{
    static void Main(){
        Jogador j1 = new Jogador();  // O new vai reservar memória e alocar na variavel.
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 50;
        Console.WriteLine("Energia do jogador1: {0}",j1.energia);
        Console.WriteLine("Energia do jogador1: {0}",j2.energia);
    }
}