using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class SubstringWORepeating
    {
        static void Main1(string[] args)
        {
            string hh = "abcb";

            var output = LengthOfLongestSubstring(hh);

            Console.WriteLine(output);
        }

        public static int LengthOfLongestSubstring(string s, int j =0)
        {
            var charArray = s.ToCharArray();

            if(charArray.Length == 1)
            {
                return 1;
            }

            var dict = new List<char>();
            var inElse = false;

            foreach (var item in charArray)
            {
                if (!dict.Contains(item))
                {
                    dict.Add(item);
                }
                else
                {
                    inElse = true;
                    var splitted = s.Split(item);
 
                    var hhh = splitted.Where(d => !d.ToCharArray().GroupBy(x => x).Any(h => h.Count() > 1)).Max(x => x.Length);

                    return hhh + 1;
                }

            }

            if (!inElse)
            {
                return dict.Count;
            }

            return 0;
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length, ans = 0;
            int[] index = new int[128]; // current index of character
                                        // try to extend the range [i, j]
            for (int j = 0, i = 0; j < n; j++)
            {
                i = Math.Max(index[s[j]], i);
                ans = Math.Max(ans, j - i + 1);
                index[s[j]] = j + 1;
            }
            return ans;
        }

    }

}
