string[] allInputs = Console.ReadLine().Split(' ');
int LimakWeight = int.Parse(allInputs[0]);
int BobWeight = int.Parse(allInputs[1]);

int afterOneYearLimakWeight = 3 * LimakWeight;
int afterOneYearBobWeight = 2 * BobWeight;
int countforYear = 0;

while(true)
{
    if (afterOneYearLimakWeight > afterOneYearBobWeight)
    {
        countforYear++;
        break;
    }
    else
    {
        afterOneYearLimakWeight = 3 * afterOneYearLimakWeight;
        afterOneYearBobWeight   = 2 * afterOneYearBobWeight;
        countforYear++;
    }
}

Console.WriteLine(countforYear);
