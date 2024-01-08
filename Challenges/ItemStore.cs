namespace CSharpIntroProg.Challenges;

public class ItemStore
{
    private static string[] storeInventory = new string[] {"Sword", "Shield", "Bow"};
    private static string[] playerInventory = new string[5];
    private static int playerCoins = 5;

    public static void Execute()
    {
        Utils.PrintAndWait("Seja bem vindo a minha loja!");
        Utils.PrintAndWait($"Vejo aqui que você possui {playerCoins} moedas! Cada item meu vale 1 moeda.");

        while (playerCoins > 0)
        {
            Console.WriteLine("Temos as seguintes opções:");
            ShowInventory(storeInventory);
            Console.Write("Qual item você deseja comprar? --> ");

            int input = GetInput();

            if (input != -1)
            {
                AddItem(input);
            }
            else
            {
                Utils.PrintAndWait("Valor inválido! Digite o valor correspondente.");
            }
        }

        Utils.PrintAndWait("Os itens escolhidos foram:");
        ShowInventory(playerInventory);
    }

    private static int GetInput()
    {
        int value = -1;

        bool success = int.TryParse(Console.ReadLine(), out var input);
        if (success && input >= 1 && input <= storeInventory.Length)
        {
            value = input - 1;
        }

        return value;
    }

    private static void AddItem(int itemId)
    {
        for (int i = 0; i < playerInventory.Length; i++)
        {
            if (playerInventory[i] is null)
            {
                playerInventory[i] = storeInventory[itemId];
                playerCoins--;
                Console.WriteLine($"Você comprou {storeInventory[itemId]} por 1 moeda.");
                Console.WriteLine($"Ainda lhe resta um total de: {playerCoins}");
                break;
            }
        }
    }

    private static void ShowInventory(string[] inventory)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (i != inventory.Length - 1)
            {
                Console.Write($"{i+1}:{inventory[i]}, ");
            }
            else
            {
                Console.Write($"{i+1}:{inventory[i]}\n");
            }
        }
    }
}