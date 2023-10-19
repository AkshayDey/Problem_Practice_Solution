
namespace BaseballProblem
{
    internal class Solution
    {
        public int CalPoints(string[] operations)
        {
            #region OldCode 
            //List<int> points = new List<int>();
            //int resultOutput = 0;         
            //for(int i = 0; i < operations.Length; i++) 
            //{
            //    if (operations[i] != "C" && operations[i] != "D" && operations[i] != "+")
            //    {
            //        points.Add(Convert.ToInt32(operations[i]));
            //    }
            //    else if (operations[i] == "C")
            //    {
            //        points.RemoveAt(i - 1);

            //    }
            //    else if (operations[i] == "D")
            //    {
            //        points.Add(points.Last() * 2);
            //    }
            //    else if (operations[i] == "+") 
            //    {
            //        int resultForAddition = 0;
            //        List<int> lastTwoElements = points.Skip(Math.Max(0, points.Count - 2)).Take(2).ToList();
            //        foreach (var allItems in lastTwoElements)
            //        {

            //            resultForAddition += allItems;
            //        }
            //        points.Add(resultForAddition);


            //    }
            //}
            //foreach (int point in points)
            //{
            //    resultOutput += point;
            //}
            //return resultOutput;
            #endregion

            #region stack
            Stack<int> StackIntItems = new Stack<int>();


            for(int i = 0; i < operations.Count(); i++)
            {
                if (operations[i] != "C" && operations[i] != "D" && operations[i] != "+")
                {
                    StackIntItems.Push(Convert.ToInt32(operations[i]));
                }

                else if (operations[i] == "C")
                {
                    StackIntItems.Pop();
                }
                else if (operations[i] == "D")
                {
                    
                    int lastItem = StackIntItems.Pop();
                    StackIntItems.Push(lastItem);
                    StackIntItems.Push(lastItem * 2);
                }
                else if (operations[i] == "+")
                {
                    int top = StackIntItems.Pop();
                    int newTop = top + StackIntItems.Peek();
                    StackIntItems.Push(top);
                    StackIntItems.Push(newTop);

                }
            }

            int result = 0;
            foreach(var resultOutput in StackIntItems)
            {
                result += resultOutput;
            }
            return result;
            #endregion
        }
    }
}
