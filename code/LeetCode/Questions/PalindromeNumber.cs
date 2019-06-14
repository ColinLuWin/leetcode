using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            if (x == 0)
                return true;

            List<int> ls = new List<int>();
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                ls.Add(pop);
            }

            int length = ls.Count;
            for (int idx = 0; idx <= length / 2; ++idx)
            {
                if (ls[idx] != ls[length - idx - 1])
                    return false;
            }

            return true;
        }
    }
}
