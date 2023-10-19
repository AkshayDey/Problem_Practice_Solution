namespace BalancedParanthesesStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] exp = { '{', '(', ')', '}', '[', ']' };

            BalancedBrackets balancedBrackets = new BalancedBrackets();
            // Function call

            if (balancedBrackets.areBracketsBalanced(exp))
                Console.WriteLine("Balanced ");
            else
                Console.WriteLine("Not Balanced ");
        }
    }
}