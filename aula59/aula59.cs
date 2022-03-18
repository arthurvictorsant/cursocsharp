using System;
using System.Collections.Generic;

// Queue (fila)
class Aula59{
    static void Main(){

            //string[] vs = {"Carro","Moto","Navio","Avião"};

            Queue<string>veiculos = new Queue<string>();

            // Adicionar elementos em uma queue, NO FINAL da fila
            veiculos.Enqueue("Carro"); // 
            veiculos.Enqueue("Moto");
            veiculos.Enqueue("Navio");
            veiculos.Enqueue("Avião");

            // Verificar se um elemento está na fila
            string v = "Avião";
            if(veiculos.Contains(v)){
                Console.WriteLine("Veiculo " + v + " encontrado");
            } else{
                Console.WriteLine("Veiculo não está na fila");
            }

            // Limpar a fila    
            //veiculos.Clear();

            // Retorna o primeiro elemento da fila e o elimina também, o retirando da fila
            //Console.WriteLine("Primeiro Veiculo " + veiculos.Dequeue() );
            //Console.WriteLine("Primeiro Veiculo " + veiculos.Dequeue() );

            // Retorna o elemento sem o eliminar
            Console.WriteLine("Primeiro elemento " + veiculos.Peek());

            // Contar a quantidade de elementos na fila
            Console.WriteLine("Tamanho fila:" + veiculos.Count);

        /* Retornar e remover todos os elementos
            foreach (string v in veiculos){
                v = veiculos.Dequeue;
                Console.WriteLine("Veiculo removido " + v);
            } */

            /* Para APENAS ler os elementos da fila
            foreach(string i in veiculos){
                Console.WriteLine("Veiculo " + i);
            }*/


            // OBS: Não é possivel trabalhar com indexadores em uma fila

            // É mais indicado trabalho com while do que com for em queue's

            while(veiculos.Count > 0){
                Console.WriteLine(veiculos.Dequeue());
            }
            Console.WriteLine("Tamanho fila: " + veiculos.Count);

    }
}