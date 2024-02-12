string menu = @"Assalomu aleykum
Agar 1 ni bossangiz aylanani yuzasini topishingiz mumkin
Agar 2 ni bossangiz uchburchakni yuzasini topishingiz mumkin
Agar 3 ni bossangiz tortburchakni yuzasini topishingiz mumkin";

double S;

Console.WriteLine(menu);
string userInput = Console.ReadLine();

switch(userInput)
{
    case "1":
        Console.Write("Radius: ");
        userInput = Console.ReadLine();
        double radius = Convert.ToDouble(userInput);
        S = Math.PI * (radius * radius);
        Console.WriteLine("Aylanani yuzasi: " + S);
        break;
    case "2":
        Console.Write("Uzunlikni kiriting: ");
        userInput = Console.ReadLine();
        double b = Convert.ToDouble(userInput);
        Console.Write("Balandlikni kiriting: ");
        userInput = Console.ReadLine();
        double h = Convert.ToDouble(userInput);
        S = 0.5 * b * h;
        Console.WriteLine($"Uchburchakning yuzi: {S}");
        break;
    case "3":
        Console.Write("Uzunlikni kiriting: ");
        userInput = Console.ReadLine();
        double uzunlik = Convert.ToDouble(userInput);
        Console.Write("Balandlikni kiriting: ");
        userInput = Console.ReadLine();
        double balandlik = Convert.ToDouble(userInput);
        S = uzunlik * balandlik;
        Console.WriteLine($"To'rtburchakning yuzi: {S}");
        break;
    default:
        Console.WriteLine("Noto'g'ri tanlov.");
        break;
}
