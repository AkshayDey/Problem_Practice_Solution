#region akshay's code
int Kase;
int valueOfx = 0;
int count = 0;
Kase = int.Parse(Console.ReadLine());
string[] inputs = new string[Kase];
for (int i = 0; i < Kase; i++)
{
    string? input = Console.ReadLine();
    inputs[i] = input;
    if (string.IsNullOrWhiteSpace(input) == false)
    {
        if (inputs[i] == "++X" || inputs[i] == "X++")
        {
            valueOfx++;
        }
        else if (inputs[i] == "--X" || inputs[i] == "X--")
        {
            valueOfx--;
        }
    }
}
Console.WriteLine(valueOfx);
#endregion



#region sayem

//int Kase;
//string input;
//int valueOfx = 0;
//Kase = int.Parse(Console.ReadLine());
//for (int i = 0; i < Kase; i++)
//{
//    input = Console.ReadLine();
//    if (input == "++X" || input == "X++")
//    {
//        valueOfx++;
//    }
//    else if (input == "--X" || input == "X--")
//    {
//        valueOfx--;
//    }
//}
//Console.WriteLine(valueOfx);
#endregion

