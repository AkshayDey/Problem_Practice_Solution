string inputOne;
string inputTwo;

inputOne = Console.ReadLine(); /* For Taking input */
inputTwo = Console.ReadLine();

inputOne = inputOne.ToLower(); /*For converting the string into lowercase */
inputTwo = inputTwo.ToLower();

int count = 0;
int flag = 0;

for (int k = 0; k < inputOne.Length; k++)
{
    if (inputOne[k] != inputTwo[k])
    {
        char chOne = inputOne[k];
        char chTwo = inputTwo[k];
        if (chOne > chTwo)
        {
            flag = 1;
            break;
        }
        else if (chOne < chTwo)
        {
            flag = -1;
            break;
        }
    }
    else if (inputOne[k] == inputTwo[k])
    {
        flag = 0;
    }
}

if (flag == 1)
    Console.WriteLine(1);
else if (flag == -1)
    Console.WriteLine(-1);
else if (flag == 0)
    Console.WriteLine(0);