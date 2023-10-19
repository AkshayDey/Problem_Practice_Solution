//string inputs = Console.ReadLine();
//var count = inputs.Distinct().Count();
//if(count % 2 == 0)
//{
//    Console.WriteLine("CHAT WITH HER!");
//}
//else
//{
//    Console.WriteLine("IGNORE HIM!");
//}

string inputs = Console.ReadLine();
char[] anotherInputs = new char[inputs.Length];
int count = 0;

for(int i = 0; i < inputs.Length; i++)
{
    anotherInputs[i] = inputs[i];
}

Array.Sort(anotherInputs);

for(int i = 1; i < inputs.Length; i++)
{
    if(anotherInputs[i] != anotherInputs[i-1] )
    {
        count++;
    }
}


if ((count+1) % 2 == 0)
{
    Console.WriteLine("CHAT WITH HER!");
}
else
{
    Console.WriteLine("IGNORE HIM!");
}