namespace CSharpIntroProg.Challenges;

public class HalfLife3
{
    public static void Execute()
    {
        string bestGame = "Half Life 3";
        int attempts = 3;
        Console.WriteLine("Olá, eu sou um gênio e posso te conceder 3 desejos . . .");
        Console.WriteLine("Mas antes, você tem que responder uma pergunta. Você tem 3 tentativas");
        Console.WriteLine();

        Console.Write("Qual é o melhor jogo do Universo? -> ");
        string? input = Console.ReadLine();
        if (input != bestGame)
        {
            attempts--;
            Console.WriteLine($"Resposta errada! Você tem {attempts} tentativas");
        }
        else
        {
            Console.WriteLine($"Parabêns, {input} é o melhor jogo do Universo!");
            return;
        }

        Console.Write("Qual é o melhor jogo do Universo? -> ");
        input = Console.ReadLine();
        if (input != bestGame)
        {
            attempts--;
            Console.WriteLine($"Resposta errada! Sua batata está assando. Você tem {attempts} tentativas");
        }
        else
        {
            Console.WriteLine($"Parabêns, {input} é o melhor jogo do Universo!");
            return;
        }

        Console.Write("Qual é o melhor jogo do Universo? -> ");
        input = Console.ReadLine();
        if (input != bestGame)
        {
            attempts--;
            Console.WriteLine($"Você não sabe de nada mesmo... Vou procurar alguém que entende de jogos.");
        }
        else
        {
            Console.WriteLine($"Parabêns, {input} é o melhor jogo do Universo!");
        }
    }
}