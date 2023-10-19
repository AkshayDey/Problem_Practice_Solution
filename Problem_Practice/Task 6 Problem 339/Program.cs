string input;
int tempValue;
int count = 0;
string[] splitString = new string[100];
input = Console.ReadLine();
input = input.Trim();
splitString = input.Split('+');
for (int j = splitString.Length - 1; j > 0; j--)
{
    for (int i = 0; i < j; i++)
    {
        if (int.Parse(splitString[i]) > int.Parse(splitString[i + 1]))
        {
            tempValue = int.Parse(splitString[i]);
            splitString[i] = splitString[i + 1];
            splitString[i + 1] = tempValue.ToString();
        }
    }
}

foreach (var items in splitString)
{
    
    int length = splitString.Length;
    Console.Write(items);
    if(count < length - 1)
    {
        Console.Write("+");
        count++;
    }

}

