namespace BaseballProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] inputValues = { "-60", "D", "-36", "30", "13", "C", "C", "-33", "53", "79" };

            // C stands for Cancelling the previous input
            // D stands for doubling the previous input like 5 * 2 = 10 [5, 10]
            // + stands for addition of previous two inputs [5, 10, 15]
            Console.WriteLine(solution.CalPoints(inputValues));
        }
    }
}