Console.Write("Sonni kiriting: ");
int userInput = Convert.ToInt32(Console.ReadLine());
int CountDividers = 0;

for(int i = 2; i < userInput; i++){
    if(userInput%i==0)
        CountDividers++;
}

if(CountDividers==0)
    Console.WriteLine("Tub son");
else
    Console.WriteLine("Tub son emas!");