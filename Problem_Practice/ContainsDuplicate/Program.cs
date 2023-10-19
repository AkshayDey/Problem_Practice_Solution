using System.Security.Cryptography.X509Certificates;

namespace ContainsDuplicate
{
    internal class Program
    {
        public static bool ContainsDuplicate(int[] nums)
        {

            // 1st Solution >>>>  My Own

            //int arrayLength = nums.Length;
            //int count = 0;
            //List<int> list = new List<int>();
            //for(int i = 0; i < arrayLength; i++)
            //{
            //    list.Add(nums[i]);
            //}
            //list.Sort();
            //for(int i = 0; i < list.Count; i++) 
            //{
            //    if (i == list.Count - 1)
            //    {
            //        break;
            //    }

            //    if (list[i] == list[i+1])
            //    {

            //        count++;
            //    }

            //}
            //if (count > 0)
            //{
            //    return true;
            //}
            //else
            //{ return false; }


            // 2nd Solution

            //>>> 

            HashSet<int> result = new HashSet<int>();
            foreach (var num in nums)
            {
                if (result.Contains(num))
                {
                    return true;
                }
                else
                {
                    result.Add(num);
                }
            }

            return false;

        }


        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            ContainsDuplicate(nums);
        }
    }
}