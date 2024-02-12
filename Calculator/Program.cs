Console.Write("Birinchi sonni kiriting: ");
double son1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Amalni kiriting (+, -, *, /): ");
char amal = Convert.ToChar(Console.ReadLine());

Console.Write("Ikkinchi sonni kiriting: ");
double son2 = Convert.ToDouble(Console.ReadLine());

double natija = 0;
switch (amal)
{
    case '+':
        natija = son1 + son2;
        break;
    case '-':
        natija = son1 - son2;
        break;
    case '*':
        natija = son1 * son2;
        break;
    case '/':
        if (son2 != 0)
        {
            natija = son1 / son2;
        }
        else
        {
            Console.WriteLine("Xato: 0 ga bo'lib bo'linmadi!");
            return;
        }
        break;
    default:
        Console.WriteLine("Xato: Noto'g'ri amal!");
        return;
}

Console.WriteLine($"Natija: {natija}");
