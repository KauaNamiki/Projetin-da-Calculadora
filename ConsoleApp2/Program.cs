
class program
{
    static void Main()
    {
       
        while (true)        
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEscolha uma opção:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1= Soma");
            Console.WriteLine("2= Subtração");
            Console.WriteLine("3= Multiplição");
            Console.WriteLine("4= Divisão");
            Console.WriteLine("0= Sair");

            if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 0 || opcao > 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Opção inválida, por favor selecione uma opção válida! \n ");
                continue;
            }
            if (opcao == 0)
            {   
                Console.WriteLine("saindo");
                break;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nDigite o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0;


            switch (opcao)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("ERRO. Divisão por zero");
                        continue;
                    }
                    break;
            }
            Console.WriteLine("\nResultado =" + resultado);
        }
    }
}
//Requisito 01
//Nossa calculadora deve ter a possibilidade de somar dois números
//Requisito 02 
//Nossa calculadora deve ter a possibilidade de fazer várias operações de soma
//Requisito 03 
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração
//Requisito 04 
//Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática
//Requisito 05 
//Nossa calculadora deve realizar as operações com "0"
//Requisito 06
//Nossa calculadora deve validar a opções do menu 
//Requisito 07
//Nossa calculadora deve realizar as operações com números com duas casas decimais