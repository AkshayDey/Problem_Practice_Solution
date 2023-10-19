string input = Console.ReadLine();
int length = input.Length;
char[] allInputs = new char[length];
int countLowerCase = 0;
int countUpperCase = 0;
for(int i = 0; i < length; i++)
{
    allInputs[i] = input[i];
}
for(int j= 0; j < allInputs.Length; j++)
{
    if (char.IsLower(allInputs[j]))
    {
        countLowerCase++;
    }
    else if (char.IsUpper(allInputs[j]))
    {
        countUpperCase++;
    }
}
if(countLowerCase == countUpperCase)
{
    for(int k = 0; k < allInputs.Length; k++)
    {
        allInputs[k] = char.ToLower(allInputs[k]);
    }
}
else if (countLowerCase > countUpperCase)
{
    for (int k = 0; k < allInputs.Length; k++)
    {
        allInputs[k] = char.ToLower(allInputs[k]);
    }
}
else
{
    for (int k = 0; k < allInputs.Length; k++)
    {
        allInputs[k] = char.ToUpper(allInputs[k]);
    }
}

foreach (var resultOutput in allInputs)
{
    Console.Write(resultOutput);
}

