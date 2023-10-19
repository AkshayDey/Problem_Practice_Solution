
string[] allInputs = Console.ReadLine().Split(' ');

int inputK = int.Parse(allInputs[0]);
int inputN = int.Parse(allInputs[1]);
int inputW = int.Parse(allInputs[2]);

int resultOne = 0;
int sum = 0;
int borrowAmount = 0;

for(int i = 1; i <= inputW; i++)
{
    resultOne = i * inputK;
    sum += resultOne;
}
// If he doesn't have to borrow money, output 0.
if (sum <= inputN)
{
    Console.WriteLine(0);
}
else
{
    borrowAmount = sum - inputN;
    Console.WriteLine(borrowAmount);
}



