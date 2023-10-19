string inputs = Console.ReadLine();
int length = inputs.Length;
char[] charInputs = new char[1001];
int count = 1;
for (int i = 0; i < length; i++)
{
    charInputs[i] = inputs[i];
}
//Array.Sort(charInputs);
for (int i = 0; i < charInputs.Length; i++)
{

    if (charInputs[i] == '0' && charInputs[i + 1] == '0')
    {
        count++;
        if (count == 7)
            break;

    }
    else if (charInputs[i] == '1' && charInputs[i + 1] == '1')
    {
        count++;
        if (count == 7)
            break;
    }
    else if (charInputs[i] == '1' && charInputs[i + 1] == '0')
    {
        count = 1;
    }
    else if (charInputs[i] == '0' && charInputs[i + 1] == '1')
    {
        count = 1;
    }
}

if (count >= 7)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}