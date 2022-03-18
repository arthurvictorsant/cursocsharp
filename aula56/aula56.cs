using System;
using System.Collections.Generic;

//Coleção LinkedList. Lista duplamente encadeada

class Aula56{
    static void Main(){

        LinkedList <string> transp = new LinkedList<string>();

        // Adicionar elementos no inicio da lista
        transp.AddFirst("Carro"); 
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        // Adicionar elementos no final de lista
        transp.AddLast("Bicicleta");

        // Adicionar elementos antes de um item
        LinkedListNode<string>no;
        no = transp.FindLast("Navio").Next; // Apontar para o item após o Navio
        transp.AddBefore(no,"Patins");
        
        
        // Adicionar elementos após um item
        no = transp.FindLast("Carro");
        transp.AddAfter(no,"Patinete");

        //transp.Clear(); -> Limpar toda a lista

        if(transp.Find("Carro") == null){
            Console.WriteLine("Não encontrado");
        }else {
            Console.WriteLine("Elemento encontrado");
        }

        // Remover itens de uma lista           
        //transp.Remove("Motocicleta"); // Remove o valor passado
        //transp.RemoveFirst(); // Remove o primiero item
        //transp.RemoveLast(); // Remove o ultimo item


        foreach(string t in transp){
            Console.WriteLine("Transporte: {0}",t);

        }


    }
}