using System;
using System.Collections.Generic;

// List Part 1
class Aula57{
    static void Main(){

        List<string>carros = new List<string>();
        List<string>carros2 = new List<string>();
        string[] carros3 = new string[4];

        // Adicionando items na lista
        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        //Adiciona uma lista de elementos em uma lista
        carros2.AddRange(carros);

        //carros.Clear(); --> Limpando a lista

        // Verificando se um item está na lista
        if(carros.Contains("Golf")){
            Console.WriteLine("Está na lista");
        }else{
            Console.WriteLine("Não encontrado");
        }

        // Copiando uma List(coleção) para uma Array(nativa)
        carros.CopyTo(carros3);

        // Achando o indice de um valor
        string ca = "HRV";
        int pos = 0;
        pos = carros.IndexOf(ca); // ou carros.IndexOf("HRV");
        Console.WriteLine("Carro {0} está na posição {1}", ca, pos);


        foreach(string c in carros){
            Console.WriteLine("Carro: {0}",c);
        }
    }
}