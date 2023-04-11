using System;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace JogoDePerguntas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pontos_total = 0;
            string resposta, resposta_div;
            int resposta_numero;
            

            Console.WriteLine("Bem-vindo ao jogo de perguntas e respostas do TurtleBlue!");
            Console.WriteLine("Lembre-se de digitar as respostas sem espaço!\n");
            Console.WriteLine("Pressione uma tecla para jogar!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Pergunta 1: Qual a capital do Brasil?");
            resposta = Console.ReadLine();    
            
            if (resposta == "Brasilia" || resposta == "Brasília" || resposta == "brasília" || resposta == "brasilia")
            {
                Console.WriteLine("\nParabéns, você acertou e conseguiu 20 pontos!");
                Console.ReadLine();
                pontos_total = pontos_total + 20;
            }
            else
            {
                Console.WriteLine("\nInfelizmente você errou. :(");
                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Pergunta 2: Qual o resultado da multiplicação 5x5?");
            resposta_numero = Convert.ToInt32(Console.ReadLine());

            if (resposta_numero == 25)
                {
                Console.WriteLine("\nParabéns, você acertou e conseguiu mais 20 pontos!");
                Console.ReadLine();
                pontos_total = pontos_total + 20;
            }
            else
            {
                Console.WriteLine("\nInfelizmente você errou. :(");
                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Pergunta 3: Qual o resultado da divisão 8/5?");
            resposta_div = (Console.ReadLine());

            if (resposta_div == "1.6" || resposta_div == "1,6")
            {
                Console.WriteLine("\nParabéns, você acertou e conseguiu mais 20 pontos!");
                Console.ReadLine();
                pontos_total = pontos_total + 20;
            }
            else
            {
                Console.WriteLine("\nInfelizmente você errou. :(");
                Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("Parabéns, sua pontuação foi de: " +pontos_total);
            Console.WriteLine("\n\nPressione alguma tecla para encerrar");
            Console.ReadLine();
        }
    }
}