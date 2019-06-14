using System;

namespace LeetCode.Questions
{
    public class LongestCommonPrefix
    {
        public string GetLongestCommonPrefix(string[] strs)
        {
            string result = "";

            int idx = 0;
            bool isOver = false;
            while (true)
            {
                char current = strs[0][idx];
                foreach (var s in strs)
                {
                    if (s[0] != current)
                        isOver = true;

                    if (idx >= s.Length)
                        isOver = true;
                }

                result += current;

                if (isOver)
                    break;

                ++idx;
            }

            return result;
        }
    }
}
