int TestCase = int.Parse(Console.ReadLine());
int count = 0;
int iteration = 0;
char[] charInput = new char[TestCase];
char emptyChar = ' ';   
while (iteration < TestCase)
{
   
    for(int i = 0; i < charInput.Length; i++)
    {
        charInput[i] = Convert.ToChar(Console.Read());
        if (charInput[i] == emptyChar)
        {
            count++;
        }
        emptyChar = charInput[i];
        iteration++;
    }
    
}

Console.WriteLine(count);

