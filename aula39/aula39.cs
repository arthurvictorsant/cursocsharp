using System;

//Classes métodos abstratos. São classes de referencias, servem como base para outras classes que vão herdar
// a classe abstrata. 
// A classe herdeira é obrigada usar métodos da classe abstrata herdada.

abstract class Veiculo{ //Classe base abstrata
    protected int velMax;
    protected int velAtual;
    protected bool ligado;

    public Veiculo(){
        ligado = false;
        velAtual = 0;
    }
    public void setLigado(bool ligado){
        this.ligado = ligado;


    }

    public int getVelAtual(){
        return velAtual;
    }
    abstract public void aceleracao(int mult);


    }
class Carro:Veiculo{
        public Carro(){
            velMax = 120;
        }
        override public void aceleracao(int mult){
            velAtual += 10*mult;
        }
    }



class Aula39{
    static void Main(){

        Carro carro1 = new Carro();

        carro1.aceleracao(1);
        carro1.aceleracao(-1);

        Console.WriteLine(carro1.getVelAtual());

    }
}
// RESUMO: Uma classe abstrata, serve com base para outras que vão herdar. Não posso instanciar um objeto de 
// classe abstrata. Se eu crio metro que não são abstratos, eu preciso implementar a funcionalidade. 
// Métodos abstratos servem para dizer que a classe derivada precisar implementar o método abstrato.
