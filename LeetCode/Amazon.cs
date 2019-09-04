using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Amazon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");

            List<int> input = new List<int> { 5, 15, 8, 9, 4 };
            var sum = 13;

            var output = Test(input, sum);

            Console.ReadLine();
        }

        public static List<int> Test(List<int> input, int sum)
        {
            var maxPair = new int[2];
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = i + 1; j < input.Count; j++)
                {
                    if (input[i] + input[j] == sum)
                    {
                        if (input[i] > input[maxPair[0]] || input[i] > input[maxPair[1]] 
                            || input[j] > input[maxPair[0]] || input[j] > input[maxPair[1]]){
                            maxPair[0] = i;
                            maxPair[1] = j;
                        }
                    }
                }
            }
            return new List<int> { maxPair[0], maxPair[1] };
        }




    }
}
