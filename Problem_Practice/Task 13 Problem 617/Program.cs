int friendCoordinate = int.Parse(Console.ReadLine());
int p = 0, q = 0, r = 0, s = 0, t = 0, u = 0;
p = friendCoordinate / 5;
q = friendCoordinate % 5;
if(q % 4 == 0)
{
    r = q / 4;

}
else if(q % 3 == 0)
{
    s = q / 3;
}
else if (q % 2 == 0)
{
    t = q / 2;
}
else if(q % 1 == 0)
{
    u = q / 1;
}

Console.WriteLine(p+r+s+t+u);
