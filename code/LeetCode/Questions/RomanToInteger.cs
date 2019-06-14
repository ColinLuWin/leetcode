using System;
using System.Collections.Generic;

namespace LeetCode.Questions
{
    //https://leetcode.com/problems/roman-to-integer/

    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var map = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int len = s.Length;
            int num = 0;
            char last_char = s[len-1];
            for (int idx = len - 1; idx >= 0; --idx)
            {
                char c = s[idx];
                if (map[c] < map[last_char])
                    num -= map[c];
                else
                    num += map[c];

                last_char = c;
            }

            return num;
        }
    }
}
