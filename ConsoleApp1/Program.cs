
using System;

class Program  
{
    static void Main()

    {
        while (true) // Loop infinito para manter o programa em execução até que o usuário escolha sair
        {
            Console.BackgroundColor = ConsoleColor.Blue; // Define a cor de fundo
          
            Console.WriteLine("Escolha uma operação"); // Mostra as operações
            Console.WriteLine("1= Soma");
            Console.WriteLine("2= Subtração");
            Console.WriteLine("3= Multiplicação");
            Console.WriteLine("4= Divisão");
            Console.WriteLine("0= Sair");

            if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 0 || opcao > 4)  // Verifica se a entrada do usuário não é um número válido ou está fora do intervalo de opções
            {
                Console.WriteLine("Opção inválida, por favor escolha uma opção válida!");
                continue; // Retorna ao início do loop para que o usuário escolha uma opção válida
            }
            if (opcao == 0)
            {
                Console.WriteLine("Saindo");
                break;  // Se o usuário escolher sair, exibe uma mensagem e encerra o loop
            }

            Console.Write("Digite o primeiro número: "); // Solicita ao usuário que digite o primeiro número
            double num1 = double.Parse(Console.ReadLine()); // Lê e converte o primeiro número para double

            Console.Write("Digite o segundo número: "); // Solicita ao usuário que digite o segundo número
            double num2 = double.Parse(Console.ReadLine()); // Lê e converte o segundo número para double

            double resultado = 0; // Inicializa a variável resultado com 0

            switch (opcao) // Estrutura de seleção para determinar qual operação realizar com base na escolha do usuário
            {
                case 1:
                    resultado = num1 + num2; // Soma os dois números
                    break;
                case 2:
                    resultado = num1 - num2; // Subtrai o segundo número do primeiro
                    break;
                case 3:
                    resultado = num1 * num2; // Multiplica os dois números
                    break;
                case 4:
                    if (num2 != 0) // Verifica se o segundo número não é zero (para evitar divisão por zero)
                    {
                        resultado = num1 / num2; // Divide o primeiro número pelo segundo
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero."); // Exibe uma mensagem de erro se houver divisão por zero
                        continue; // Retorna ao início do loop para que o usuário insira outro número válido
                    }
                    break;
            }

            Console.WriteLine("Resultado: " + resultado); // Exibe o resultado da operação
        }
    }

    private static void SetConsoleScreenBufferInfoEx(Console console, object csbe)
    {
        throw new NotImplementedException();
    }
}