class Program
{
    static void Main()
    {
        bool running = true;
        while (running)
        {
            PrintMenu();

            string input = Console.ReadLine();
            bool isInputValid = IsInputValid(input);
            if (isInputValid)
            {
                if (input == "0")
                {
                    return;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nDigite o primeiro numero: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("\nDigite o segundo numero: ");
                double num2 = double.Parse(Console.ReadLine());

                PrintOperation(input, num1, num2);
            }
            else
            {
                Console.WriteLine("Input inválido.");
            }
            Console.ReadLine();
        }
    }

    static void PrintMenu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nEscolha uma opção:\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("1= Soma");
        Console.WriteLine("2= Subtração");
        Console.WriteLine("3= Multiplição");
        Console.WriteLine("4= Divisão");
        Console.WriteLine("0= Sair");
    }

    static bool IsInputValid(string input)
    {
        if (int.TryParse(input, out int number))
        {
            return (number >= 0 && number <= 4);
        }
        return false;
    }
    static void PrintOperation(string input, double num1, double num2)
    {
        if (input == "4" && num2 == 0)
        {
            Console.WriteLine("Erro: divisão por 0.");
            return;
        }
        double result = input switch
        {
            "1" => num1 + num2,
            "2" => num1 - num2,
            "3" => num1 * num2,
            "4" => num1 / num2
        };

        Console.WriteLine($"\nResultado = {result}");
    }
}
