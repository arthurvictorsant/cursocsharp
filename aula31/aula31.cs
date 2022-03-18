using System;

// Classe static, ela é fixa e vai valer pra todo o sistema

static public class Jogador{
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void iniciar (string n,int e, bool v){ 
        energia = e;
        vivo = v;
        nome = n;

    }

    static public void info(){
        Console.WriteLine("Nome jogador.... {0}",nome);
        Console.WriteLine("Energia jogador.... {0}",energia);
        Console.WriteLine("Estado jogador.... {0}\n",vivo);
}

}

class Inimigo{

    static public bool alerta; // Vai valer para todo o sistema
    public string nome;

    public Inimigo(string n){ //construtor
        alerta = false;
        nome = n;
    }

    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("------------------------");

    }
}


class Aula30{
    static void Main(){
        
        Jogador.iniciar("Bruno",50,true);
        Jogador.info();    
        
        
        Inimigo i1= new Inimigo("Doido");
        Inimigo i2 = new Inimigo("Maluco");
        Inimigo i3 = new Inimigo("Pirado");

        Inimigo.alerta = true;  // Porque é static, vai valer para todos os Inimigos

        i1.info();
        i2.info();
        i3.info();
    }
}