using System;

/*Struct. É um tipo ( NÃO É UMA CLASSE) que vai permitir o armazenamente de tipo de dados diferentes. 
 Pode ser usado com construtores.
 É uma forma mais simples do que classes, porém não pode herdar e ser herdada 
 */

struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo,string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info(){
        Console.WriteLine("Marca: {0}",this.marca);
        Console.WriteLine("Modelo: {0}",this.modelo);
        Console.WriteLine("Cor: {0}",this.cor);

    }

}

class Aula44{
    static void Main(){

        Carro c1 = new Carro("BMW","B9","BRANCO");
        Carro c2 = new Carro("AUDI","TT","VERDE");


        //c1.marca = "BMW";
        //c1.modelo = "B9";
        //c1.cor= "Branco";

        c1.info();

    }
}