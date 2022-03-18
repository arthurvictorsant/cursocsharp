using System;
//THIS

class Calculos{
    public int v1;
    public int v2;

    public Calculos(int v1,int v2){
        this.v1 = v1;
        this.v2 = v2;
        // o this informa que a propriedade v1/v2 é a propriedade da classe(objeto pai) e não do construtor
    }
    
    public int Somar(){
        return v1+v2;
    }


}

class main{
    static void Main(){
        Calculos calculos = new Calculos(10,2);

        Console.WriteLine(calculos.Somar());

        
    }
}