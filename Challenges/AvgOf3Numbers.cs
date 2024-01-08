namespace CSharpIntroProg.Challenges;

public class AvgOf3Numbers
{
    public static void Execute()
    {
        int noteA = PrintAndGetInput("Insira a primeira nota -> ");
        int noteB = PrintAndGetInput("Insira a segunda nota -> ");
        int noteC = PrintAndGetInput("Insira a terceira nota -> ");

        float avg = (noteA + noteB*2 + noteC*3) / 6.0f;
        Console.WriteLine($"Média com peso (1, 2, 3): {avg}");

        Console.WriteLine($"Aluno passou: {avg >= 60.0f}");
    }

    private static int PrintAndGetInput(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }
}