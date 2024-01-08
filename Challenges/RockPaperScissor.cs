namespace CSharpIntroProg.Challenges;

public class RockPaperScissor
{
    enum Options
    {
        Rock,
        Paper,
        Scissor
    }

    public static void Execute()
    {
        Utils.PrintAndWait($"Bem vindo ao {Options.Rock} {Options.Paper} {Options.Scissor} com uma IA!");
        Utils.PrintAndWait("Esse é o meu território, então você não tem chance.");
        Utils.PrintAndWait("(é sério, eu que fiz esse jogo)");
        Utils.Interval();

        Console.Write($"Escolha {Options.Rock} {Options.Paper} {Options.Scissor} --> ");
        bool success = Enum.TryParse<Options>(Console.ReadLine(), out var opt);

        if (success)
        {
            switch (opt)
            {
                case Options.Rock:
                    Console.WriteLine($"Eu escolhi {Options.Paper}. Você perdeu! =)");
                break;
                case Options.Paper:
                    Console.WriteLine($"Eu escolhi {Options.Scissor}. Você perdeu! =)");
                break;
                case Options.Scissor:
                    Console.WriteLine($"Eu escolhi {Options.Rock}. Você perdeu! =)");
                break;
                default:
                    Console.WriteLine("Não sei como lidar com essa opção");
                break;
            }
        }
        else
        {
            Console.WriteLine($"Você não sabe jogar {Options.Rock} {Options.Paper} {Options.Scissor}?");
        }
    }
}