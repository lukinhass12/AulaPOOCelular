using System;
using ProjetoPoo;

namespace ProjetoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular apple = new celular();
            apple.modelo = "iPhone8";
            apple.cor = "cor preta";
            apple.tamanho = "tamanho médio";
            apple.ligado = true;

            Console.WriteLine(apple.modelo);
            Console.WriteLine(apple.cor);
            Console.WriteLine(apple.tamanho);

            Console.WriteLine("Deseja ligar o celular");
            apple.ligado = apple.Ligar(Console.ReadLine());

            ///tomada de decisão///

            Console.WriteLine("Escolha uma das opções: Enviar mensagem (M), Fazer ligação (L) ou Desligar (D)");
            string resposta = Console.ReadLine();
            switch(resposta){
                case "D":
                Console.WriteLine("Desligando...");
                break;
                case "L":
                if(apple.ligado == true){
                    Console.WriteLine("Ligando...");
                    }else{
                        Console.WriteLine("Não foi possivel realizar a chamada. Certifique-se se seu Telefone está ligado.");
                        }
                break;
                case "M":
                if(apple.ligado == true){
                    Console.WriteLine("Digite sua mensagem:");
                    string respostaMensagem = Console.ReadLine();
                }else{
                     Console.WriteLine("Não foi possivel mandar mensagem. Certifique-se se seu Telefone está ligado");
            }
                break;
                default:
                Console.WriteLine("Opção não encontrada");
                break;

        }
    }
}

    internal class celular : Celular{}
    }