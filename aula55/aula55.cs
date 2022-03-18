using System;
using System.Collections.Generic;

//Dicionarios.

class Aula55{
    static void Main(){

                // chave, valor 
        Dictionary <int,string> veiculos = new Dictionary<int, string>();

        veiculos.Add(10,"Carro");
        veiculos.Add(5,"Avião");
        veiculos.Add(0,"Navio");
        veiculos.Add(20,"Moto");
        veiculos.Add(15,"Patinete");            

        //veiculos.Clear(); -> Limpa o dicionario

        // veiculos.Remove(20); --> Remove a chave 20 da coleção


        Console.WriteLine("Tamanho do Dicionario: {0}",veiculos.Count); // Count é uma propriedade
        
        int chave =20;
        if(veiculos.ContainsKey(chave)){ // Verifica se a coleção contém a chave;
            Console.WriteLine("A chave {0} está na coleção",chave);
        } else{
            Console.WriteLine("A chave {0} NÃO está na coleção",chave);
        }

        veiculos[15] = "Bicicleta"; // Substitui o valor da chave 

        string valor ="Bicicleta";
        if(veiculos.ContainsValue(valor)){ // Verifica se a coleção contém o valor;
            Console.WriteLine("A valor {0} está na coleção",valor);
        } else{
            Console.WriteLine("A valor {0} NÃO está na coleção",valor);
        }
       
    

        foreach(KeyValuePair<int,string> v in veiculos){  //Imprimindo conteudo dos dicionarios (simples)
            Console.WriteLine(v);
            Console.WriteLine(v.Key);
            Console.WriteLine(v.Value);
            
        }
        
        Dictionary<int,string>.ValueCollection valores = veiculos.Values; // Imprimindo conteudo dos dicionarios
                                                                          // forma complexa ( não gostei )          

        foreach(string v in valores){
            Console.WriteLine(v);
        }


    }
}