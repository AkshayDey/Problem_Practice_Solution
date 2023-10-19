namespace ValidAnagram
{
    internal class Program
    {
        public static bool isAnagram(string s, string t)
        {
            
            if (s.Length == t.Length)
            {
                char[] charArrayOne = s.ToLower().ToCharArray();
                char[] charArrayTwo = t.ToLower().ToCharArray();

                Array.Sort(charArrayOne);
                Array.Sort(charArrayTwo);

                for(int i = 0; i < charArrayOne.Length; i++)
                {
                    if (charArrayOne[i].ToString() != charArrayTwo[i].ToString())
                    {
                        return false;
                    }
                }
                return true;
                
                  
                
            }
            else
            {
                return false;
            }
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string s = "rat";
            string t = "Car";

            bool output = isAnagram(s, t);
            Console.WriteLine(output);

        }
    }
}