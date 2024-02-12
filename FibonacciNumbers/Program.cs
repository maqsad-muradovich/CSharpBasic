Console.Write("Sonni kiriting: ");
int userInput = Convert.ToInt32(Console.ReadLine());
int fiboNumber = 0;
int lastFiboNumber = 1;

for(int i = 2; i < userInput; i++){
    Console.Write(fiboNumber + " ");
    int temp = fiboNumber;
    fiboNumber = lastFiboNumber;
    lastFiboNumber = fiboNumber + temp;

}