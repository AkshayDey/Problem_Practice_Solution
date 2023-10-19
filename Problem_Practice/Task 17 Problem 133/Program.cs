string input = Console.ReadLine();
string instructionInput = "HQ9+";
int x = 0 , y = 0 ;
for (int i = 0; i < input.Length; i++)
{
   
    if (input[i] == 'H' || input[i] == 'Q' || input[i] == '9')
    {
        y++;
    }
    if( y > 0)
    {
        break;
    }

}
if(y == 1)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}