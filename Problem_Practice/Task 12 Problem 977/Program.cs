string[] allInputs = Console.ReadLine().Split(' ');
int firstInput = int.Parse(allInputs[0]);
int steps = int.Parse(allInputs[1]);
for (int i = 1; i <= steps; i++)
{
    int lastdigit = firstInput % 10;
    if(lastdigit == 0)
    {
        firstInput = firstInput/10;
    }
    else
    {
        firstInput = firstInput - 1 ;
    }
}
Console.WriteLine(firstInput);