namespace Mouse_and_Cat
{
    using System.Collections.Generic;
    using System.IO;
   
    using System;

    class Solution {

        // Complete the stringConstruction function below.
        static int stringConstruction(string s)
        {
            var cnt = 0;
            var set=new HashSet<char>();
            foreach (var c in s)
            {
                if (!set.Contains(c))
                {
                    cnt++;
                    set.Add(c);
                }
            }

            return cnt;
        }

        static void Main(string[] args) {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++) {
                string s = Console.ReadLine();

                int result = stringConstruction(s);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}