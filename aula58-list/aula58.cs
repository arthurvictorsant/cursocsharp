using System;
using System.Collections.Generic;

// List parte 2
class Aula59{
    static void Main(){

        List<string>carros = new List<string>();
        List<string>carros2 = new List<string>();
        string[] carros3 = new string[10];

        // Adicionando items na lista
        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        carros.Add("HRV");

        //Adiciona uma lista de elementos em uma lista
        carros2.AddRange(carros);

        //carros.Clear(); --> Limpando a lista

        // Verificando se um item está na lista
        if(carros.Contains("Golf")){
            Console.WriteLine("Golf Está na lista");
        }else{
            Console.WriteLine("Golf Não encontrado");
        }

        // Copiando uma List(coleção) para uma Array(nativa)
        carros.CopyTo(carros3);

        // Inserir items em uma List
        carros.Insert(1,"Cruze");

        // Remover items em uma List
       // carros.Remove("Argo");

        
        // Remover items pelo indice
      //  carros.RemoveAt(0);

        // Achando o indice de um valor
        string ca = "HRV";
        int pos = 0;
        pos = carros.IndexOf(ca); // ou carros.IndexOf("HRV");
        Console.WriteLine("Carro {0} está na posição {1}", ca, pos);

        // Achando o ultio indice de um valor

        int pos2 = carros.LastIndexOf("HRV");
        Console.WriteLine("Ultimo HRV esta na posição {0}",pos2);

        // Invertendo uma lista
        carros.Reverse();

        // Ordenando uma lista (ordem alfabetica nessa caso)
        carros.Sort();

        // Obtendo o tamanho da lista
        int tamanho = carros.Count;
        Console.WriteLine("Tamanho {0}",tamanho);

        // Obtendo capacidade e mudando a capacidade da lista
        int capa = carros.Capacity;
        carros.Capacity = 15;
        Console.WriteLine("Capacidade {0}",capa);



        foreach(string c in carros){
            Console.WriteLine("Carro: {0}",c);
        }
    }
}