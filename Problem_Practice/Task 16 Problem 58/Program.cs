string input = Console.ReadLine();
string outputResult = "hello";
int x = 0, y = 0;
for(int i = 0; i < input.Length; i++)
{
    if(y == 5)
    {
        break;
    }

    if (input[i] == outputResult[x])
    {
        x++;
        y++;
    }
   
}
if (y == 5)
{
    Console.WriteLine("YES");
}
else
    Console.WriteLine("NO");


