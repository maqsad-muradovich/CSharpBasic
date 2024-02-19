string GetRandomWord(string[] words)
{
    Random random = new Random();
    int randomIndex = random.Next(0, words.Length);
    return words[randomIndex];
}

bool IsLetterExists(char letter, string word)
{
    for (int i = 0; i < word.Length; i++)
    {
        if (letter == word[i])
            return true;
    }

    return false;
}

int countTry = 1;
int userScore = 100;
string[] words = { "Malika", "Aziz", "Sardor", "Jasur", "Sarvar" };
string randomWord = GetRandomWord(words);
string secretWord = "";
string UserInput = "";

for (int i = 0; i < randomWord.Length; i++)
{
    secretWord += '*';
}

Console.WriteLine(secretWord);


Console.WriteLine("Assalomu aleykum hurmatli ishtirokchi,\n" +
                 "'Quiz Game' oyniga xush kelibsiz, oyin qoydalari bilan tanishtirsam)\n" +
                 "Sizning 100 balingiz bor va har bir hato javob uchun 10 balldan mahrum bo'lasiz.\n" +
                 "Agar butun so'zni topgan bolsangiz shunchaki: !!!(3ta undob belgisi)ni qoldiring,\n" +
                 "aks ho'lda hariflarni birma bir kiritib bo'rsangiz bo'ladi.");

while (userScore)
{
    Console.Write($"{countTry}chi urinish\nTaxminingizni kiriting: ");
    UserInput = Console.ReadLine();

    if (UserInput != "!!!")
    {
        if (char.IsLetter(UserInput[0], randomWord)
        {
            Console.WriteLine("")
        }
        else
        {
            userScore -= 10;
        }
    }
    else
    {
        Console.WriteLine("So'zni kirintg: ")
        UserInput = Console.ReadLine();
        if (UserInput != randomWord)
        {
            userScore = 0;
            break;
        }
        else
        {
            Console.WriteLine("Siz yuttingiz!")
        }
    }

    countTry += 1;
}

if (countTry == 0)
{
    Console.WriteLine("Oyin tugadi)")
}