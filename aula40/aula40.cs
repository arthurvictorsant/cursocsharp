using System;

//Selead class
sealed class Veiculo{
    public int x;

    public Veiculo(){
        x = 15;
    }

}


class Aula40{
    static void Main(){
        Veiculo v1 = new Veiculo();
        Console.WriteLine(v1.x);

        
    }
}