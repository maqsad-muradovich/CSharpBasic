string GetUserInputWithPrompt(string str = "default"){
    if(str!="default"){
        Console.Write(str+" ");
    }
    return Console.ReadLine();
}

string str = input("Qiymat: ");
Console.WriteLine(str);