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
        Utils.PrintAndWait("Olá pessoal! Bem vindos ao mundo Pokémon!");
        Utils.PrintAndWait("Sou Carvalho. Pode me chamar de POKÉMON PROF!");
        Utils.PrintAndWait("Esse mundo é habitado por seres chamados Pokémon");
        Utils.PrintAndWait("Pessoas usam Pokémons pra cuidar ou em confrontos");
        Utils.PrintAndWait("Já eu...");
        Utils.PrintAndWait("Estudo Pokémons como profissão.");
        Utils.Interval();
    }

        private static void PlayerDialogue()
    {
        Console.Write("Primeiro, qual é o seu nome? --> ");
        name = ReadInput();
        Utils.PrintAndWait($"Tudo bem! Seu nome é: {name}");
        Utils.Interval();
    }

        private static void RivalDialogue()
    {
        Utils.PrintAndWait("Apresento o meu neto. Ele é o seu rival desde que vocês nasceram");
        Console.Write("... Eu esqueci o nome do rapaz! Você pode me lembrar? --> ");
        rival = ReadInput();
        Utils.PrintAndWait($"Claro! Eu me lembro agora! O nome dele é: {rival}");
        Utils.Interval();
    }

    private static void FinalDialogue()
    {
        Utils.PrintAndWait($"{name}!");
        Utils.PrintAndWait("Ache todos os Pokémons lendários desse mundo!");
        Console.WriteLine("Um mundo de aventuras começa agora!");
    }

    private static string ReadInput()
    {
        string? value = Console.ReadLine();
        value = value?.Trim();
        return value ?? "Não especificado";
    }
}