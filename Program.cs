using System;

namespace ClassificacaoHeroi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dados do herói
            string nomeHeroi;
            int xpHeroi;
            string nivel = "";
            string continuar;

            Console.WriteLine("=== SISTEMA DE CLASSIFICAÇÃO DE HERÓIS ===\n");

            // Processa múltiplos heróis
            do
            {
                // Captura informações
                Console.Write("Digite o nome do herói: ");
                nomeHeroi = Console.ReadLine();

                Console.Write("Digite a quantidade de XP do herói: ");

                // Valida entrada de XP
                while (!int.TryParse(Console.ReadLine(), out xpHeroi))
                {
                    Console.WriteLine("Valor inválido! Digite apenas números (sem pontos ou vírgulas).");
                    Console.Write("Digite a quantidade de XP do herói: ");
                }

                // Classifica por faixa de XP
                if (xpHeroi < 1000)
                {
                    nivel = "Ferro";
                }
                else if (xpHeroi >= 1001 && xpHeroi <= 2000)
                {
                    nivel = "Bronze";
                }
                else if (xpHeroi >= 2001 && xpHeroi <= 5000)
                {
                    nivel = "Prata";
                }
                else if (xpHeroi >= 5001 && xpHeroi <= 7000)
                {
                    nivel = "Ouro";
                }
                else if (xpHeroi >= 7001 && xpHeroi <= 8000)
                {
                    nivel = "Platina";
                }
                else if (xpHeroi >= 8001 && xpHeroi <= 9000)
                {
                    nivel = "Ascendente";
                }
                else if (xpHeroi >= 9001 && xpHeroi <= 10000)
                {
                    nivel = "Imortal";
                }
                else if (xpHeroi >= 10001)
                {
                    nivel = "Radiante";
                }

                // Saída formatada
                Console.WriteLine($"\nO Herói de nome {nomeHeroi} está no nível de {nivel}\n");

                // Perguntar se deseja continuar
                Console.Write("Deseja classificar outro herói? (S/N): ");
                continuar = Console.ReadLine().ToUpper();
                Console.WriteLine();

            } while (continuar == "S");

            Console.WriteLine("Programa encerrado. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}