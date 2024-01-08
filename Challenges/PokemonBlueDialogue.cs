namespace CSharpIntroProg.Challenges;

public class PokemonBlueDialogue
{
    static string name = string.Empty;
    static string rival = string.Empty;

    public static void Execute()
    {
        IntroDialogue();
        PlayerDialogue();
        RivalDialogue();
        FinalDialogue();
    }

        private static void IntroDialogue()
    {
        PrintAndWait("Olá pessoal! Bem vindos ao mundo Pokémon!");
        PrintAndWait("Sou Carvalho. Pode me chamar de POKÉMON PROF!");
        PrintAndWait("Esse mundo é habitado por seres chamados Pokémon");
        PrintAndWait("Pessoas usam Pokémons pra cuidar ou em confrontos");
        PrintAndWait("Já eu...");
        PrintAndWait("Estudo Pokémons como profissão.");
        Interval();
    }

        private static void PlayerDialogue()
    {
        Console.Write("Primeiro, qual é o seu nome? --> ");
        name = ReadInput();
        PrintAndWait($"Tudo bem! Seu nome é: {name}");
        Interval();
    }

        private static void RivalDialogue()
    {
        PrintAndWait("Apresento o meu neto. Ele é o seu rival desde que vocês nasceram");
        Console.Write("... Eu esqueci o nome do rapaz! Você pode me lembrar? --> ");
        rival = ReadInput();
        PrintAndWait($"Claro! Eu me lembro agora! O nome dele é: {rival}");
        Interval();
    }

    private static void FinalDialogue()
    {
        PrintAndWait($"{name}!");
        PrintAndWait("Ache todos os Pokémons lendários desse mundo!");
        Console.WriteLine("Um mundo de aventuras começa agora!");
    }

    private static string ReadInput()
    {
        string? value = Console.ReadLine();
        value = value?.Trim();
        return value ?? "Não especificado";
    }

    private static void Interval()
    {
        Console.WriteLine();
        Console.WriteLine("-------------------");
        Console.WriteLine();
    }

    private static void PrintAndWait(string message)
    {
        Console.WriteLine(message);
        Console.ReadKey();
    }
}