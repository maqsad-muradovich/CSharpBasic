int countTry = 1;
int userScore = 100;
string[] words = { "Malika", "Aziz", "Sardor", "Jasur", "Sarvar"};
string randomWord = GetRandomWord(words).ToLower();
string secretWord = "";
string UserInput = "";

for (int i = 0; i < randomWord.Length; i++)
{
    secretWord += '*';
}

Console.WriteLine("Assalomu aleykum hurmatli ishtirokchi,\n" +
                 "'Quiz Game' oyniga xush kelibsiz, oyin qoydalari bilan tanishtirsam)\n" +
                 "Sizning 100 balingiz bor va har bir hato javob uchun 10 balldan mahrum bo'lasiz.\n" +
                 "Agar butun so'zni topgan bolsangiz shunchaki: !!!(3ta undob belgisi)ni qoldiring,\n" +
                 "aks ho'lda hariflarni birma bir kiritib bo'rsangiz bo'ladi.");

while (userScore > 0)
{
    Console.Write($"{countTry}chi urinish\nTaxminingizni kiriting: ");
    UserInput = Console.ReadLine();
    UserInput.ToLower();

    if (UserInput != "!!!")
    {
        if (char.IsLetter(UserInput[0]))
        {
            if (IsLetterExists(UserInput[0], randomWord))
            {
                for (int i = 0; i < randomWord.Length; i++)
                {
                    if(UserInput[0] == randomWord[i])
                    {
                        secretWord = secretWord.Substring(0, i) + UserInput[0] + secretWord.Substring(i + 1);
                    }
                }
            }
            else{
                userScore-=10;
            }
        }
        else
        {
            userScore -= 10;
        }
        Console.WriteLine(secretWord);
        Console.WriteLine($"Sizning balingiz{userScore}");
    }
    else
    {
        Console.WriteLine("So'zni kirintg: ");
        UserInput = Console.ReadLine();
        UserInput.ToLower();
    }

    if(secretWord == randomWord){
        Console.WriteLine("Siz yuttingiz!");
        break;
    }
    if(UserInput==randomWord){
        Console.WriteLine("Juda go'zal");
        break;
    }

    countTry += 1;
}

if (userScore == 0)
{
    Console.WriteLine("Oyin tugadi)");
}



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