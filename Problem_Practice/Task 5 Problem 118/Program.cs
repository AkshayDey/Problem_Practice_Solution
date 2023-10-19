string inputString, finalString;
inputString = Console.ReadLine();
inputString = inputString.ToLower();
finalString = "";
char toAdd = '.';
for(int i = 0; i < inputString.Length; i++)
{
    if (inputString[i] == 'a' || inputString[i] == 'e' || inputString[i] == 'o' || inputString[i] == 'u' || inputString[i] == 'i' || inputString[i] == 'y')
    {
       
        inputString = inputString.Replace(inputString[i].ToString(), string.Empty);
        i--;
    }  
}

for(int i = 0; i < inputString.Length; i++)
{
    finalString = toAdd.ToString() + inputString[i].ToString();
    Console.Write(finalString);
}


