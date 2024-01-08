namespace CSharpIntroProg.Challenges;

public class ChooseYourGear
{
    public static void Execute()
    {
        PrintAndWait("Um apocalipse zumbi acabou de acontecer do nada na sua cidade");
        PrintAndWait("Você começa a correr e pega tudo que vê pela frente ...");
        Console.WriteLine();

        string[] choices = new string[3];
        choices[0] = GetInput("PANELA", "TRAVESSEIRO");
        choices[1] = GetInput("ARMA", "GAME BOY");
        choices[2] = GetInput("CAMISA", "BARRA DE CHOCOLATE");

        Console.WriteLine($"Suas escolhas foram: {choices[0]}, {choices[1]} e {choices[2]}");
    }

    private static string GetInput(string optionA, string optionB)
    {
        string value = string.Empty;
        Console.WriteLine($"Você se depara com os seguintes itens: 1:{optionA} e 2:{optionB}");
        Console.WriteLine($"Para pegar o item, digite o número correspondente");
        bool success = int.TryParse(Console.ReadLine(), out var input);
        if (success && input == 1)
        {
            value = optionA;
        }
        else if (success && input == 2)
        {
            value = optionB;
        }
        else
        {
            value = "Entrada de dados incorreta";
        }

        return value;
    }

    private static void PrintAndWait(string message)
    {
        Console.WriteLine(message);
        Console.ReadKey();
    }
}