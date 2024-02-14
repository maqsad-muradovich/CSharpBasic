decimal[] ieltsScore = new decimal[4];

Console.Write("Speaking: ");
ieltsScore[0] = Convert.ToDecimal(Console.ReadLine());

Console.Write("Reading: ");
ieltsScore[1] = Convert.ToDecimal(Console.ReadLine());

Console.Write("Listening: ");
ieltsScore[2] = Convert.ToDecimal(Console.ReadLine());

Console.Write("Writing: ");
ieltsScore[3] = Convert.ToDecimal(Console.ReadLine());

decimal averageScore = ieltsScore.Avarge();
decimal remainder = averageScore - (int)averageScore

switch (remainder)
{
    case decimal r when r < 0.25m:
        remainder = 0;
        break;
    case decimal r when r < 0.75m:
        remainder = 0.5m;
        break;
    default:
        remainder = 1;
        break;
}

averageScore = (int)averageScore + remainder;

Console.WriteLine($"Average score: {averageScore}");
