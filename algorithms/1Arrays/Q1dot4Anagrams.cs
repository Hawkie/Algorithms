using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview1
{
    class Q1dot4Analgrams
    {
        public bool CheckAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            foreach (char c in s1)
            {
                var c1 = LetterCount(c, s1);
                var c2 = LetterCount(c, s2);
                if (c1 != c2)
                {
                    return false;
                }
            }
            return true;
        }

        public int LetterCount(char letter, string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                if (char.ToLower(c) == char.ToLower(letter))
                {
                    count++;
                }
            }
            return count;
        }

        [TestCase("awesome", "someawe", true)]
        [TestCase("Iamhappy", "pamyipah", true)]
        [TestCase("iamhappy", "gggpamyipahggg", false)]
        [TestCase("gggpamyipahggg", "iamhappy", false)]
        [TestCase("", "", true)]
        public void TestAnagram(string s1, string s2, bool expected)
        {
            Assert.AreEqual(expected, CheckAnagram(s1, s2));
        }
    }
}
