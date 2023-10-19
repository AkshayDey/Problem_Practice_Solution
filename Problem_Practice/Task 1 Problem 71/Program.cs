int TestCases;

TestCases = int.Parse(Console.ReadLine());
for(int i = 0; i <TestCases; i++)
{
    string inputString = Console.ReadLine();
    string substring = "";
    string outputString = "";
    int length = inputString.Length;
    int lengthOfSubstring;
    if(length > 10)
    {
        char headCharacter = inputString[0];
        char tailCharacter = inputString[length-1];
        substring = inputString.Substring(1,length-2);
        lengthOfSubstring = substring.Length;
        outputString += headCharacter.ToString() + lengthOfSubstring.ToString() + tailCharacter.ToString();
    }
    else
    {
        Console.Write(inputString);
    }
    Console.WriteLine(outputString);
}
