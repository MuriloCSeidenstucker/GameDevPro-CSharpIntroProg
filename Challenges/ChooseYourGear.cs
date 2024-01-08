namespace CSharpIntroProg.Challenges;

public class ChooseYourGear
{
    public static void Execute()
    {
        PrintAndWait("Um apocalipse zumbi acabou de acontecer do nada na sua cidade");
        PrintAndWait("Você começa a correr e pega tudo que vê pela frente ...");
        Console.WriteLine();

        string[] choices = new string[3];
        Console.WriteLine("Você se depara com os seguintes itens: 1:{} e 2:{}");
        Console.WriteLine($"Para pegar o item, digite o número referente à sua escolha");
    }

    private static void PrintAndWait(string message)
    {
        Console.WriteLine(message);
        Console.ReadKey();
    }
}