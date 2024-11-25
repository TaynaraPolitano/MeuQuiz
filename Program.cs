using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Perguntas e respostas
        List<string> perguntas = new List<string> {
            "Qual foi a última coisa que comemos juntos?",
            "Onde foi que transamos pela última vez?",
            "Que dia nos conhecemos pessoalmente?",
            "Qual a cor do vestido que você estava usando quando nos conhecemos?",
            "O que ganhamos de presente do Djo?",
            "Qual o nome do duende que eu te dei?",
            "Qual o nome do duende que você me deu?",
            "Qual sabor de corote eu detesto?",
            "Qual o meu sabor de corote favorito?"
        };
        
        List<string> respostasCorretas = new List<string> {
            "Comida Japonesa",
            "Na praia",
            "16 de novembro",
            "Rosa",
            "Uma calça de moletom",
            "Tonho",
            "Brino",
            "Canelinha",
            "Melancia"
        };

        int pontuacao = 0;

        // Laço de repetição para perguntar
        for (int i = 0; i < perguntas.Count; i++)
        {
            Console.WriteLine(perguntas[i]);
            string respostaUsuario = Console.ReadLine();

            // Comparação das respostas
            if (respostaUsuario.ToLower() == respostasCorretas[i].ToLower())
            {
                pontuacao++;
            }
        }

        // Resultado final
        Console.WriteLine($"Você acertou {pontuacao} de {perguntas.Count} perguntas!");

        if (pontuacao == perguntas.Count)
        {
            Console.WriteLine("Uau, o papi sabe das coisas!");
        }
        else if (pontuacao >= perguntas.Count / 2)
        {
            Console.WriteLine("Mais ou menos, papi, dá pra melhorar!");
        }
        else
        {
            Console.WriteLine("Que mico! Não sabe nada!!!!!!!! ");
        }
    }
}
