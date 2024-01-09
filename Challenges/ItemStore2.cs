namespace CSharpIntroProg.Challenges;

public class ItemStore2
{
    private static List<int> storePrices = new List<int> {1, 3, 3};
    private static List<string> storeInventory = new List<string> {"Sword", "Shield", "Bow"};
    private static List<string> playerInventory = new List<string>();
    private static int playerCoins = 5;

    public static void Execute()
    {
        Utils.PrintAndWait("Seja bem vindo a minha loja!");
        Utils.PrintAndWait($"Vejo aqui que você possui {playerCoins} moedas!");

        while (playerCoins > 0)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Temos as seguintes opções:");
            ShowStoreInventory();
            Console.Write("Qual item você deseja comprar? --> ");

            int input = GetInput();

            if (input != -1)
            {
                bool canBuy = CheckBalance(input);
                if (canBuy)
                {
                    AddItem(input);
                }
                else
                {
                    Console.WriteLine($"O item {storeInventory[input]} custa: {storePrices[input]}$.");
                    Console.WriteLine($"Você possui apenas: {playerCoins}$.");
                }
                
            }
            else
            {
                Utils.PrintAndWait("Valor inválido! Digite o valor correspondente.");
            }
        }

        Utils.PrintAndWait("Os itens escolhidos foram:");
        ShowPlayerInventory();
    }

    private static int GetInput()
    {
        int value = -1;

        bool success = int.TryParse(Console.ReadLine(), out var input);
        if (success && input >= 1 && input <= storeInventory.Count)
        {
            value = input - 1;
        }

        return value;
    }

    private static bool CheckBalance(int itemId)
    {
        return playerCoins >= storePrices[itemId];
    }

    private static void AddItem(int itemId)
    {
        playerInventory.Add(storeInventory[itemId]);
        playerCoins -= storePrices[itemId];
        Console.WriteLine($"Você comprou {storeInventory[itemId]} por {storePrices[itemId]}$.");
        Console.WriteLine($"Ainda lhe resta um total de: {playerCoins}$.");
    }

        private static void ShowStoreInventory()
    {
        for (int i = 0; i < storeInventory.Count; i++)
        {
            if (i != storeInventory.Count - 1)
            {
                Console.Write($"{i+1}:{storeInventory[i]} por {storePrices[i]}$, ");
            }
            else
            {
                Console.Write($"{i+1}:{storeInventory[i]} por {storePrices[i]}$\n");
            }
        }
    }

    private static void ShowPlayerInventory()
    {
        for (int i = 0; i < playerInventory.Count; i++)
        {
            if (i != playerInventory.Count - 1)
            {
                Console.Write($"{i+1}:{playerInventory[i]}, ");
            }
            else
            {
                Console.Write($"{i+1}:{playerInventory[i]}\n");
            }
        }
    }
}