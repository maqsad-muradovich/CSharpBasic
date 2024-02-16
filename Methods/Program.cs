void ShowMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Triangle");
        Console.WriteLine("2. Square");
        Console.WriteLine("3. Exit");
    }

void DrawSquare()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(new string('*', size));
        }
    }

void DrawTriangle()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(new string('* '));
    }
}

do
{
    ShowMenu();
    Console.Write("Tanlovingizni kiriting: ");
    choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            DrawTriangle();
            break;
        case "2":
            DrawSquare();
            break;
        case "3":
            Console.WriteLine("Hayr!)");
            break;
        default:
            Console.WriteLine("Bunday variant yo'q. Boshqa variant kiritnig!");
            break;
    }
} while (choice != "3");