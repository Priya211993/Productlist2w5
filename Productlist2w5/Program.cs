// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        List<string> products = new List<string>();

        Console.WriteLine("Enter product names. Type 'exit' when done.");

        while (true)
        {
            Console.Write("Product: ");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (IsExitCommand(input))
                break;

            if (!string.IsNullOrWhiteSpace(input))
            {
                products.Add(input);
            }
        }

        products.Sort();

        Console.WriteLine("\nSorted Product List (Uppercase):");

        foreach (var product in products)
        {
            Console.WriteLine(product.ToUpper());
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    static bool IsExitCommand(string input)
    {
        return input == "exit" || input == "exit " || input == " exit" || input == " exit ";
    }
}

